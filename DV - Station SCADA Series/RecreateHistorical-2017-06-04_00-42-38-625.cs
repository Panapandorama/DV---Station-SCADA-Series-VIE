using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace DV_Station_SCADA_Series
{
    [Serializable()]
    class HistoricalRecord
    {
        // tagId	time	value	dataQuality	ownSysId	datasetId	fieldTime
        // 0        1       2       3 
        public DateTime Time { get; set; }
        public double Value { get; set; }
        public int DataQuality { get; set; }
        public int DataSetGroup { get; set; }  // Source of this group of data
        public double ValueNoisy { get; set; }
    }

    class RecreateHistorical
    {
        private DatasetPacket datasetPacket;
        public DatasetPacket DatasetPacket
        {
            // Property for Stack Watch
            get
            {
                return datasetPacket;
            }
            set
            {
                datasetPacket = value;
            }
        }

        private DataTable dataTable;
        public DataTable DataTable
        {
            // Property for Stack Watch
            get
            {
                return dataTable;
            }
            set
            {
                dataTable = value;
            }
        }

        private System.Collections.Generic.List<DatasetPacketBookmark> DatasetPacketList = new List<DatasetPacketBookmark>();
        private System.Collections.Generic.List<HistoricalRecord> HistoricalRecordList = new List<HistoricalRecord>();
        
        public void RecreatePast(int aPastYears, int aFutureYears, DataTable aDataTable, 
            int aFactorSmooth,  // 5 to 10,  Smoothing Range,  Default 5
            int aFactorNoise    // +/- FN / 100                Default 100
            )
        {
            // Apply Noise  Value = Value*(1+Noise(MV)/Smoothing)
            //  Check (aFactorNoise > 200)
            System.Diagnostics.Debug.Assert((aFactorNoise >= 0) && (aFactorNoise < 200), "Warning:  Noise Factor is High at " + aFactorNoise);
            System.Diagnostics.Debug.Assert((aFactorSmooth >= 3) && (aFactorSmooth < 10), "(aFactorSmooth > 5) && (aFactorSmooth < 10), aFactor Smooth = " + aFactorSmooth);
            double factorSmooth = 0, factorNoise = 0, valueNoisy = 0;
            double smoothNoise = 0;  // Value = Value * (1 + Noise)
            Random rand = new Random();

            // Creates and initializes a new Queue.
            System.Collections.Queue QueueNoise = new System.Collections.Queue(aFactorSmooth);


            DateTime StartDate = new System.DateTime(2017 - aPastYears, 12, 31, 12, 0, 0);
            DateTime EndDate = new System.DateTime(2017 + aFutureYears, 12, 31, 12, 0, 0);
            DateTime DateCurrent = StartDate;
            DatasetPacketBookmark DatasetPacketBookmark = new DatasetPacketBookmark();

            TimeSpan timeSpan;
            double secTotal = 0, secDelta, value;
            int iCounter = 0;

            DateTime PacketPreviousDate, PacketCurrentDate;
            DateTime LogDateTime = DateTime.MinValue;

            do
            {
                System.Diagnostics.Debug.Assert(datasetPacket != null, "DatasetPacket is not Set");
                
                // Select a Packet Bookmarks book ends
                DatasetPacketBookmark = DatasetPacket.GetRandomPacketGroup();

                // Read two records to get start time
                int iPacketStartIndex = DatasetPacketBookmark.IndexStart;

                dataTable = aDataTable;  // Set DataTable

                PacketPreviousDate = (DateTime)dataTable.Rows[iPacketStartIndex][Constant.FLD_TIME];  // tagId	time	value	dataQuality	ownSysId	datasetId	fieldTime

                double noiseTotal = 0;
;
                for (int i = DatasetPacketBookmark.IndexStart + 1; i < DatasetPacketBookmark.IndexEnd; i++)  // + 1
                {
                    PacketCurrentDate = (DateTime)dataTable.Rows[i][Constant.FLD_TIME];  // tagId	time	value	dataQuality	ownSysId	datasetId	fieldTime
                    secDelta = PacketCurrentDate.Subtract(PacketPreviousDate).TotalSeconds;
                    secTotal = secTotal + secDelta;
                    PacketPreviousDate = PacketCurrentDate;
                    LogDateTime = StartDate.AddSeconds(secTotal);
                    value = (double)dataTable.Rows[i][Constant.FLD_VALUE];

                    // Apply Noise  Value = Value*(1+Noise(MV)/Smoothing)  
                    factorNoise = (double)rand.Next(-1 * aFactorNoise, aFactorNoise);

                    QueueNoise.Enqueue(factorNoise);

                    if (iCounter >= aFactorSmooth)
                    {
                        noiseTotal = 0;
                        foreach (Object obj in QueueNoise)
                        {
                            noiseTotal = noiseTotal + (double)obj; 
                        }

                        smoothNoise = noiseTotal / (double)aFactorNoise;  // Moving Average
                        smoothNoise = smoothNoise / (double)aFactorSmooth;

                        QueueNoise.Dequeue();
                    }

                    // Store to List
                    HistoricalRecord HistoricalRecord = new HistoricalRecord();
                    HistoricalRecord.Time = LogDateTime;
                    HistoricalRecord.Value = value;
                    valueNoisy = value * (1 + smoothNoise);
                    HistoricalRecord.ValueNoisy = valueNoisy; 
                    HistoricalRecord.DataQuality = System.Convert.ToInt16(dataTable.Rows[i][Constant.FLD_DATAQUALITY]);
                    HistoricalRecord.DataSetGroup = DatasetPacketBookmark.Index;
                    HistoricalRecordList.Add(HistoricalRecord);

                    // Diagnostics
                    if (iCounter < 100)
                        System.Diagnostics.Debug.WriteLine(i.ToString("000") + "\t" + secDelta.ToString("0.0") + "\t" +
                            LogDateTime.ToString() + "\t" + value.ToString("0.0") + "\t" + valueNoisy.ToString("0.0"));

                    iCounter++;
                    if (iCounter > 1E6)
                        break;  // Circuit Breaker
                }
            }
            while (LogDateTime < EndDate);

            string filename = @"C:\TEMP\Serialize_from" + aPastYears.ToString() + "_to_" + aFutureYears.ToString() + "_" +
                    DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".BIN";
            SerializeTo(filename, HistoricalRecordList);

            // Histogram
            DateTime DateTimeHisto1 = DateTime.Now;

            StatHisto StatHisto = new StatHisto();
            StatHisto.Initialize(Constant.FLD_SUCTION_MAX, Constant.FLD_SUCTION_BIN_RANGE);

            for (int iList = 0; iList < HistoricalRecordList.Count; iList++)
            {
                StatHisto.UpdateBin(HistoricalRecordList[iList].Value);
            }

            double timeDiff = DateTime.Now.Subtract(DateTimeHisto1).TotalSeconds;
            StatHisto.SaveToFile(filename + ".HISTOGRAM.CSV", filename + ", processed in " + timeDiff.ToString("00") + " s");


            // Apply Noise
            for (int iList = 0; iList < HistoricalRecordList.Count; iList++)
            {
                StatHisto.UpdateBin(HistoricalRecordList[iList].ValueNoisy);
            }

            timeDiff = DateTime.Now.Subtract(DateTimeHisto1).TotalSeconds;
            StatHisto.SaveToFile(filename + ".HISTOGRAM_WITH_NOISE.CSV", filename + ", processed in " + timeDiff.ToString("00") + " s");

        }


        public void OutputDebugList(string aFilename, string aHeader)
        {
            try
            {
                // Write the string to a file.
                System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(aFilename);

                swOutputFile.Close();
            }
            catch (Exception e)
            {

            }

        }

        public void SerializeTo(string aFilename, System.Collections.Generic.List<HistoricalRecord> aHistoricalRecordList)
        {
            try
            {
                // https://www.dotnetperls.com/serialize-list
                try
                {
                    using (Stream stream = File.Open(aFilename, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, aHistoricalRecordList);
                    }
                }
                catch (IOException)
                {
                }
                
            }
            catch (IOException)
            {
            }
        }
    }
}
