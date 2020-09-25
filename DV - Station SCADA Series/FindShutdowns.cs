using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_Station_SCADA_Series;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.OleDb;

namespace DV_Station_SCADA_Series
{
    public partial class FindShutdowns : Form
    {
        DataTable DataTable;
        DVGMap.DataTableUtils DBUtil;

        public FindShutdowns()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            DVGMap.DataTableUtils DataTableUtils = new DVGMap.DataTableUtils();

            string ACCDBName = @"C:\Project\3SE\Vessel\ks\SIMULATION\ks 2012 TO 2017.accdb";

            // Load FTA
            string QueryName = "Qry_Manifold";
            DataTable = DataTableUtils.LoadACCDBToDataTable(ACCDBName, QueryName);
            DataTable.TableName = QueryName;

            SeekShutdown(DataTable, 5, System.IO.Path.GetDirectoryName(ACCDBName), 1);

            // Load FTB
            QueryName = "Qry_Flow";
            DataTable = DataTableUtils.LoadACCDBToDataTable(ACCDBName, QueryName);
            DataTable.TableName = QueryName;

            SeekShutdown(DataTable, 5, System.IO.Path.GetDirectoryName(ACCDBName), 1);

            // Load FTB
            QueryName = "Qry_Line";  // Includes derate
            DataTable = DataTableUtils.LoadACCDBToDataTable(ACCDBName, QueryName);
            DataTable.TableName = QueryName;

            SeekShutdown(DataTable, 5, System.IO.Path.GetDirectoryName(ACCDBName), 1);

        }

        private void LoadToChart(string aACCDBName, string aQueryName)
        {
        }


        // aShutdownRange values where shutdown could be ie +/-10 PSI
        private void SeekShutdown(DataTable aDataTable, double aShutdownRange, string aFolder, double aShutdownHour)
        {
            double lastValue = 0, currentValue = 0, diffValue = 0;
            int iCounter = 0, iLastMatchCounter = 0;
            DateTime lastDateTime = DateTime.MaxValue, currentDateTime = DateTime.MaxValue;
            double timeDiff = 999, lastTimeDiff = 0;
            string line = "";

            // Stream
            string filename = aFolder + "\\" + aDataTable.TableName + "_SeekShutDown_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".CSV";
            // Write the string to a file.
            System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(filename);

            try
            {
                foreach (DataRow dataRow in DataTable.Rows)
                {
                    currentValue = System.Convert.ToDouble(dataRow["Value"]);

                    currentDateTime = System.Convert.ToDateTime(dataRow["Time"]);
                    // currentDateTime = System.Convert.ToDateTime(dataRow["DateTime"]);

                    if (iCounter == 0)
                    {
                        lastValue = currentValue;
                        lastDateTime = currentDateTime;
                        timeDiff = 0;
                        iCounter++;
                    }
                    else
                    {
                        diffValue = Math.Abs(currentValue);

                        if (diffValue < aShutdownRange)
                        {
                            timeDiff = timeDiff + currentDateTime.Subtract(lastDateTime).TotalHours;  // Hour difference
                            iLastMatchCounter = iCounter;
                            lastTimeDiff = timeDiff;
                        }
                        else if (currentDateTime.Subtract(lastDateTime).TotalHours > aShutdownHour)
                        {
                            timeDiff = currentDateTime.Subtract(lastDateTime).TotalHours;  // Hour difference
                            iLastMatchCounter = iCounter;
                            lastTimeDiff = timeDiff;
                        }
                        else
                        {
                            timeDiff = 0;
                        }
                    }

                    if ((iCounter - iLastMatchCounter) == 1)   // (timeDiff > aShutdownHour)  // Hours
                    {
//                        if (iLastMatchCounter > iCounter)
                        {
                            line = iCounter.ToString() + "," + currentDateTime.ToString() + "," + lastTimeDiff.ToString("00.000") + ",hour";
                            swOutputFile.WriteLine(line);
                            // System.Diagnostics.Debug.WriteLine(line);
                            timeDiff = 0;
                            iLastMatchCounter = 0;

                            lastTimeDiff = 0;

                        }

                    }

                    lastValue = currentValue;
                    lastDateTime = currentDateTime;

                    iCounter++;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            swOutputFile.Close();
        }

        //private void LoadToChartSparce(DataTable aDataTable, double aGap)
        //{
        //    double lastValue = 0, currentValue = 0;
        //    int iCounter = 0;
        //    chart1.Series.Add(aDataTable.TableName);
        //    chart1.Series[chart1.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        //    DateTime dateTime;

        //    try
        //    {

        //        foreach (DataRow dataRow in DataTable.Rows)
        //        {
        //            currentValue = System.Convert.ToDouble(dataRow["Value"]);
        //            dateTime = System.Convert.ToDateTime(dataRow["DateTime"]);

        //            // System.Diagnostics.Debug.WriteLine(iCounter.ToString() + ", " + currentValue.ToString());

        //            // ID, TagID, Time, Vale
        //            if (Math.Abs(lastValue - currentValue) < aGap)
        //                continue;
        //            else
        //            {
        //                chart1.Series[chart1.Series.Count - 1].Points.AddXY(dateTime, currentValue);

        //                if ((iCounter % 1000) == 0)
        //                {
        //                    toolStripStatusLabelStatus.Text = "Loading record " + iCounter.ToString();
        //                    Application.DoEvents();
        //                }

        //                lastValue = currentValue;
        //            }
        //            iCounter++;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

    }
}
