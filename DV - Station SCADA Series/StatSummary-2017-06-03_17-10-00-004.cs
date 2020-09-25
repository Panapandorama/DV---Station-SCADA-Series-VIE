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
        public int Total;
    }

    class StatHisto
    {
        List<StatBinRecord> StatBinList = new List<StatBinRecord>();

        public void SaveToFile(string aFilename, string aHeader)
        {
            try
            {
                // Write the string to a file.
                System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(aFilename);
                swOutputFile.WriteLine(aHeader);
                swOutputFile.WriteLine(DateTime.Now.ToString());
                // Find Bin
                for (int i = 0; i < StatBinList.Count; i++)
                {
                    swOutputFile.WriteLine(StatBinList[i].RangeFrom.ToString("0.0") + "\t" +
                            StatBinList[i].RangeTo.ToString("0.0") + "\t" +
                            StatBinList[i].Total.ToString("0"));
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
                    StatBinList[i].Total++;
                    result = i;
                    break;
                }
            }

            System.Diagnostics.Debug.Assert(result != -999, "Value not in Range, value = " + aValue.ToString());

            return result;
        }


        public void Initialize(double aMax,  int aBinCount)
        {
            double dRange = (aMax) / (double)(aBinCount - 1);  // First bin is Vacum to Zero
            double RangeFrom = 0, RangeTo = -999;

            for (int i = 0; i < aBinCount; i++)
            {
                StatBinRecord BinRec = new StatBinRecord();
                RangeTo = RangeTo + dRange;

                if (i == 0)
                {
                    BinRec.RangeFrom = -2000;
                    BinRec.RangeTo = 0;
                }
                else if (i == aBinCount)
                {
                    BinRec.RangeFrom = RangeFrom;
                    BinRec.RangeTo = +2000;
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
