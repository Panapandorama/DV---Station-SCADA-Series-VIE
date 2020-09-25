using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGMap
{
    public partial class FormChartOption : Form
    {
        public FormChartOption()
        {
            decimal MIN_VALUE = -9999999, MAX_VALUE = 9999999;
            InitializeComponent();

            // DanH 20150701
            numericUpDownXMin.Minimum = MIN_VALUE;  // XMin/XMax
            numericUpDownXMin.Maximum = MAX_VALUE;
            numericUpDownXMax.Minimum = MIN_VALUE;
            numericUpDownXMax.Maximum = MAX_VALUE;
            numericUpDownYMin.Minimum = MIN_VALUE;  // YMin/YMax
            numericUpDownYMin.Maximum = MAX_VALUE;
            numericUpDownYMax.Minimum = MIN_VALUE;
            numericUpDownYMax.Maximum = MAX_VALUE;



            numericUpDownXMax.Value = MAX_VALUE;
            numericUpDownYMin.Value = MIN_VALUE;
            numericUpDownYMax.Value = MAX_VALUE;
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        public System.Windows.Forms.DataVisualization.Charting.Chart chart
        {
            get
            {
                return chart1;
            }
            set
            {
                chart1 = value;
            }
        }

        // Synchronize other charts - sort of Kludgy DanH 2015/07/02
        public bool SynchronizeAllCharts
        {
            get
            {
                return this.checkBoxSynchronize.Checked;
            }
        }

        public void SetViewExtent(double aXMin, double aXMax, double aYMin, double aYMax)
        {
            numericUpDownXMin.Value = (decimal)aXMin;
            numericUpDownXMax.Value = (decimal)aXMax;
            numericUpDownYMin.Value = (decimal)aYMin;
            numericUpDownYMax.Value = (decimal)aYMax;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Assert(chart1 != null, "Chart is Null");

            // X-Axis

            // Set Logarithmic scale
            if (chart1.ChartAreas["Default"].AxisX.IsLogarithmic != this.checkBoxLogithmic.Checked)
                chart1.ChartAreas["Default"].AxisX.IsLogarithmic = this.checkBoxLogithmic.Checked;

            // Set Auto scale.
            if (checkBoxAutoScale.Checked)
            {
                // Set auto minimum and maximum values.
                chart1.ChartAreas["Default"].AxisX.Minimum = Double.NaN;
                chart1.ChartAreas["Default"].AxisX.Maximum = Double.NaN;
            }
            else
            {
                // if changed minimum and maximum values.
                if ((chart1.ChartAreas["Default"].AxisX.Minimum != (double)numericUpDownXMin.Value) ||
                        (chart1.ChartAreas["Default"].AxisX.Maximum != (double)numericUpDownXMax.Value))
                {
                    // Set manual minimum and maximum values.
                    chart1.ChartAreas["Default"].AxisX.Minimum = (double)numericUpDownXMin.Value;
                    chart1.ChartAreas["Default"].AxisX.Maximum = (double)numericUpDownXMax.Value;
                }
            }

            // Y-Axis

            // Set Logarithmic scale
            if (chart1.ChartAreas["Default"].AxisY.IsLogarithmic != this.checkBoxLogithmic.Checked)
                chart1.ChartAreas["Default"].AxisY.IsLogarithmic = this.checkBoxLogithmic.Checked;

            // Set Auto scale.
            if (checkBoxAutoScale.Checked)
            {
                // Set auto minimum and maximum values.
                chart1.ChartAreas["Default"].AxisY.Minimum = Double.NaN;
                chart1.ChartAreas["Default"].AxisY.Maximum = Double.NaN;
            }
            else
            {
                // if changed minimum and maximum values.
                if ((chart1.ChartAreas["Default"].AxisY.Minimum != (double)numericUpDownYMin.Value) ||
                        (chart1.ChartAreas["Default"].AxisY.Maximum != (double)numericUpDownYMax.Value));
                {
                    // Set manual minimum and maximum values.
                    chart1.ChartAreas["Default"].AxisY.Minimum = (double)numericUpDownYMin.Value;
                    chart1.ChartAreas["Default"].AxisY.Maximum = (double)numericUpDownYMax.Value;
                }
            }

            Hide();  // Hide this Chart Option Form

        }
    }
}
