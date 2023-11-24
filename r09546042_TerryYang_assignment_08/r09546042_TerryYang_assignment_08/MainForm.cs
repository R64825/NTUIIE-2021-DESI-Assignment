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
        Discrete_Event_Simulation_Model my_Model;
        TimedQueue my_Queue = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTN_Creat_SSQ_Model_Click(object sender, EventArgs e)
        {
            Gantt_Chart.Series.Clear();
            Pie_Chart.Series.Clear();
            RTB_Process.Text = "";

            // create SSQ model
            my_Model = Discrete_Event_Simulation_Model.Creat_A_SSQ_Model();
            PropertyGrid.SelectedObject = my_Model.Client_Generator;
            BTN_Reset.Enabled = true;

            // create Gantt chart
            Server server = my_Model.Get_All_Servers()[0];
            TimedQueue my_Queue = my_Model.Get_All_Queue()[0];
            //server.Gantt_States.ChartArea = "ChartArea1";
            //Gantt_Chart.Series.Add(server.Gantt_States);
            my_Model.Simulation_Engine.Get_Gantt().ChartArea = "ChartArea1";
            Gantt_Chart.Series.Add(my_Model.Simulation_Engine.Get_Gantt());



            // create Pie chart
            Pie_Chart.Series.Add(my_Model.Simulation_Engine.Get_Pie());


            // create StepLine chart
            //my_Queue.Series_Clients.ChartArea = "ChartArea2";
            //my_Queue.Series_Clients.Color = Color.Red;
            //my_Queue.Series_Clients.BorderWidth = 2;
            //Gantt_Chart.Series.Add(my_Queue.Series_Clients);
            //my_Model.Simulation_Engine.Get_Step_Line().ChartArea = "ChartArea2";
            Gantt_Chart.Series.Add(my_Model.Simulation_Engine.Get_Step_Line());

            
        }

        public void Chart_SYN()
        {
            //Scyn two charts
            ChartArea ca1 = Gantt_Chart.ChartAreas[0];
            ChartArea ca2 = Gantt_Chart.ChartAreas[1];
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
            my_Model.Reset_Simulation();
            BTN_Run_One.Enabled = true;
            BTN_Run_End.Enabled = true;


        }

       
        private void BTN_Run_One_Click(object sender, EventArgs e)
        {
            RTB_Process.AppendText(my_Model.Simulation_Engine.Get_Description());
            RTB_Process.AppendText($"\n");
            my_Model.Run_One_Event();
            Pie_Chart.Invalidate();

            Chart_SYN();
        }

        private void BTN_Run_End_Click(object sender, EventArgs e)
        {
            my_Model.Run_All_Events();
            Pie_Chart.Invalidate();
            Chart_SYN();
        }

        private void RBTN_Client_CheckedChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObject = my_Model.Client_Generator;
        }

        private void RBTN_Server_CheckedChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObject = my_Model.Get_All_Servers()[0];
        }

        private void RBTN_Queue_CheckedChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObject = my_Model.Get_All_Queue()[0];
        }

        private void Gantt_Chart_AxisViewChanged(object sender, ViewEventArgs e)
        {
            ChartArea ca1 = Gantt_Chart.ChartAreas[0];
            ChartArea ca2 = Gantt_Chart.ChartAreas[1];
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
    }
}
