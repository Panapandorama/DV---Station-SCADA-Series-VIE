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
    public partial class FormSparseLoadChart : Form
    {
        const string FLD_ID = "ID";
        const string FLD_DATETIME = "Time";
        const string FLD_VALUE = "Value";
        const string FLD_DATA_QUALITY = "dataQuality";

        List<QC_Data> ListQCData = new List<QC_Data>();

        public FormSparseLoadChart()
        {
            InitializeComponent();

            MakeChartZoomable();
        }

        private void MakeChartZoomable()
        {
            // Enable range selection and zooming end user interface
            chart1.ChartAreas["Default"].CursorX.IsUserEnabled = true;
            chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["Default"].AxisX.ScrollBar.IsPositionedInside = true;

            // Y Zoomable  DanH 2015/07/01
            chart1.ChartAreas["Default"].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas["Default"].CursorY.AutoScroll = true;

            // Set Reverse value for X axis  DanH 2015/07/01
            chart1.ChartAreas["Default"].AxisX.IsReversed = true;


        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // QC Data
            ScreenData();

        }

        private void ScreenData()
        {
            TimeSpan gap; 
            double minGap = (double)numericUpDownGapMin.Value;
            int iRow = 0;
            DateTime timePrevious = DateTime.MinValue, timeCurrent = DateTime.MinValue;
            string line = "";

            // Load all data
            LoadData();

            string outputFile = "";

            if (checkBoxDataGap.Checked)
            {
                for (int i = 0; i < ListQCData.Count; i++)
                {

                    DataTable DataTable = ListQCData[i].DataTable;
                    string fileFOLDER = System.IO.Path.GetDirectoryName(textBoxACCDB.Text);  // @"C:\Project\3SE\Vessel\MT\SCADA\SIMULATION";

                    // Write the string to a file.
                    outputFile = fileFOLDER + "\\" + "DATA_GAP_" + ListQCData[i].Name + ".CSV";
                    System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(outputFile);

                    // Header
                    swOutputFile.WriteLine("Gap_Hr, Index, Datetime");

                    // Recurse Table
                    foreach (DataRow row in DataTable.Rows)
                    {
                        timeCurrent = (DateTime)row[FLD_DATETIME];
                        iRow++;

                        if (iRow == 0)
                        {
                            timePrevious = timeCurrent;
                            continue;
                        }
                        else
                        {
                            gap = timeCurrent.Subtract(timePrevious);

                            if (gap.TotalHours > minGap)
                            {
                                line = gap.TotalHours.ToString("00") + ", " + row[FLD_ID].ToString() + "," + row[FLD_DATETIME];
                                // System.Diagnostics.Debug.WriteLine(line);
                                swOutputFile.WriteLine(line);
                            }
                        }

                        timePrevious = timeCurrent;
                    }

                    toolStripStatusLabel1.Text = "Saved to " + outputFile;
                    swOutputFile.Close();
                }
            }
        }

        private void LoadData()
        {
            string queryName;
            
            /*
            SELECT [FT__AILIN(1000913)].ID, [FT__AILIN(1000913)].tagId, [FT__AILIN(1000913)].Time, [FT__AILIN(1000913)].value, 
            [FT__AILIN(1000913)].dataQuality, [FT__AILIN(1000913)].ownSysId, [FT__AILIN(1000913)].datasetId, 
            [FT__AILIN(1000913)].fieldTime
            FROM [FT__AILIN(1000913)];
             */
            int iCount = textBoxDataSet.Lines.Count();
            if (iCount == 0)
            {
                MessageBox.Show("There is no data to load.");
                return;
            }

            DV_Station_Series_Util DV_Station_Series_Util = new DV_Station_Series_Util();

            DateTime DateTimeLoadDataTable = DateTime.Now;

            DVGMap.DataTableUtils DataTableUtils = new DVGMap.DataTableUtils();

            for (int i = 0; i < iCount; i++)
            {
                queryName = textBoxDataSet.Lines[i].ToString();

                toolStripStatusLabel1.Text = "Loading " + textBoxACCDB.Text + "\\" + queryName;
                Application.DoEvents();

                // Process Cycles Table
                DataTable DataTable = new DataTable();
                DataTable = DataTableUtils.LoadACCDBToDataTable(textBoxACCDB.Text, queryName);

                QC_Data QC_Data = new QC_Data();
                QC_Data.DataTable = DataTable;
                QC_Data.Name = queryName;
                ListQCData.Add(QC_Data);
               
            }

        }
    }

    // Load data for QC
    class QC_Data
    {
        public DataTable DataTable;
        public string Name;
        public int Value_Index;
        public DateTime DateTime_Index;
    }
}
