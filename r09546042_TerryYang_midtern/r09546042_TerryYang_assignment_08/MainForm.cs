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

namespace r09546042_TerryYang_assignment_08
{
    public partial class MainForm : Form
    {
        Discrete_Event_Simulation_Model current_Model;
        //Discrete_Event_Simulation_Model my_Model_02;
        TimedQueue my_Queue = null;
        string scenario = "scenario_01";
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTN_Creat_SSQ_Model_Click(object sender, EventArgs e)
        {
            //current_Model.Reset_Simulation();

            Pie_Chart_01.Titles.Clear();
            Pie_Chart_02.Titles.Clear();
            Pie_Chart_03.Titles.Clear();

            Gantt_Chart_01.Series.Clear();
            Pie_Chart_01.Series.Clear();
            Pie_Chart_02.Series.Clear();
            Pie_Chart_03.Series.Clear();
            //RTB_Process.Text = "";

            // create SSQ model
            current_Model = Discrete_Event_Simulation_Model.Creat_A_SSQ_Model(scenario);
            //my_Model_02 = Discrete_Event_Simulation_Model.Creat_A_SSQ_Model();
            PropertyGrid.SelectedObject = current_Model.Client_Generator;
            BTN_Reset.Enabled = true;

            // create Gantt chart
            List <Server> servers = current_Model.Get_All_Servers();
            TimedQueue my_Queue_01 = current_Model.Get_All_Queue()[0];
            

            // adding gannt series
            for (int i = 0; i < servers.Count; i++)
            {
                Series s = new Series();
                s = servers[i].gantt_States;
                s.ChartArea = "ChartArea1";
                Gantt_Chart_01.Series.Add(s);
            }
            // adding pie seies
            Pie_Chart_01.Series.Add(servers[0].pie_States);
            Title title_01 = new Title(); title_01.Text = "Server_0" + servers[0].index;
            Pie_Chart_01.Titles.Add(title_01);

            Pie_Chart_02.Series.Add(servers[1].pie_States);
            Title title_02 = new Title();  title_02.Text = "Server_0" + servers[1].index;
            Pie_Chart_02.Titles.Add(title_02);

            if (scenario == "scenario_01")
            {
                Pie_Chart_03.Series.Add(servers[2].pie_States);
                Title title_03 = new Title(); title_03.Text = "Server_0" + servers[2].index;
                Pie_Chart_03.Titles.Add(title_03);
            }

            // adding step line
            Gantt_Chart_01.Series.Add(current_Model.Simulation_Engine.Get_Step_Line());
            Gantt_Chart_01.Series.Add(my_Queue_01.series_Queue);


            //adding queue 2 in secnario_02
            TimedQueue my_Queue_02 = new TimedQueue(null, 0);
            if (scenario == "scenario_02")
            {
                my_Queue_02 = current_Model.Get_All_Queue()[1];
                my_Queue_02.series_Queue.Color = Color.Lime;
                Gantt_Chart_01.Series.Add(my_Queue_02.series_Queue);
            }

        }

        public void Chart_SYN()
        {
            //Scyn two charts
            ChartArea ca1 = Gantt_Chart_01.ChartAreas[0];
            ChartArea ca2 = Gantt_Chart_01.ChartAreas[1];
            Axis ax1 = ca1.AxisY;
            Axis ax2 = ca2.AxisX;
            ax1.ScaleView.Zoomable = true;
            ax2.ScaleView.Zoomable = true;

            ca1.CursorY.IsUserSelectionEnabled = true;
            ca2.CursorX.IsUserSelectionEnabled = true;
        }
        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            //Gantt_Chart.Series.Clear();
            //Pie_Chart.Series.Clear();
            current_Model.Reset_Simulation();
            //my_Model_02.Reset_Simulation();
            BTN_Run_One.Enabled = true;
            BTN_Run_End.Enabled = true;


        }

       
        private void BTN_Run_One_Click(object sender, EventArgs e)
        {
            //RTB_Process.AppendText(my_Model_01.Simulation_Engine.Get_Description());
            //RTB_Process.AppendText($"\n");
            current_Model.Run_One_Event();
            //my_Model_02.Run_One_Event();
            Pie_Chart_01.Invalidate();
            Pie_Chart_02.Invalidate();
            Pie_Chart_03.Invalidate();
            Chart_SYN();

            RTB_Log.Text = current_Model.Get_Description();
        }

        private void BTN_Run_End_Click(object sender, EventArgs e)
        {
            current_Model.Run_All_Events();
            Pie_Chart_01.Invalidate();
            Pie_Chart_02.Invalidate();
            Pie_Chart_03.Invalidate();
            Chart_SYN();

            RTB_Log.Text = current_Model.Get_Description();
            RTB_Log.Text += "\nDiscussion ==> ";
            if (scenario == "scenario_01")
            {
                RTB_Log.Text += "\n     First Server is busier than the other servers, since we search the free server from the server_01. Maybe we can generate a strategy in finding free server to shorter the makespan(ex. faster server always get pick when idle)";
            }
            else
            {
                RTB_Log.Text+= "\n      Faster server ended earlier. Since clients queued in a shorter queue, which makes two queues length are almost equal, slower server needs more time to complete its queue. If we makes two server sharing a same queue, we may reduce the makespan";
            }
        }

        private void RBTN_Client_CheckedChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObject = current_Model.Client_Generator;
        }

        private void RBTN_Server_CheckedChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObject = current_Model.Get_All_Servers()[0];
        }

        private void RBTN_Queue_CheckedChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObject = current_Model.Get_All_Queue()[0];
        }

        private void Gantt_Chart_AxisViewChanged(object sender, ViewEventArgs e)
        {
            ChartArea ca1 = Gantt_Chart_01.ChartAreas[0];
            ChartArea ca2 = Gantt_Chart_01.ChartAreas[1];
            Axis ax1 = ca1.AxisY;
            Axis ax2 = ca2.AxisX;
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

        private void RBTN_Server_02_CheckedChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObject = current_Model.Get_All_Servers()[1];
        }

        private void RBTN_Server_03_CheckedChanged(object sender, EventArgs e)
        {
            if (current_Model.Get_All_Servers().Count > 2)
            {
                PropertyGrid.SelectedObject = current_Model.Get_All_Servers()[2];
            }           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RBTN_Server_03.Enabled = false;
            Pie_Chart_03.Enabled = false;
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = false;
            RBTN_Queue_02.Enabled = true;
            scenario = "scenario_02";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RBTN_Server_03.Enabled = true;
            Pie_Chart_03.Enabled = true;
            toolStripButton2.Enabled = true;
            toolStripButton1.Enabled = false;
            RBTN_Queue_02.Enabled = false;
            scenario = "scenario_01";
        }

        private void RBTN_Queue_02_CheckedChanged(object sender, EventArgs e)
        {
            if (current_Model.Get_All_Queue().Count > 1)
            { 
                PropertyGrid.SelectedObject = current_Model.Get_All_Queue()[1];
            } 
        }
    }
}
