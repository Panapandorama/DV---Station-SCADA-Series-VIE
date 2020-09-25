using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DV_Station_SCADA_Series
{

    public partial class FormCycleHisto : Form
    {
        // Setup Histo
        List<HistoValue> ListHisto;

        public FormCycleHisto()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // 50 PSI ranges, -1000 to +1000
            double maxRange = Constant.FLD_CYCLE_MAX, minRange = Constant.FLD_CYCLE_MIN, interval = Constant.FLD_CYCLE_BIN_INTERVAL;

            int binCount = (int)((maxRange - minRange) / interval) + 1;

            // New Object to clear previous HistoList
            ListHisto = new List<HistoValue>();

            double fromValue = minRange, toValue = minRange + interval;
            for (int i = 0; i < binCount; i++)
            {
                HistoValue Value = new HistoValue();
                // Set Ranges
                toValue = fromValue + interval;
                Value.ValueFrom = fromValue;
                Value.ValueTo = toValue;
                Value.Count = 0;  // Always zero
                ListHisto.Add(Value);

                // Update next ranges
                fromValue = toValue;
            }

            // Set bookends to infinity
            ListHisto[0].ValueFrom = -999999;
            ListHisto[ListHisto.Count - 1].ValueTo = +999999;
            DV_Station_Series_Util DV_Station_Series_Util = new DV_Station_Series_Util();

            DateTime DateTimeLoadDataTable = DateTime.Now;

            DVGMap.DataTableUtils DataTableUtils = new DVGMap.DataTableUtils();

            toolStripStatusLabel1.Text = "Loading " + textBoxMDB.Text + "\\" + textBoxTable.Text;
            Application.DoEvents();

            // Process Cycles Table
            DataTable DataTableMDB = DataTableUtils.LoadACCDBToDataTable(textBoxMDB.Text, textBoxTable.Text);

            int iCount = DataTableMDB.Rows.Count;

            int duration = (int)DateTime.Now.Subtract(DateTimeLoadDataTable).TotalSeconds;

            // Fill HistoList
            FillHistoList(DataTableMDB, ListHisto);


            // Write to file
            string filename = System.IO.Path.GetDirectoryName(textBoxMDB.Text) + "\\" + textBoxTable.Text + "_HISTO.CSV";
            System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(filename);

            swOutputFile.WriteLine("FROM, TO, COUNT, MIN, MAX, AVG, START_PRESSURE, DURATION");
            // Loop through Histo
            for (int i = 0; i < ListHisto.Count - 1; i++)
            {
                swOutputFile.WriteLine(ListHisto[i].ValueFrom.ToString() + ", " + ListHisto[i].ValueTo.ToString() + ", " +
                    ListHisto[i].Count.ToString() + ", " + ListHisto[i].ValueMin.ToString() + ", " + ListHisto[i].ValueMax.ToString() + ", " +
                    ListHisto[i].ValueAvg.ToString() + ", " + ListHisto[i].PressureStart.ToString() + ", " + ListHisto[i].Duration.ToString());
            }

            swOutputFile.Close();
            toolStripStatusLabel1.Text = "Saved to " + filename;
        }

        private void FillHistoList(DataTable DataTableMDB, List<HistoValue> ListHisto)
        { 
            double value = -999999;
            bool bRangeFound = false;

            // Recurse Table
            foreach (DataRow row in DataTableMDB.Rows)
            {
                value = System.Convert.ToDouble(row["dPRESSURE"]);

                // Loop through Histo
                for (int i = 0; i < ListHisto.Count -1; i++)
                {
                    bRangeFound = false;

                    if ((value >= ListHisto[i].ValueFrom) && (value < ListHisto[i].ValueTo))
                    {
                        // Min 
                        if (value < ListHisto[i].ValueMin)
                            ListHisto[i].ValueMin = value;
                        // Max
                        if (value > ListHisto[i].ValueMax)
                            ListHisto[i].ValueMax = value;

                        // Used for Sum and Averaged afterwards
                        ListHisto[i].ValueAvg = ListHisto[i].ValueAvg + value;

                        // Add to Bin
                        ListHisto[i].Count++;

                        // System.Diagnostics.Debug.WriteLine("MATCHED: " + row[0].ToString() + ", " + i.ToString() + ", " + value.ToString() + ", " + ListHisto[i].Count.ToString());

                        bRangeFound = true;

                        break;  // Break out of loop, found the range.
                    }
                }
                if (!bRangeFound)
                {
                    // Should not reach here
                    System.Diagnostics.Debug.WriteLine("NOT MATCHED: value = " + value.ToString());
                }

            }

            // Set Averages
            // Loop through Histo
            for (int i = 0; i < ListHisto.Count - 1; i++)
            {
                if (ListHisto[i].Count == 0)
                {
                    ListHisto[i].ValueMin = 0; ListHisto[i].ValueMax = 0; ListHisto[i].ValueAvg = 0;
                }
                else
                    ListHisto[i].ValueAvg = ListHisto[i].ValueAvg / ListHisto[i].Count;
            }
        }

    }
    public class HistoValue
    {
        public double ValueFrom;
        public double ValueTo;
        public double ValueMin = double.MaxValue;
        public double ValueMax = double.MinValue;
        public double ValueAvg;  // Used for Sum and Averaged afterwards
        public int Count;

        // Time (seconds)
        public double Duration;

        // Pressure Range
        public double PressureStart;
    }

}
