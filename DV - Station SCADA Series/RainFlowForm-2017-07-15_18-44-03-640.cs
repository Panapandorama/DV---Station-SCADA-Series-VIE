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
    public partial class RainFlowForm : Form
    {
        public RainFlowForm()
        {
            InitializeComponent();
        }

        private void GeneratePoints(int aCount)
        {
            Random rand = new Random();
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < aCount; i++)
            {
                chart1.Series[0].Points.AddXY(i, rand.Next(-100, 100));
            }

        }

        private void RainflowCounting()
        {
            int count = chart1.Series[0].Points.Count;
            Rainflow Rainflow = new Rainflow();  // Class
            System.Collections.Generic.List<RainflowRecord> RainFlowList = new List<RainflowRecord>();
            double minValue = Double.MaxValue, maxValue = Double.MinValue;


            // Rainflow Count
            RainflowRecord CurrentSlope, NextSlope;


            // Load to List
            for (int i = 0; i < count - 1; i++)
            {
                RainflowRecord RainflowRecord = new RainflowRecord();  // Property
                RainflowRecord.Point1.X = chart1.Series[0].Points[i].XValue;
                RainflowRecord.Point1.Y = chart1.Series[0].Points[i].YValues[0];

                RainflowRecord.Point2.X = chart1.Series[0].Points[i + 1].XValue;
                RainflowRecord.Point2.Y = chart1.Series[0].Points[i + 1].YValues[0];

                RainFlowList.Add(RainflowRecord);
            }

            // Set Slopes
            // Parse List
            for (int i = 0; i < RainFlowList.Count; i++)
            {
                if (RainFlowList[i].Point1.Y < RainFlowList[i + 1].Point1.Y)
                    RainFlowList[i].Slope = EnumSlope.eSlopePositive;
                else if (RainFlowList[i].Point1.Y > RainFlowList[i + 1].Point1.Y)
                    RainFlowList[i].Slope = EnumSlope.eSlopeNegative;
                else if (RainFlowList[i].Point1.Y == RainFlowList[i + 1].Point1.Y)
                    RainFlowList[i].Slope = EnumSlope.eSlopeZero;
                else
                {
                    // Should never reach here
                    System.Diagnostics.Debug.Assert(false, "ERROR - Unknown slope");
                }
            }

            // Set Hit Min Max
            for (int i = 0; i < RainFlowList.Count - 1; i++)
            {
                CurrentSlope = RainFlowList[i];

                if (RainFlowList[i].Slope == EnumSlope.eSlopePositive)
                {
                    CurrentSlope.MinValue = CurrentSlope.Point1.Y;
                    CurrentSlope.MaxValue = CurrentSlope.Point2.Y;

                }
                if (RainFlowList[i].Slope == EnumSlope.eSlopePositive)
                {
                    CurrentSlope.MinValue = CurrentSlope.Point2.Y;
                    CurrentSlope.MaxValue = CurrentSlope.Point1.Y;
                }
            }



            // Parse List, Case 1:  Same Slope
            for (int i = 0; i < RainFlowList.Count - 1; i++)
            {
                CurrentSlope = RainFlowList[i];
                NextSlope = RainFlowList[i + 1];

                if (CurrentSlope.Slope == NextSlope.Slope)
                {
                    RainFlowList[i].Skip_SameSlope = true;
                }
            }




            // Parse List, Case 2:  Different Slope
            for (int i = 0; i < RainFlowList.Count - 1; i++)
            {
                CurrentSlope = RainFlowList[i];

                // Same slope
                if (CurrentSlope.Skip_SameSlope)
                    continue;

                if ((CurrentSlope.Slope == EnumSlope.eSlopeZero) || (CurrentSlope.Slope == EnumSlope.eSlopeInfinite))
                {
                    break;
                }

                // Loop to the end
                for (int j = i; j < RainFlowList.Count; j++)
                {
                    minValue = CurrentSlope.Point1.Y;
                    maxValue = CurrentSlope.Point2.Y;


                    NextSlope = RainFlowList[j];

                    // if eSlopePositive
                    if (CurrentSlope.Slope == EnumSlope.eSlopePositive)
                    {
                        if (NextSlope.Slope == EnumSlope.eSlopeNegative)
                        {
                            if (NextSlope.Point2.Y <= CurrentSlope.Point1.Y)  // 2 | 1
                            {
                                CurrentSlope.Point2.Y_Hit = maxValue;
                                CurrentSlope.Point2.Y_Hit_Index = i;
                            }
                        }
                        else if (NextSlope.Slope == EnumSlope.eSlopePositive)  // Non consecutive after Case 1
                        {
                            if (NextSlope.Point2.Y >= CurrentSlope.Point2.Y)  // 
                            {
                                // Set Max Value
                                if (maxValue < NextSlope.Point2.Y)
                                {
                                    maxValue = NextSlope.Point2.Y;

                                    CurrentSlope.Point2.Y_Hit = maxValue;
                                    NextSlope.Point2.Y_Hit = j;  // Rain dropped on NextSlope
                                    CurrentSlope.Point2.Y_Hit_Index = j;

                                }


                            }
                        }

                    }
                    // if eSlopePositive
                    else if (CurrentSlope.Slope == EnumSlope.eSlopeNegative)
                    {
                        if (NextSlope.Slope == EnumSlope.eSlopeNegative)
                        {
                            if (NextSlope.Point2.Y <= CurrentSlope.Point2.Y)  // 2 | 3
                            {
                                CurrentSlope.Point2.Y_Hit = CurrentSlope.Point2.Y;  // No Change
                                CurrentSlope.Point2.Y_Hit_Index = -999;
                            }
                        }
                        else if (NextSlope.Slope == EnumSlope.eSlopePositive)
                        {
                            if (NextSlope.Point2.Y >= CurrentSlope.Point2.Y)  // 
                            {
                                CurrentSlope.Point2.Y_Hit = NextSlope.Point1.Y;
                                NextSlope.Point2.Y_Hit = CurrentSlope.Point2.Y;  // Rain dropped on NextSlope

                                CurrentSlope.Point2.Y_Hit_Index = j;

                            }
                        }


                    }

                }


            }

        }
    }
}
