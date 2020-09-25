// RainFlow for DV SCADA Station Series
// DanH 2017/05/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DV_Station_SCADA_Series
{
    // Data Point
    class RainflowPoint
    {
        public int Index;
        public double X;  // for diagnostic X Chart
        public double Y;  // for diagnostic X Chart
        public double Y_Hit;  // Rainflow dropped here
        public int Y_Hit_Index;  // Rainflow dropped here Index

        public DateTime DateTime;
        public double Value;
    }

    // Enum Slope
    enum EnumSlope
    {
        eSlopePositive,
        eSlopeNegative,
        eSlopeInfinite,
        eSlopeZero
    };
    
    // Record
    class RainflowRecord
    {
        public int Index { get; set; }
        public RainflowPoint Point1 { get; set; }
        public RainflowPoint Point2 { get; set; }
        public EnumSlope Slope { get; set; }
        public int Count;
        public bool Skip_SameSlope = false;
        public double MinValue = double.MaxValue;
        public double MaxValue = double.MinValue;
    }



    class Rainflow
    {
        private bool IsDataLoaded = false;
        private System.Collections.Generic.List<RainflowRecord> RainFlowList  = new List<RainflowRecord>();
        List<HistoricalRecord> HistoricalRecordList;

        public bool _LoadData(DataTable aDataTable, int DateTimePos, int ValuePos)
        {
            try
            {
                // Load Data

                IsDataLoaded = true;
                return IsDataLoaded;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + Environment.NewLine + e.StackTrace);

                throw;  // Raise to Parent
            }
        }

        private void CountRainflow()
        {
            int iCyclicCount = 0;
            int i, iRecordPosition = 0;  // Set position in List
            int iDynamicPosition = 0;
            System.Diagnostics.Debug.Assert(RainFlowList.Count > 1, "RainFlowList.Count is Empty");

            try
            {
                // Calculate Pressure Cycles
                do
                {
                    // Read until Slope changes
                    iRecordPosition = iDynamicPosition;
                    iDynamicPosition = iRecordPosition;
                    do
                    {
                        iDynamicPosition++;  // Next record
                        if (iDynamicPosition == RainFlowList.Count - 1)
                            break;  // Finished


                        if (RainFlowList[iDynamicPosition].Slope != EnumSlope.eSlopeZero)  // Ignore Zero Slope
                            if (RainFlowList[iRecordPosition].Slope != RainFlowList[iDynamicPosition].Slope)  // i = Original Position
                            {
                                // Cyclic Cycle
                                RainFlowList[iDynamicPosition - 1].Count = iCyclicCount++; // DanH 20170722 Offset by -1
                                //RainFlowList[iDynamicPosition].Count = iCyclicCount++;  // Commented out.  This moves past peak 

                                break;
                            }
                    } while (iRecordPosition < RainFlowList.Count - 1);

                } while (iDynamicPosition < RainFlowList.Count - 1);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + Environment.NewLine + e.StackTrace);

                throw;  // Raise to Parent
            }
        }

        public bool ProcessData(DataTable aDataTable, int DateTimePos, int ValuePos)
        {
            int iRow = 0;
            RainflowPoint PointPrevious = null;  // Declare when neded, after 1st point

            try
            {
                //if (!IsDataLoaded)
                //{
                //    // Load Data first,
                //    MessageBox.Show("Data is not loaded", "Error");
                //    return false;
                //}

                // Process Data
                foreach (DataRow row in aDataTable.Rows)
                {
                    RainflowPoint PointCurrent = new RainflowPoint();

                    // Skip if null
                    System.Diagnostics.Debug.Assert(row != null, "Data cannot be null" + row.ToString());
                    if (row[0] == null)
                    {
                        // Assert False
                        return true; ;
                    }

                    // Skip first row
                    if (iRow == 0)
                    {
                        PointCurrent.DateTime = System.Convert.ToDateTime(row.ItemArray[DateTimePos]);
                        PointCurrent.Value = System.Convert.ToDouble(row.ItemArray[ValuePos]);
                    }

                    else
                    {
                        PointCurrent.DateTime = System.Convert.ToDateTime(row.ItemArray[DateTimePos]);
                        PointCurrent.Value = System.Convert.ToDouble(row.ItemArray[ValuePos]);
                    
                        RainflowRecord RainflowRecord = new RainflowRecord();

                        // Calculate Slope
                        RainflowRecord.Index = iRow;
                        RainflowRecord.Point1 = PointPrevious;
                        RainflowRecord.Point2 = PointCurrent;
                        RainflowRecord.Slope = CalculateSlope(PointCurrent, PointPrevious); ;

                        RainFlowList.Add(RainflowRecord);
                    }
                    iRow++;  // Increment

                    PointPrevious = new RainflowPoint();
                    PointPrevious = PointCurrent;
                }

                CountRainflow();

                return true; //  IsDataLoaded;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + Environment.NewLine + e.StackTrace);

                throw;  // Raise to Parent
            }
        }

        private EnumSlope CalculateSlope(RainflowPoint PointCurrent, RainflowPoint PointPrevious)
        {
            double slope = 0;

            // All paths return a result
            if (PointCurrent.DateTime == PointPrevious.DateTime)
                return EnumSlope.eSlopeInfinite;  // Infite slope
            else if (PointCurrent.Value == PointPrevious.Value)
                return EnumSlope.eSlopeZero;  // Infite slope
            else
            {
                //slope = (PointCurrent.Value - PointPrevious.Value) / (Convert.ToDouble(PointCurrent.DateTime) - Convert.ToDouble(PointPrevious.DateTime));
                double dSeconds = PointCurrent.DateTime.Subtract(PointPrevious.DateTime).TotalSeconds;
                slope = (PointCurrent.Value - PointPrevious.Value) / dSeconds;

                if (slope > 0)
                    return EnumSlope.eSlopePositive;
                else
                    return EnumSlope.eSlopeNegative;
            }

        }

        public void OutputDebugList(string aFilename, string aFooter)
        {
            int iCounter = 0;
            double dPressure, dTimeSec;

            // Write the string to a file.
            System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(aFilename);

            RainflowRecord lastRecord = RainFlowList[0];

            // Header
            swOutputFile.WriteLine("RECORD_INDEX\tdPRESSURE\tdTime (s)\tdRECORD_COUNT");

            foreach (RainflowRecord record in RainFlowList)
            {
                if (record.Slope != lastRecord.Slope)
                {
                    // TODO:  Verify below code and to be removed if below is functional.  Below is old code.
                    dPressure = record.Point2.Value - lastRecord.Point1.Value;
                    dTimeSec = record.Point2.DateTime.Subtract(lastRecord.Point1.DateTime).TotalSeconds;

                    // DanH 2017/07/22
                    dPressure = record.Point1.Value - lastRecord.Point1.Value;
                    dTimeSec = record.Point1.DateTime.Subtract(lastRecord.Point1.DateTime).TotalSeconds;

                    //swOutputFile.WriteLine(record.Index + "\t" + record.Point1.DateTime.ToString() + "\t" + record.Point1.Value.ToString() + "\t" +
                    //         record.Point2.DateTime.ToString() + "\t" + record.Point2.Value.ToString() + "\t" + record.Slope + "\t" +
                    //         record.Count);
                    //swOutputFile.WriteLine(
                    //        record.Index + "\t" + 
                    //        lastRecord.Point1.DateTime.ToString() + "\t" + lastRecord.Point1.Value.ToString() + "\t" +
                    //        lastRecord.Point2.DateTime.ToString() + "\t" + lastRecord.Point2.Value.ToString() + "\t" +
                    //        record.Point1.DateTime.ToString() + "\t" + record.Point1.Value.ToString() + "\t" +
                    //        record.Point2.DateTime.ToString() + "\t" + record.Point2.Value.ToString() + "\t" + dPressure.ToString("0.0") + "\t" +
                    //        dTimeSec.ToString("0.0") + "\t" + (record.Index - lastRecord.Index) + "\t" + (record.Count - lastRecord.Count));

                    swOutputFile.WriteLine(
                            record.Index + "\t" +
                            dPressure.ToString("0.0") + "\t" +
                            dTimeSec.ToString("0.0") + "\t" + (record.Count - lastRecord.Count));

                    lastRecord = record;

                    // Flush
                    if (iCounter % 10000 == 0)
                        swOutputFile.Flush();
                }
                else
                {
                    iCounter++;
                }

            }

            if (aFooter.Length > 0)
            {
                swOutputFile.WriteLine(aFooter);
                // Write Duration
                swOutputFile.WriteLine("Start " + RainFlowList[0].Point1.DateTime.ToString() +
                        ", End " + RainFlowList[RainFlowList.Count - 1].Point2.DateTime.ToString() +
                        ", Duration " + RainFlowList[RainFlowList.Count - 1].Point2.DateTime.Subtract(RainFlowList[0].Point1.DateTime).TotalDays +
                        " days");
            }

            swOutputFile.Close();
        }

        public void CountCycleforBIN(string aBINFilename, string aOutputFolder, double aLowPassValue, bool aUseValueNoisy)
        {
            int result = 0;  // Return number of cycles
            string outputFilename;
            Rainflow Rainflow = new Rainflow();
            DateTime DateTimeLoadDataTable = DateTime.Now;

            DatasetPacket DatasetPacket = new DatasetPacket();

            // Load Data
            HistoricalRecordList = DatasetPacket.DeSerialize(aBINFilename);

            if (HistoricalRecordList == null)
            {
                return;
            }

            DateTime DateTimeRainflow = DateTime.Now;
            int iRow = 0;
            RainflowPoint PointPrevious = null;  // Declare when neded, after 1st point

            try
            {
                // Process Data
                foreach (HistoricalRecord row in HistoricalRecordList)
                {
                    RainflowPoint PointCurrent = new RainflowPoint();

                    PointCurrent.DateTime = row.Time;

                    // Use Value or Value with Noise
                    if (aUseValueNoisy)
                        PointCurrent.Value = row.ValueNoisy;
                    else
                        PointCurrent.Value = row.Value;

                    // Skip first row
                    if (iRow == 0)
                    {
                        // Do nothing
                    }
                    else
                    {
                        RainflowRecord RainflowRecord = new RainflowRecord();

                        // Calculate Slope
                        RainflowRecord.Index = iRow;
                        RainflowRecord.Point1 = PointPrevious;
                        RainflowRecord.Point2 = PointCurrent;

                        // If > Low Pass Filter then Add to RainFlowList
                        if (Math.Abs(PointCurrent.Value - PointPrevious.Value) > aLowPassValue)
                        {
                            RainflowRecord.Slope = CalculateSlope(PointCurrent, PointPrevious); ;

                            RainFlowList.Add(RainflowRecord);  // RainFlowList is Class RainFlow Property
                        }
                    }
                    iRow++;  // Increment

                    PointPrevious = new RainflowPoint();
                    PointPrevious = PointCurrent;
                }

                CountRainflow();

                if (aUseValueNoisy)
                  outputFilename = aOutputFolder + "\\" + System.IO.Path.GetFileName(aBINFilename) + "_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".CYCLESNoise.CSV";
                else
                  outputFilename = aOutputFolder + "\\" + System.IO.Path.GetFileName(aBINFilename) + "_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".CYCLES.CSV";


                OutputDebugList(outputFilename, aBINFilename + ", low pass = " + aLowPassValue +
                    ", use noise = " + aUseValueNoisy.ToString() + ", " + DateTime.Now.ToString());
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + Environment.NewLine + e.StackTrace);

                throw;  // Raise to Parent
            }

            DateTime DateTimeCompleted = DateTime.Now;
            string sHeader = DateTimeLoadDataTable.ToString() + ", " + DateTimeRainflow.ToString() + ", " + DateTimeCompleted.ToString();
            sHeader = sHeader + Environment.NewLine + "Load Data (s)            : " + DateTimeRainflow.Subtract(DateTimeLoadDataTable).TotalSeconds;
            sHeader = sHeader + Environment.NewLine + "Count Rainflow cycles (s): " + DateTimeCompleted.Subtract(DateTimeRainflow).TotalSeconds;
            //            Rainflow.OutputDebugList(@"C:\Project\3SE\Vessel\NK\SCADA\RAINFLOW" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".TXT", sHeader);
            //            OutputDebugList(aOutputFolder + "\\" + System.IO.Path.GetFileName(aBINFilename) + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".TXT", sHeader);

            // System.Diagnostics.Debug.WriteLine(sHeader);  // 2017/09/30 DanH
            
        }
    }
}
