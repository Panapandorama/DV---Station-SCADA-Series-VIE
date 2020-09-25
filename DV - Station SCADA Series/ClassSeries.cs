using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;  // 2014/08/06 DanH Dundas.Charting.WinControl;
using System.Data;

namespace DataView
{
    
    
    class ClassSeries
    {
        const string WELD_NUM_FLD =     "Weld2008";
        const string CHAINAGE_2008_FLD = "Chainage2008";
        const string ELEVATION_CHART =  "Elevation";
        const string DEFAULT_CHART =    "Default";
        //const string FLD_CHAINAGE = "Chainage";  // 2015/06/20 DanH
        const string FLD_TIMESTAMP = "Timestamp";
//        bool NPS16Selected = false;
//        bool NPS20Selected = false;
        bool NPS3Selected = false;
        bool NPS4Selected = false;
        bool NPS6Selected = false;

        private bool IsItemSelected(System.Windows.Forms.CheckedListBox aCheckedListBox,
                string aColName)
        {
            bool result = false;  // Assume false

            for (int i = 0; i < aCheckedListBox.CheckedItems.Count; i++)
            {
                if ((string)aCheckedListBox.CheckedItems[i] == aColName)
                {
                    return true;
                }
            }

            return result;
        }

        public void CreateForSelection(System.Windows.Forms.CheckedListBox aCheckedListBox,
                DataTable aDataTable)
        {
            if (aDataTable.Rows.Count == 0)
            {
                System.Diagnostics.Debug.Assert(false, "aDataTable.Rows.Count == 0");

                return;
            }

            DataRow dataRow = aDataTable.Rows[0];
            for (int i = 0; i < aDataTable.Columns.Count; i++)
            {

                if (i > 0)  // 0=ID
                {
                    aCheckedListBox.Items.Add(aDataTable.Columns[i].ColumnName);
                }
            }
        }
        
        private int SplitColumnNameToYear(string aColName)
        {
            // Given Avg2006, return 2006
            // Given Max2004, return 2004
            int result = 0;
            try
            {
                int pos = aColName.IndexOf("20");

                if (pos <= 0)
                    return -1;  // No year in field

                result = System.Convert.ToInt16(aColName.Remove(0, pos));
                return result;
            }
            catch
            {
                throw null;  // TODO:  Declare conversion exception
                throw (new ArgumentException("Series must have a YEAR '" + aColName + "' is not valid.  Example, Avg2008, Something20XX"));

            }
        }

        // Not required, left here for further testing 2017/02/24 Dan
        private void SynchronizeCharts(System.Windows.Forms.DataVisualization.Charting.Chart aChart,
                string aChartArea1, string aChartArea2)
        {
            // Make Chart Area 2 align to Chart Area 1
            aChart.ChartAreas[aChartArea1].AlignWithChartArea = aChartArea2;

            // Set the alignment type
            //aChart.ChartAreas[aChartArea1].AlignType = AreaAlignType.Position |
            //                                                AreaAlignType.PlotPosition |
            //                                                AreaAlignType.Cursor |
            //                                                AreaAlignType.AxesView;    
        }

        // Remove all chart areas
        private void CreateChartsAreas(System.Windows.Forms.DataVisualization.Charting.Chart aChart, // 2014/08/06 DanH System.Windows.Forms.DataVisualization.Charting.Chart aChart,
                System.Windows.Forms.TextBox aAdditionalCharts)
        {
            string colName = "";

            // Remove Elevation chart if it exists
            while (aChart.ChartAreas.Count > 1)
            {
                aChart.ChartAreas.RemoveAt(1);
            }

            for (int i = 0; i < aAdditionalCharts.Lines.Count(); i++)
            {
                colName = aAdditionalCharts.Lines[i];
                aChart.ChartAreas.Add(colName);
                aChart.ChartAreas[colName].AxisY.Title = colName;
            }
        }

        private string GetAdditionalChartAreaForSeries(System.Windows.Forms.TextBox aAdditionalCharts,
                string aColName)
        {
            string result = "";  // assume false

            // Compare with wildcards
            for (int i = 0; i < aAdditionalCharts.Lines.Count(); i++)
            {
                if (aColName.Contains(aAdditionalCharts.Lines[i]))
                {
                    result = aAdditionalCharts.Lines[i];
                    break;
                }
            }
         
            return result;
        }

        private bool IsSkipNPS(int aNPS)
        {
            if ((aNPS == 3) && NPS3Selected == false)
                return true;
            else if ((aNPS == 4) && NPS4Selected == false)
                return true;
            else if ((aNPS == 6) && NPS6Selected == false)
                return true;
            else
            {
                return false;
            }
        }

        public void CreateSeriesForSelection(System.Windows.Forms.CheckedListBox aCheckedListBox,
                System.Windows.Forms.DataVisualization.Charting.Chart aChart, // System.Windows.Forms.DataVisualization.Charting.Chart aChart,
                DataTable aDataTable,
                System.Windows.Forms.ListBox aChartTypeListBox,
                System.Windows.Forms.CheckedListBox aXAxisCheckedListBox,  // Joint, Year, Chainage
                System.Windows.Forms.TextBox aAdditionalCharts,
                string aXAxisFieldName)
                                                                           
        {
            Random rnd = new Random();
            string colName = "";
            bool bWarningDataType = false;  // Avoid repeated warnings 2015/06/20 DanH

            // Create Chart Areas based on user settings
            CreateChartsAreas(aChart, aAdditionalCharts);
            
            for (int iSeries = 0; iSeries < aCheckedListBox.CheckedItems.Count; iSeries++)
            {
                colName = (string)aCheckedListBox.CheckedItems[iSeries];

                // Add series
                // Todo: Check existing series 2015/06/20 DanH
                if (aChart.Series.IndexOf(colName) >= 0)
                {
                    int index = aChart.Series.IndexOf(colName);
                    aChart.Series.Remove(aChart.Series[index]);
                }

                Series series = aChart.Series.Add(colName);
                // DateTime X-Axis
                if ((aXAxisFieldName.IndexOf("Date") >= 0) || (aXAxisFieldName.IndexOf("Time") >= 0))
                {
                    series.XValueType = ChartValueType.DateTime;
                }

                string chartAreaName = GetAdditionalChartAreaForSeries(aAdditionalCharts, colName);
                if (chartAreaName.Length > 0)
                {
                    // Synchronize with Default
                    // Not required, now set on FormChartOptions, commented out below 2017/02/24 Dan
                    // SynchronizeCharts(aChart, chartAreaName, DEFAULT_CHART);

                    series.ChartArea = chartAreaName;
                }
                else
                {
                    series.ChartArea = DEFAULT_CHART;
                }

                // Set legend docking DanH 2015/07/01
                aChart.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;

                // Graph style
                if (aChartTypeListBox.Text == "Bar")
                    series.ChartType = SeriesChartType.Bar;
                else if (aChartTypeListBox.Text == "Point")
                    series.ChartType = SeriesChartType.Point;
                else if (aChartTypeListBox.Text == "Line")
                    series.ChartType = SeriesChartType.Line;
                else if (aChartTypeListBox.Text == "Spline")
                    series.ChartType = SeriesChartType.Spline;
                else
                    System.Windows.Forms.MessageBox.Show("Unsupported chart type");

                series.MarkerStyle = MarkerStyle.Square;

                series.BorderWidth = 2;

                // Data type Object
                object value = null;

                foreach (DataRow dataRow in aDataTable.Rows)
                {
                    if (dataRow[FLD_TIMESTAMP].ToString() == "")  // Skip Nulls
                        continue;

                                        // Check DataType
                    if (aDataTable.Columns[colName].DataType == (typeof(String)))
                    {
                        if (!bWarningDataType)
                        {
                            System.Windows.Forms.MessageBox.Show(aDataTable.Columns[colName].ToString() +
                                " are textual data and cannot be plotted.");
                            bWarningDataType = true;
                        }
                        // DanH 2015/06/20 String = 0, 
                        // continue;
                    }        

                    // Check DataType
                    if (aDataTable.Columns[colName].DataType == (typeof(DateTime)))
                    {
                        if (dataRow[colName].ToString() == "")  // Skip Nulls
                            value = new DateTime(1960, 01, 01);
                        else
                            value = dataRow[colName];  //(DateTime)dataRow[colName];
                    }
                    else if ((aDataTable.Columns[colName].DataType == (typeof(Double)) || (aDataTable.Columns[colName].DataType == (typeof(Single)))))
                    {
                        // Value of cell
                        if (dataRow[colName].ToString() == "")  // Skip Nulls
                            value = 0;
                        else
                            value = dataRow[colName];  //(double)dataRow[colName];
                    }
                    else if (aDataTable.Columns[colName].DataType == (typeof(Int16)))
                    {
                        // Value of cell
                        if (dataRow[colName].ToString() == "")  // Skip Nulls
                            value = 0;
                        else
                            value = dataRow[colName];  //System.Convert.ToInt16(dataRow[colName]);
                    }
                    // String is Zero 2015/06/20 DanH
                    else if (aDataTable.Columns[colName].DataType == (typeof(String)))
                    {
                        // Value of cell
                        value = 0;
                    }

                    // Add Data By joint
                    if (value == null)
                        continue;

                    series.Points.AddXY(dataRow[aXAxisFieldName], value);

                    aChart.ChartAreas["Default"].AxisX.Title = aXAxisFieldName;

                }


            }

        }

    }
}
