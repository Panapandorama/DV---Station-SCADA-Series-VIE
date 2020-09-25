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
    public partial class FormASME_SN : Form
    {
        public FormASME_SN()
        {
            InitializeComponent();

            MakeChartZoomable();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            double LN_SN = 0, E_SN = 0;
            double step = (double)numericUpDownStep.Value;

            if (checkBoxClearChart.Checked)
            {
                for (int i = 0; i < chartASME_SN.Series.Count; i++)
                    this.chartASME_SN.Series[i].Points.Clear();
            }

            // LN(25)
            // http://www.iaea.org/inis/collection/NCLCollectionStore/_Public/27/004/27004400.pdf

            double Ratio_Yield_to_Tensile = (double)(numericUpDownYield.Value / numericUpDownTensile.Value);

            double T = (double)numericUpDownTemperature.Value;

            chartASME_SN.ChartAreas[0].AxisX.LabelStyle.Format = "#";
            try
            {
                // Loop Ea (Strain) 1 to .15, step 0.05
                for (double Ea = 0.8; Ea >= 0.15; Ea = Ea - step)
                {
                    // Tensile
                    if (Ea > 0.14)
                    {
                        // 0.8
                        if (Ea == 0.8)
                        {
                            chartASME_SN.Series[0].Points.AddXY(0, Ea);
                        }

                        E_SN = Calc_LN_SN(Ea, T, 1);
                        chartASME_SN.Series[0].Points.AddXY(E_SN, Ea);

                        richTextBoxData.AppendText(E_SN.ToString("0000") + ", " + Ea.ToString("0.00") + "\n");
                    }
                }
                    richTextBoxData.AppendText("---Yield---\n");

                // Loop Ea (Strain) 1 to .15, step 0.05
                for (double Ea = 0.8; Ea >= 0.15; Ea = Ea - step)
                {
                    // Yield
                    if (Ea * Ratio_Yield_to_Tensile > 0.14)
                    {
                        // 0.8
                        if (Ea == 0.8)
                        {
                            chartASME_SN.Series[1].Points.AddXY(0, Ea);
                        }

                        E_SN = Calc_LN_SN(Ea, T, Ratio_Yield_to_Tensile);

                        System.Diagnostics.Debug.WriteLine(E_SN.ToString() + ", " + Ea.ToString());

                        chartASME_SN.Series[1].Points.AddXY(E_SN, Ea);
                        richTextBoxData.AppendText(E_SN.ToString() + ", " + Ea.ToString() + "\n");
                    }
                }

                richTextBoxData.AppendText("---Derated Yield---\n");

                // Loop Ea (Strain) 1 to .15, step 0.05
                for (double Ea = 0.8; Ea >= 0.15; Ea = Ea - step)
                {    // De-rated Yield
                    if (numericUpDownConfidence.Value < 1)
                    {
                        if (Ea * Ratio_Yield_to_Tensile > 0.14)
                        {
                            // 0.8
                            if (Ea == 0.8)
                            {
                                chartASME_SN.Series[2].Points.AddXY(0, (double)numericUpDownConfidence.Value * Ea);
                            }

                            E_SN = Calc_LN_SN(Ea, T, Ratio_Yield_to_Tensile);

                            chartASME_SN.Series[2].Points.AddXY(E_SN, (double)numericUpDownConfidence.Value * Ea);
                            richTextBoxData.AppendText(E_SN.ToString() + ", " + ((double)numericUpDownConfidence.Value * Ea).ToString() + "\n");
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                throw;
            }

    // Y = a1*ln(%SMYS)+y0*certainty
    //double x = 0, y = 0;
    //for (double dSMYS = .15; dSMYS <= .90; dSMYS = dSMYS + 0.05)
    //{
    //    y = dSMYS;

    //    x = (double)numericUpDownA1.Value * Math.Log(y) + (double)numericUpDownY0.Value * (double)numericUpDownConfidence.Value/100;

    //    chartASME_SN.Series[0].Points.AddXY(x, y);
    //    richTextBoxData.AppendText(x.ToString() + ", " + y.ToString());
    //}
}

        private double Calc_LN_SN(double Ea, double T, double Ratio_Y_T)
        {
            double LN_SN = 0, E_SN = 0;
            double iW = 0;
            double S = 0, O = 0, E = 0;

            //Yield or Tensile because formula is based on Tensile.  Need to de-rate for Yield
            try
            {
                // Log Exception
                if (Ea < 0.15 )
                    return 999999;
                else
                {
                    Ea = Ea * Ratio_Y_T;
                    LN_SN = (6.667 - 0.766 * iW) - (1.687 + 0.184 * 1) * Math.Log(Ea - 0.15 + 0.04 * 1) -
                               (0.097 - 0.382 * iW) * 1 - 0.00133 * T * (1 - iW) + 0.554 * S * T * O * E;
                }
                E_SN = Math.Exp(LN_SN);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

            return E_SN;
        }

        private void MakeChartZoomable()
        {
            // Enable range selection and zooming end user interface
            chartASME_SN.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
            chartASME_SN.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
            chartASME_SN.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            chartASME_SN.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;

            // Y Zoomable  DanH 2015/07/01
            chartASME_SN.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
            chartASME_SN.ChartAreas["ChartArea1"].CursorY.AutoScroll = true;

            // Set Reverse value for X axis 
            chartASME_SN.ChartAreas["ChartArea1"].AxisX.IsReversed = false;


        }
    }
}
