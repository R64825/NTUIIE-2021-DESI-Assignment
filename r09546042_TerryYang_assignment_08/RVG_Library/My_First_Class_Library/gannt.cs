using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Random_Variate_Generator_Library
{
    public class gannt : Discrete_Event_Simulation_Engine
    {
        Series sever_gantt;
        public void plot(double current_Client_In_Node, double previous_Client_In_Node, Discrete_Event head_Event, double last_Event_Time)
        {
            DataPoint dp = new DataPoint();
            dp.XValue = 1;
            dp.YValues = new double[] { last_Event_Time, head_Event.Event_Time };
            if (previous_Client_In_Node == 0)
            {
                dp.Color = Color.Green;
            }
            else
            {
                dp.Color = Color.Red;
            }
            sever_gantt.Points.Add(dp);
        }
        public Series creat_series()
        {
            sever_gantt = new Series();
            sever_gantt.ChartType = SeriesChartType.RangeBar;
            return sever_gantt;
        }

        public void Reset()
        {
            sever_gantt.Points.Clear();
        }
    }
}