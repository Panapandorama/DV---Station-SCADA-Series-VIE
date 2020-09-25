using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DV_Station_SCADA_Series
{
    class StatSummary
    {
    }

    // Bin for Histogram
    class StatBinRecord
    {
        public double RangeFrom;
        public double RangeTo;
        public int TotalCount;
        public double Min = double.MaxValue;
        public double Max = double.MinValue;
        public double RunningSum;  // For Average later
    }

    class StatHisto
    {
        public List<StatBinRecord> StatBinList = new List<StatBinRecord>();

        public void SaveToFile(string aFilename, string aFooter, bool aWriteFooter)
        {
            double avg = 0, min = 0, max = 0;
            try
            { 
                // Write the string to a file.
                System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(aFilename);
                swOutputFile.WriteLine("From,To,Count,Average,Min,Max");

                // Find Bin
                for (int i = 0; i < StatBinList.Count; i++)
                {
                    if (StatBinList[i].TotalCount == 0)
                    {
                        avg = -999;
                        min = -999;
                        max = -999;
                    }
                    else
                    {
                        avg = StatBinList[i].RunningSum / (double)StatBinList[i].TotalCount;
                        min = StatBinList[i].Min;
                        max = StatBinList[i].Max;
                    }

                    swOutputFile.WriteLine(StatBinList[i].RangeFrom.ToString("0.0") + "," +
                            StatBinList[i].RangeTo.ToString("0.0") + "," +
                            StatBinList[i].TotalCount.ToString("0") + "," +
                            avg.ToString("0.0") + "," +
                            min.ToString("0.0") + "," +
                            max.ToString("0.0"));
                }

                // 2017/09/23 DanH
                if (aWriteFooter)
                {
                    swOutputFile.WriteLine(aFooter);
                    swOutputFile.WriteLine(DateTime.Now.ToString());
                }
                swOutputFile.Close();
                }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

        }

        public int UpdateBin(double aValue)
        {
            int result = -999;  // Bin Value

            // Find Bin
            for (int i = 0; i < StatBinList.Count; i++)
            {
                if ((StatBinList[i].RangeFrom <= aValue) && (aValue < StatBinList[i].RangeTo))
                {
                    StatBinList[i].TotalCount++;

                    // Min / Max
                    if (aValue < StatBinList[i].Min)
                        StatBinList[i].Min = aValue;

                    if (aValue > StatBinList[i].Max)
                        StatBinList[i].Max = aValue;

                    StatBinList[i].RunningSum = StatBinList[i].RunningSum + aValue;

                    result = i;
                    break;
                }
            }

            if (result == -999)
                MessageBox.Show("Not in Bin, value " + aValue);

            System.Diagnostics.Debug.Assert(result != -999, "Value not in Range, value = " + aValue.ToString());

            return result;
        }


        public int Initialize(double aMOP, double aMin, double aMax, double aRange)
        {
            //int BinMin = (int)Math.Ceiling(aMOP / aRange) + 2;
            //int BinMax = (int)((aMax - aMOP)/ aRange) + 1;            

            // Example:  Min=-500, Max=500, MOP = 275.  Min of -500 is for pressure cycles
            int BinMin = (int)aMin;  // -500
            int BinMax = (int)aMax;  // +500


            //int BinCount = BinMin + BinMax;
            int BinCount = (int)((aMax - aMin) / aRange) + 2;

            for (int i = 0; i < BinCount; i++)
            {
                StatBinRecord BinRec = new StatBinRecord();

                if (i == 0)  // -Infinity
                {
                    BinRec.RangeFrom = -999999;
                    // BinRec.RangeTo = -2 * aRange;
                    BinRec.RangeTo = aMin - aRange;
                }
                else if (i == BinCount - 1) // +Infinity
                {
                    BinRec.RangeFrom = StatBinList[i - 1].RangeTo;
                    BinRec.RangeTo = 999999; 
                }
                else
                {
                    BinRec.RangeFrom = StatBinList[i - 1].RangeTo;
                    BinRec.RangeTo = StatBinList[i - 1].RangeTo + aRange;
                }

                StatBinList.Add(BinRec);
            }

            return BinCount;
        }

        public void Initialize(double aMax,  int aBinCount)
        {
            double dRange = (aMax) / (double)(aBinCount - 2);  // First bin is Vacum to Zero
            double RangeFrom = 0, RangeTo = 0;

            for (int i = 0; i < aBinCount; i++)
            {
                StatBinRecord BinRec = new StatBinRecord();
                RangeTo = RangeTo + dRange;

                if (i == 0)  // First Bin -20 to -2000
                {
                    RangeTo = -20;
                    BinRec.RangeFrom = -999999;
                    BinRec.RangeTo = RangeTo;
                }
                else if (i == aBinCount - 1)  // Last Bin aMax to 2000
                {
                    BinRec.RangeFrom = StatBinList[StatBinList.Count - 1].RangeTo;
                    BinRec.RangeTo = +999999;
                }
                else  
                {
                    BinRec.RangeFrom = RangeFrom;
                    BinRec.RangeTo = RangeTo;
                }

                StatBinList.Add(BinRec);
                RangeFrom = RangeTo;

            }

        }

    }
}
