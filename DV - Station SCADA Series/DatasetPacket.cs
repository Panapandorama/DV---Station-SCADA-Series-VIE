// RainFlow for DV SCADA Station Series
// DanH 2017/05/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace DV_Station_SCADA_Series
{
    // Record
    [Serializable()]
    class DatasetPacketBookmark
    {
        public int Index { get; set; }
        public int IndexStart { get; set; }
        public int IndexEnd { get; set; }
        public int Gap { get; set; }
    }

    class DatasetPacket
    {
        private System.Collections.Generic.List<DatasetPacketBookmark> DatasetPacketList = new List<DatasetPacketBookmark>();
        Random Rnd = new Random();
        
        public DatasetPacketBookmark GetRandomPacketGroup()
        {
            // 
            //int iIndex = Rnd.Next(0, DatasetPacketList.Count - 1);
            // Rand.Next is Between but not reaching Max 
            // DanH 2017/10/16
            try
            {
                int iIndex = Rnd.Next(0, DatasetPacketList.Count);

                return DatasetPacketList[iIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool ProcessDatapacket(DataTable aDataTable, int aDateTimePos, int aGapValue)
        {
            int iRow = 0, iIndex=0;
            DateTime DateTimeStart = DateTime.MinValue, DateTimeCurrent = DateTime.MinValue, DateTimeLast = DateTime.MinValue;
            int iIndexStart = 0, dGapValueSec = 0;
            int iTotalRows = aDataTable.Rows.Count - 1;
            try
            {
                // Process Data
                foreach (DataRow row in aDataTable.Rows)
                {
                    // Skip if null
                    System.Diagnostics.Debug.Assert(row != null, "Data cannot be null" + row.ToString());
                    if (row[0] == null)
                    {
                        // Assert False
                        return true; ;
                    }

                    DateTimeCurrent = (DateTime)row.ItemArray[aDateTimePos];  // Current

                    // Skip first row
                    if (iRow == 0)
                    {
                        DateTimeStart = DateTimeCurrent;  // Start
                        iIndexStart = 0;
                    }
                    else
                    {
                        dGapValueSec = (int)DateTimeCurrent.Subtract(DateTimeLast).TotalSeconds;

                        //                        if (dGapValueSec > aGapValue)
                        // Include the last group
                        // 2017/10/16 DanH
                        if ((dGapValueSec > aGapValue) || (iRow == iTotalRows))
                            {
                                // Store record
                                DatasetPacketBookmark DatasetPacketBookmark = new DatasetPacketBookmark();
                            DatasetPacketBookmark.Index = iIndex;
                            DatasetPacketBookmark.IndexStart = iIndexStart;
                            DatasetPacketBookmark.IndexEnd = iRow - 1;  // 2017/06/17 DanH  Revised to - 1
                            DatasetPacketBookmark.Gap = dGapValueSec;
                            DatasetPacketList.Add(DatasetPacketBookmark);

                            iIndexStart = DatasetPacketBookmark.IndexEnd + 1;
                            // 2017/06/17 DanH  Commented out below
                            // iIndexStart = iRow;

                            iIndex++;
                        }
                    }

                    //if (System.Convert.ToInt16(row[3]) > 160)
                    //    System.Diagnostics.Debug.WriteLine(row.ToString() + ", " + row[3].ToString() + ", " + iIndex.ToString() + ", " + dGapValueSec.ToString("0"));

                    iRow++;  // Increment

                    // Store last points
                    DateTimeLast = DateTimeCurrent;


                }

                return true; // Done
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + Environment.NewLine + e.StackTrace);

                throw;  // Raise to Parent
            }
        }

         public void OutputDebugList(string aFilename, string aHeader)
        {
            int iCounter = 0;

            // Write the string to a file.
            System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(aFilename);

            foreach (DatasetPacketBookmark record in DatasetPacketList)
            {
                swOutputFile.WriteLine(record.Index + "\t" + record.Index.ToString("00") + "\t" +
                        record.IndexStart.ToString("00") + "\t" +
                        record.IndexEnd.ToString("00") + "\t" +
                        record.Gap.ToString("00"));

                // Flush
                if (iCounter % 10000 == 0)
                    swOutputFile.Flush();

                iCounter++;
            }

            // Write Duration
            swOutputFile.WriteLine("DatasetPacketList");

            if (aHeader.Length > 0)
            {
                swOutputFile.WriteLine(aHeader);
            }

            swOutputFile.Close();
        }

        public List<HistoricalRecord> DeSerialize(string aBINFilename)
        {
            if (!System.IO.File.Exists(aBINFilename))
            {
                MessageBox.Show("File does not exists " + aBINFilename);
                return null;
            }
            else
            {
                List<HistoricalRecord> HistoricalRecordList = new List<HistoricalRecord>();

                string filename = aBINFilename;
                try
                {
                    HistoricalRecord HistoricalRecord = new HistoricalRecord();
                    using (Stream stream = File.Open(filename, FileMode.Open))
                    {
                        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        
                        HistoricalRecordList = (List<HistoricalRecord>)bin.Deserialize(stream);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return HistoricalRecordList;
            }

        }
    }
}
