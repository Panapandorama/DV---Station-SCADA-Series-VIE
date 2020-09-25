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
    public partial class Distribution_Raw_SCADA_by_ACCDB : Form
    {
        public Distribution_Raw_SCADA_by_ACCDB()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DV_Station_Series_Util DV_Station_Series_Util = new DV_Station_Series_Util();

            DateTime DateTimeLoadDataTable = DateTime.Now;

            DVGMap.DataTableUtils DataTableUtils = new DVGMap.DataTableUtils();

            DataTable DataTable1 = DataTableUtils.LoadACCDBToDataTable(textBoxACCDB.Text, textBoxTableQuery.Text);

            int iCount = DataTable1.Rows.Count;

            toolStripStatusLabelStatus.Text = "Loading " + iCount.ToString() + " records.  Please wait";

            try
            {
                // Shorten and change for Access import  DanH 2017/08/09
                string path = System.IO.Path.GetDirectoryName(textBoxACCDB.Text);
                string filename = path + "\\" + textBoxTableQuery.Text + @"_Distribution" +
                        DateTime.Now.ToString("yyyy_MM_dd_HH_mm") + ".CSV";

                StatHisto StatHisto = new StatHisto();

                double maxPressure = (double)numericUpDownMaxPressure.Value;
                double minPressure = (double)numericUpDownMinPressure.Value;
                StatHisto.Initialize((double)numericUpDownMOP.Value, minPressure, maxPressure, (double)numericUpDownBinCount.Value);

                foreach (DataRow dataRow in DataTable1.Rows)
                {
                    StatHisto.UpdateBin(System.Convert.ToDouble(dataRow["VALUE"]));
                }

                double timeDiff = DateTime.Now.Subtract(DateTimeLoadDataTable).TotalSeconds;
                StatHisto.SaveToFile(filename, filename + ", processed in " + timeDiff.ToString("00") + " s", false);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Completion time
            int duration = (int)DateTime.Now.Subtract(DateTimeLoadDataTable).TotalSeconds;
            toolStripStatusLabelStatus.Text = "Finished processing " + iCount.ToString() + " records in " + duration.ToString() + " seconds";

        }
    }
}
