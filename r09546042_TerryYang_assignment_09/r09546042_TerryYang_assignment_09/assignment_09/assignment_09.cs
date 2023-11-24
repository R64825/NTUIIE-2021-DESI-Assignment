using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using My_First_Class_Library;
using Random_Variate_Generator_Library;


namespace WindowsFormsApp1
{
    public partial class assignment_09 : Form
    {
        ExponenitalRVG demand_Event_Generator;
        UniformRVG delivery_Lag_Generator;
        Discrete_Event_Simulation_Model my_Model;
        int NumberOfServers;
        double Cease_Time;


        public assignment_09()
        {
            InitializeComponent();
            
        }
        public void Chart_SYN()
        {
            //Scyn two charts
            ChartArea ca1 = Chart_StepLine.ChartAreas[0];
            ChartArea ca2 = Chart_gantt.ChartAreas[0];
            Axis ax1 = ca1.AxisX;
            Axis ax2 = ca2.AxisX;
            ax1.ScaleView.Zoomable = true;
            ax2.ScaleView.Zoomable = true;

            ca1.CursorX.IsUserSelectionEnabled = true;
            ca2.CursorY.IsUserSelectionEnabled = true;
            ca2.CursorX.IsUserSelectionEnabled = true;
        }
        public void Chart_Reset(Chart c)
        {
            c.Series.Clear();
            c.ChartAreas.Clear();
            c.Titles.Clear();
            c.Legends.Clear();
        }

        public void Refresh_PropertyGrid(PropertyGrid p)
        {
            p.Refresh();
        }
        private void BTN_reset_Click(object sender, EventArgs e)
        {
            Chart_Reset(Chart_Pie);
            Chart_Reset(Chart_StepLine);
            Chart_Reset(Chart_gantt);
            Chart_StepLine.ChartAreas.Add("ChartArea1");
            Chart_gantt.ChartAreas.Add("ChartArea1");

            CB_animate.Checked = false;
            Timer_Animation.Enabled = false;

            NumberOfServers = Convert.ToInt32(TB_NumberOfServers.Text);
            Cease_Time = Convert.ToDouble(TB_CeaseTime.Text);

            my_Model = Discrete_Event_Simulation_Model.Creat_A_SSQ_Model(NumberOfServers, Cease_Time, CB_multiple_queue.Checked);
            BTN_run_all.Enabled = true;
            BTN_run_one.Enabled = true;

            // create Gantt chart
            List<Server> servers = my_Model.Get_All_Servers();
            List <TimedQueue> queues = my_Model.Get_All_Queue();

            for (int i = 0; i < NumberOfServers; i++)
            {
                servers[i].pie_States.ChartArea = $"ChartArea{i+1}";
                Chart_Pie.Series.Add(servers[i].pie_States);

                Title title = new Title(); title.Text = servers[i].Name;
                title.DockedToChartArea = $"ChartArea{i + 1}";
                title.Alignment = ContentAlignment.MiddleRight;
                Chart_Pie.Titles.Add(title);

                Chart_Pie.ChartAreas.Add($"ChartArea{i + 1}");


                Chart_gantt.Series.Add(servers[i].gantt_States);
            }            

            // adding step line
            Chart_StepLine.Series.Add(my_Model.Simulation_Engine.Get_Step_Line());
            for (int i = 0; i < queues.Count; i++)
            {
                Chart_StepLine.Series.Add(queues[i].series_Queue);
            }            
            Legend legend = new Legend();
            legend.Docking = Docking.Bottom;
            Chart_StepLine.Legends.Add(legend);

            Chart_gantt.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            //adding queue 2 in secnario_02
            TimedQueue my_Queue_02 = new TimedQueue(null, 0);


            PropertyGrid_ClientGenerator.SelectedObject = my_Model.Client_Generator;
            PropertyGrid_Sever.SelectedObject = servers[0];

            my_Model.Reset_Simulation();
        }

        private void BTN_run_one_Click(object sender, EventArgs e)
        {
            my_Model.Run_One_Event();
            //my_Model_02.Run_One_Event();
            Chart_Pie.Invalidate();

            Refresh_PropertyGrid(PropertyGrid_ClientGenerator);
            Refresh_PropertyGrid(PropertyGrid_Sever);
            Chart_SYN();

            //RTB_Log.Text = current_Model.Get_Description();

        }

        private void BTN_run_all_Click(object sender, EventArgs e)
        {
            if (CB_animate.Checked == true)
            {
                Timer_Animation.Enabled = true;
            }
            else
            {
                my_Model.Run_All_Events();
                Chart_Pie.Invalidate();
                Chart_SYN();

                Refresh_PropertyGrid(PropertyGrid_ClientGenerator);
                Refresh_PropertyGrid(PropertyGrid_Sever);
            }

            //RTB_result.Text+=$"***  Multiple Server-Single Queue   Ending Time: { my_Model.Get_Last_Event_Time()}  ***\n";
            RTB_result.Text = my_Model.Get_Description();           
           
        }

        private void RDB_DifferentServiceRate_CheckedChanged(object sender, EventArgs e)
        {
            if (my_Model == null) return;
            CBX_servers.Enabled = true;
            
            List<Server> list_of_servers = my_Model.Get_All_Servers();
            //CBX_servers.Enabled = false;
            for (int i = 0; i < NumberOfServers; i++)
            {
                CBX_servers.Items.Add(list_of_servers[i].Name);
            }
        }

        private void RDB_SameServiceRate_CheckedChanged(object sender, EventArgs e)
        {
            CBX_servers.Enabled = false;
            
        }

        private void CBX_servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Server> list_of_servers = my_Model.Get_All_Servers();

            PropertyGrid_Sever.SelectedObject = list_of_servers[CBX_servers.SelectedIndex];
        }

        private void Chart_StepLine_AxisViewChanged(object sender, ViewEventArgs e)
        {
            ChartArea ca1 = Chart_StepLine.ChartAreas[0];
            ChartArea ca2 = Chart_gantt.ChartAreas[0];
            Axis ax1 = ca1.AxisX;
            Axis ax2 = ca2.AxisY;
            if (e.Axis == ax1)
            {
                ax2.ScaleView.Size = ax1.ScaleView.Size;
                ax2.ScaleView.Position = ax1.ScaleView.Position;
            }
            if (e.Axis == ax2)
            {
                ax1.ScaleView.Size = ax2.ScaleView.Size;
                ax1.ScaleView.Position = ax2.ScaleView.Position;
            }
        }

        private void Timer_Animation_Tick(object sender, EventArgs e)
        {
            my_Model.Run_One_Event();
            //my_Model_02.Run_One_Event();
            Chart_Pie.Invalidate();

            Refresh_PropertyGrid(PropertyGrid_ClientGenerator);
            Refresh_PropertyGrid(PropertyGrid_Sever);
            Chart_SYN();
        }


        private void TB_Animation_Interval_TextChanged(object sender, EventArgs e)
        {
            Timer_Animation.Interval = Convert.ToInt32(TB_Animation_Interval.Text);
        }

        private void CB_animate_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_animate.Checked == true)
                TB_Animation_Interval.Enabled = true;
            else
            { 
                TB_Animation_Interval.Enabled = false;
                Timer_Animation.Enabled = false;
            }
        }

        private void Chart_StepLine_Click(object sender, EventArgs e)
        {

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                ToolStrip.Enabled = true;
            }
            else
            {
                ToolStrip.Enabled = false;
            }
        }

        public List<SIS_Event> Insert_SIS_Event(SIS_Event e, List<SIS_Event> l)
        {
            //List<double> time_List = new List<double>();

            //for (int i = 0; i < l.Count; i++)
            //{
            //    time_List.Add(l[i].event_Time);
            //}

            l.Add(e);
            int position = 0;
            for (int i = 0; i < l.Count; i++)
            {
                // sort by incoming time
                if (e.event_Time < l[i].event_Time)
                {
                    position = i;

                    l.Insert(i, e);
                    l.RemoveAt(l.Count - 1);
                    break;
                }
            }
            return l;
        }

        private void BTN_simulation_Click(object sender, EventArgs e)
        {
            Chart_SIS.Series.Clear();
            Chart_SIS.Titles.Clear();
            Chart_SIS.Legends.Clear();

            //MainChart.ChartAreas[0].AxisY.Interval = 0;
            Series Series_Min = new Series("Minimum Level");
            Series Series_Max = new Series("Maximum Level");
            Series Series_Inv = new Series("Inventory Level");

            int min_level = Convert.ToInt32(TB_min.Text);
            int max_level = Convert.ToInt32(TB_max.Text);
            double demand_Mean = Convert.ToDouble( TB_demand.Text);
            double arrival_Rate = 1.0 / demand_Mean;

            int Demand = 0;
            //int Total_Demand = 0;
            double max_Period = Convert.ToInt32(TB_max_Period.Text);           

            
            //Lag_Generator = new UniformRVG(0, 1);
         

            double Delivery_Lag = 0;

            Series_Min.Color = Color.Red;
            Series_Min.ChartType = SeriesChartType.StepLine;
            Series_Min.BorderWidth = 2;
            Series_Min.Points.AddXY(0, min_level);
            Series_Min.Points.AddXY(max_Period, min_level);
            Series_Min.BorderDashStyle = ChartDashStyle.Dash;
            //Series Series_JobQueue = new Series("Job Queue");
            Series_Max.Color = Color.Green;
            Series_Max.ChartType = SeriesChartType.StepLine;
            Series_Max.BorderWidth = 2;
            Series_Max.Points.AddXY(0, max_level);
            Series_Max.Points.AddXY(max_Period, max_level);
            Series_Max.BorderDashStyle = ChartDashStyle.Dash;

            //Series Series_JobServer = new Series("Server Status");
            Series_Inv.Color = Color.Blue;
            Series_Inv.ChartType = SeriesChartType.StepLine;
            Series_Inv.BorderWidth = 1;

            Title t = new Title();
            //t.Text = "Job service Chart";
            Legend s = new Legend("Inventory Level");
            s.Docking = Docking.Bottom;
            s.Alignment = StringAlignment.Center;
            Series_Inv.Points.AddXY(0, max_level);

            demand_Event_Generator = new ExponenitalRVG(arrival_Rate, 0, 1);
            delivery_Lag_Generator = new UniformRVG(0, 1);

            //statics
            double total_Demand = 0;
            double total_Order = 0;
            double order_Time = 0;

            List<SIS_Event> future_Event_List = new List<SIS_Event>();
            Demand_Event demand_Event = new Demand_Event(demand_Event_Generator.GenerateARealRandomNumber());
            Supply_Event supply_Event;
            bool supplied = false;
            future_Event_List.Add(demand_Event);
            double current_Inventory_Level = max_level;

            double current_Time = 0;
            double last_Event_Time = 0;

            while (current_Time < max_Period)
            {
                SIS_Event head_Event = future_Event_List[0];
                future_Event_List.RemoveAt(0);
               
                current_Time = head_Event.event_Time;



                //demand occur
                if (head_Event.Get_Type() == "d")
                {
                    total_Demand += 1;

                    current_Inventory_Level -= 1;
                    demand_Event = new Demand_Event(current_Time + demand_Event_Generator.GenerateARealRandomNumber());
                    Insert_SIS_Event(demand_Event, future_Event_List);
                }
                //supply occor
                else
                {
                    current_Inventory_Level += head_Event.Get_Quantities();
                    supplied = false;
                }
                Series_Inv.Points.AddXY(current_Time, current_Inventory_Level);

                //INV below min_level, reorder
                if (current_Inventory_Level<min_level && Math.Floor(last_Event_Time+1)-Math.Floor(current_Time)==0 && supplied == false)
                {
                    order_Time += 1;
                    total_Order += (max_level - current_Inventory_Level);

                    Delivery_Lag = delivery_Lag_Generator.GenerateARealRandomNumber();
                    supply_Event = new Supply_Event(current_Time + Delivery_Lag, max_level - current_Inventory_Level);
                    Insert_SIS_Event(supply_Event, future_Event_List);
                    supplied = true;
                }

                last_Event_Time = current_Time;

            }
            Series_Inv.Points.AddXY(max_Period, max_level);
            Chart_SIS.Series.Clear();
            Chart_SIS.Legends.Add(s);
            Chart_SIS.ChartAreas[0].RecalculateAxesScale();


            //Series_Inv.MarkerStyle = MarkerStyle.Diamond;
            //Series_Inv.MarkerSize = 10;
            Chart_SIS.Series.Add(Series_Min);
            Chart_SIS.Series.Add(Series_Max);
            Chart_SIS.Series.Add(Series_Inv);

            Chart_SIS.ChartAreas[0].CursorX.IsUserEnabled = true;
            Chart_SIS.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            Chart_SIS.ChartAreas[0].AxisX.Maximum = max_Period;

            RTB_SIS_result.Text = $"Average Per Period: Demand = {total_Demand/max_Period}, Order Amount = {total_Order/max_Period}, Order Placed = {order_Time/max_Period}";
        }
    }
}
