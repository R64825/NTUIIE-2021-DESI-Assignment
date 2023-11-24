using My_First_Class_Library;//using 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace r09546042_TerryYang_assignment_02
{
    public delegate int FunTakeOneStringReturnInt(string s);

    public partial class MainForm : Form
    {

        int NumberOfJobs = 0;
        List<double> JobsArrivalTimes;
        List<double> JobsServiceTimespans;
        List<double> JobsCompletionTimes;
        List<double> JobsDelayTimes;
        List<double> JobInterarrivalTimes;

        //double[] TimeEvent;
        ExponenitalRVG Arrival_Generator;
        UniformRVG Service_Generator;
        UniformRVG FeedBack_Generator;

        EquilikelyDRVGenerator Demand_Generator;
        UniformRVG Lag_Generator;


        Series series1, series2, series3;
        public MainForm()
        {
            InitializeComponent();
            //TabControl_Data.TabPages.Remove(TabPage_Stochastic);
          
        }
        double RoundUp(double d, int r)
        {
            return Math.Round(d, r);
        }

        private void CheckBox_JobQueue_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_JobQueue.Checked == true)
                MainChart.Series.Add(series2);
            else
                MainChart.Series.Remove(series2);
        }
        private void CheckBox_ServerStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_ServerStatus.Checked == true)
                MainChart.Series.Add(series3);
            else
                MainChart.Series.Remove(series3);
        }
        private void CheckBox_JocCount_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_JocCount.Checked == true)
                MainChart.Series.Add(series1);
            else
                MainChart.Series.Remove(series1);
        }

        private void Button_SIS_Simulate_Click(object sender, EventArgs e)
        {
            MainChart.Series.Clear();
            MainChart.Titles.Clear();
            MainChart.Legends.Clear();

            //MainChart.ChartAreas[0].AxisY.Interval = 0;
            Series Series_Min = new Series("Minimum Level");
            Series Series_Max = new Series("Maximum Level");
            Series Series_Inv = new Series("Inventory Level");

            int min_level = Convert.ToInt32(TextBox_MinLevel.Text);
            int max_level = Convert.ToInt32(TextBox_MaxLevel.Text);

            int Demand = 0;
            int Total_Demand = 0;
            int NumberOfIntervals = Convert.ToInt32(TextBox_NumberOfIntervals.Text);

            double Cost_setup = Convert.ToDouble(TextBox_SetCost.Text);
            double Cost_holding = Convert.ToDouble(TextBox_HolCost.Text);
            double Cost_shortage = Convert.ToDouble(TextBox_ShoCost.Text);

            int Demand_LBound = Convert.ToInt32(TextBox_Demand_LBound.Text);
            int Demand_UBound = Convert.ToInt32(TextBox_Demand_UBound.Text);
            Demand_Generator = new EquilikelyDRVGenerator(Demand_LBound, Demand_UBound);
            Lag_Generator = new UniformRVG(0, 1);

            if (ToolStripComboBox_Seed.Text == "New Random")
            {
                Demand_Generator.SetSeed(-1);
                Lag_Generator.SetSeed(-1);
            }
            else
            { 
                Demand_Generator.SetSeed(Convert.ToInt32(ToolStripComboBox_Seed.Text));
                Lag_Generator.SetSeed(Convert.ToInt32(ToolStripComboBox_Seed.Text));
            }

            double Delivery_Lag = 0;

            Series_Min.Color = Color.Red;
            Series_Min.ChartType = SeriesChartType.Line;
            Series_Min.BorderWidth = 2;
            Series_Min.Points.AddXY(0, min_level);
            Series_Min.Points.AddXY(NumberOfIntervals, min_level);
            Series_Min.BorderDashStyle = ChartDashStyle.Dash;
            //Series Series_JobQueue = new Series("Job Queue");
            Series_Max.Color = Color.Green;
            Series_Max.ChartType = SeriesChartType.Line;
            Series_Max.BorderWidth = 2;
            Series_Max.Points.AddXY(0, max_level);
            Series_Max.Points.AddXY(NumberOfIntervals, max_level);
            Series_Max.BorderDashStyle = ChartDashStyle.Dash;

            //Series Series_JobServer = new Series("Server Status");
            Series_Inv.Color = Color.Blue;
            Series_Inv.ChartType = SeriesChartType.Line;
            Series_Inv.BorderWidth = 2;

            Title t = new Title();
            //t.Text = "Job service Chart";
            Legend s = new Legend("Inventory Level");
            s.Docking = Docking.Bottom;
            s.Alignment = StringAlignment.Center;
            double order_quantity = 0;
            double inventory_before = max_level;
            double inventory_after = 0;
            double previously_order = 0;
            double order_times = 0;
            double Area_holding = 0;
            double Area_shortage = 0;
            double Area_demand = 0;

            Series_Inv.Points.AddXY(0, max_level);

            if (CheckBox_DeliveryLag.Checked == true)
            {
                for (int i = 0; i < NumberOfIntervals; i++)
                {
                    Demand = Convert.ToInt32(Math.Floor((1 - Delivery_Lag) * Convert.ToDouble(Demand_Generator.GenerateARealRandomNumber())));
                    Area_demand += Demand;
                    inventory_after = inventory_before - Demand;
                    Series_Inv.Points.AddXY(i + 1, inventory_after);
                    order_quantity = 0;
                    Delivery_Lag = 0;
                    //reorder
                    if (inventory_after < min_level || i == NumberOfIntervals - 1)
                    {
                        if (CheckBox_DeliveryLag.Checked == true && i != NumberOfIntervals - 1)
                        {

                            Delivery_Lag = Lag_Generator.GenerateARealRandomNumber();
                            Demand = Convert.ToInt32(Math.Floor(Delivery_Lag * Convert.ToDouble(Demand_Generator.GenerateARealRandomNumber())));
                            Area_demand += Demand;

                            Series_Inv.Points.AddXY(i + 1 + Delivery_Lag, inventory_after - Demand);
                            Series_Inv.Points.AddXY(i + 1 + Delivery_Lag, max_level - Demand);

                            inventory_after = max_level - Demand;
                        }
                        else
                        {
                            order_quantity = max_level - inventory_after;
                            Area_demand += order_quantity;
                            Series_Inv.Points.AddXY(i + 1, max_level);
                        }
                        order_times++;
                    }

                    //area cal
                    if (inventory_after < 0)
                    {
                        Area_holding += inventory_before/*height*/ * (inventory_before / (Demand))/*bottom*/* (0.5);
                        //holding <== holding + (Qi + Inv) * (Qi + Inv / Qi) * (1 / 2)
                        Area_shortage += (-inventory_after)/*height*/ * ((-inventory_after) / (Demand))/*bottom*/ * (0.5);
                        //shortage <== shortage + (-Inv *) * (-Inv / Qi) * (1 / 2)
                    }
                    else
                    {
                        Area_holding += inventory_before - (Demand / 2.0);
                    }
                    inventory_before = inventory_after + order_quantity;
                }
            }
            else
            {
                for (int i = 0; i < NumberOfIntervals; i++)
                {
                    Demand = Convert.ToInt32(Demand_Generator.GenerateARealRandomNumber());
                    Area_demand += Demand;
                    inventory_after = inventory_before - Demand;
                    Series_Inv.Points.AddXY(i + 1, inventory_after);
                    order_quantity = 0;
                    Delivery_Lag = 0;
                    //reorder
                    if (inventory_after < min_level || i == NumberOfIntervals - 1)
                    {
                        order_quantity = max_level - inventory_after;
                        Area_demand += order_quantity;
                        Series_Inv.Points.AddXY(i + 1, max_level);
                        order_times++;
                    }

                    //area cal
                    if (inventory_after < 0)
                    {
                        Area_holding += inventory_before/*height*/ * (inventory_before / (Demand))/*bottom*/* (0.5);
                        //holding <== holding + (Qi + Inv) * (Qi + Inv / Qi) * (1 / 2)
                        Area_shortage += (-inventory_after)/*height*/ * ((-inventory_after) / (Demand))/*bottom*/ * (0.5);
                        //shortage <== shortage + (-Inv *) * (-Inv / Qi) * (1 / 2)
                    }
                    else
                    {
                        Area_holding += inventory_before - (Demand / 2.0);
                    }
                    inventory_before = inventory_after + order_quantity;
                }
            }


           

            
            MainChart.Series.Clear();
            MainChart.Legends.Add(s);
            MainChart.ChartAreas[0].RecalculateAxesScale();


            Series_Inv.MarkerStyle = MarkerStyle.Diamond;
            Series_Inv.MarkerSize = 10;
            MainChart.Series.Add(Series_Min);
            MainChart.Series.Add(Series_Max);
            MainChart.Series.Add(Series_Inv);


            MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].AxisX.Maximum = NumberOfIntervals;


            RichTextBox_result.Text += "\n\n";
            RichTextBox_result.Text += string.Format("*** Stochastic Simulation on SIS without delivery lag for {0} intervals ***\n", NumberOfIntervals);

            RichTextBox_result.Text += string.Format("Average Demand: {0} per period\n", RoundUp(Total_Demand / NumberOfIntervals, 3));
            RichTextBox_result.Text += string.Format("Average Order: ({0}/{1}) = {2} per period\n", order_times, NumberOfIntervals, RoundUp(order_times / NumberOfIntervals, 4));
            RichTextBox_result.Text += string.Format("Time-Average Holding Level: {0}\n", RoundUp((Area_holding / NumberOfIntervals), 4));
            RichTextBox_result.Text += string.Format("Time-Average Shortage Level:  {0}\n", RoundUp((Area_shortage / NumberOfIntervals), 4));
            RichTextBox_result.Text += string.Format("Dependent Cost: {0}\n",RoundUp(
                (Cost_setup * RoundUp(order_times / NumberOfIntervals, 4)
                + Cost_holding * RoundUp(Area_holding / NumberOfIntervals, 4)
                + Cost_shortage * RoundUp(Area_shortage / NumberOfIntervals, 4)), 2));


            CheckBox_JobQueue.Enabled = false;
            CheckBox_JocCount.Enabled = false;
            CheckBox_ServerStatus.Enabled = false;
        }

        private void Buttom_Simulate_Stochastic_Click(object sender, EventArgs e)
        {
            MainChart.Series.Clear();
            MainChart.Titles.Clear();
            MainChart.Legends.Clear();

            Series Series_JobCounts = new Series("Job Count");
            Series Series_JobQueue = new Series("Job Queue");
            Series Series_JobServer = new Series("Server Status");

            Series_JobCounts.Color = Color.Red;
            Series_JobCounts.ChartType = SeriesChartType.StepLine;
            Series_JobCounts.BorderWidth = 2;

            Series_JobQueue.Color = Color.Green;
            Series_JobQueue.ChartType = SeriesChartType.StepLine;
            Series_JobQueue.BorderWidth = 2;

            Series_JobServer.Color = Color.Blue;
            Series_JobServer.ChartType = SeriesChartType.StepLine;
            Series_JobServer.BorderWidth = 2;

            Title t = new Title();
            t.Text = "Job service Chart";
            Legend s = new Legend("Job Count");
            s.Docking = Docking.Bottom;
            s.Alignment = StringAlignment.Center;

            NumberOfJobs = Convert.ToInt32(TextBox_NumberOfJobs.Text);
            JobsArrivalTimes = new List<double>();
            JobsCompletionTimes = new List<double>();
            JobsDelayTimes = new List<double>();
            JobInterarrivalTimes = new List<double>();
            JobsServiceTimespans = new List<double>();
            double FeedBack_Ratio = Convert.ToDouble(TextBox_feedback_ratio.Text);

            Arrival_Generator = new ExponenitalRVG(Convert.ToDouble(TextBox_Average_InterarrivalTime.Text));
            Service_Generator = new UniformRVG(Convert.ToDouble(TextBox_LowerBound.Text), Convert.ToDouble(TextBox_UpperBound.Text));
            FeedBack_Generator = new UniformRVG(0, 1);

            if (ToolStripComboBox_Seed.Text == "New Random")
            {
                Arrival_Generator.SetSeed(-1);
                Service_Generator.SetSeed(-1);
                FeedBack_Generator.SetSeed(-1);
            }
            else
            {
                Arrival_Generator.SetSeed(Convert.ToInt32(ToolStripComboBox_Seed.Text));
                Service_Generator.SetSeed(Convert.ToInt32(ToolStripComboBox_Seed.Text));
                FeedBack_Generator.SetSeed(Convert.ToInt32(ToolStripComboBox_Seed.Text));
            }



            //DynamicStochasticSSQSimulation 
            //setting variable
            double Time_arrival = Arrival_Generator.GenerateARealRandomNumber();
            double Time_complete = int.MaxValue;
            double Lapse = 0;
            double Last_event = 0;

            double Area_JobCount = 0;
            double Area_JobQueue = 0;
            double Area_JobServer = 0;
            double Length_JobService = 0;
            double Length_JobInterArrival = 0;

            int current_job = 0;
            int Job_in_nodes = 0;
            int Job_in_queue = 0;
            int Job_in_server = 0;

            double feed_back = 0;
            Random rnd = new Random();

            Series_JobCounts.Points.AddXY(0, 0);
            Series_JobQueue.Points.AddXY(0, 0);
            Series_JobServer.Points.AddXY(0, 0);


            while (Time_arrival != int.MaxValue || Time_complete != int.MaxValue)
            {   //arrival event
                if (Time_arrival<=Time_complete)
                {
                    Lapse = Time_arrival - Last_event;

                    Area_JobCount += Job_in_nodes * Lapse;
                    Area_JobQueue += Job_in_queue * Lapse;
                    Area_JobServer += Job_in_server * Lapse;

                    Series_JobCounts.Points.AddXY(Time_arrival, ++Job_in_nodes);

                    //server busy
                    if (Job_in_server == 1)
                        Series_JobQueue.Points.AddXY(Time_arrival, ++Job_in_queue);
                    //server free
                    else
                    {
                        Lapse = Service_Generator.GenerateARealRandomNumber();
                        Length_JobService += Lapse;
                        Time_complete = Time_arrival + Lapse;

                        Series_JobServer.Points.AddXY(Time_arrival, ++Job_in_server);

                        
                    }
                    Last_event = Time_arrival;

                    
                    //continue generate arrival event?
                    if (++current_job != NumberOfJobs)
                    {
                        Lapse = Arrival_Generator.GenerateARealRandomNumber();
                        Time_arrival = Time_arrival + Lapse;
                        Length_JobInterArrival += Lapse;
                    }
                    //all arrival fulfill
                    else
                        Time_arrival = int.MaxValue;
                }
                //complete event
                else
                {
                    Lapse = Time_complete - Last_event;
                    Area_JobCount += Job_in_nodes * Lapse;
                    Area_JobQueue += Job_in_queue * Lapse;
                    Area_JobServer += Job_in_server * Lapse;

                    Series_JobCounts.Points.AddXY(Time_complete, --Job_in_nodes);
                    Series_JobServer.Points.AddXY(Time_complete, --Job_in_server);

                    Last_event = Time_complete;

                    //have job in queue
                    if (Job_in_queue > 0)
                    {
                        //feed Back
                        if (FeedBack_Generator.GenerateARealRandomNumber() < FeedBack_Ratio)
                        {
                            Series_JobQueue.Points.AddXY(Time_complete, ++Job_in_queue);
                            Series_JobCounts.Points.AddXY(Time_complete, ++Job_in_nodes);
                            feed_back++;
                        }

                        Series_JobQueue.Points.AddXY(Time_complete, --Job_in_queue);
                        Series_JobServer.Points.AddXY(Time_complete, ++Job_in_server);

                        Lapse = Service_Generator.GenerateARealRandomNumber();
                        Length_JobService += Lapse;
                        Time_complete = Time_complete + Lapse;
                    }
                    //no job in queue
                    else
                        Time_complete = int.MaxValue;               
                }
            }

            RichTextBox_result.Text += "\n\n";
            RichTextBox_result.Text += string.Format("*** SSQ with feedback simulation results with feedback rate: {0} ***\n", Convert.ToDouble(TextBox_feedback_ratio.Text))  ; 

            RichTextBox_result.Text += string.Format("Average Interarrival Time: {0}, Arrival Rate: {1}\n", RoundUp(Length_JobInterArrival / NumberOfJobs, 3), RoundUp(1 / RoundUp(Length_JobInterArrival / NumberOfJobs, 3), 4));
            RichTextBox_result.Text += string.Format("Average Wait Time: {0}\n", RoundUp((Area_JobCount / NumberOfJobs), 3));
            RichTextBox_result.Text += string.Format("Average Delay Time: {0}\n", RoundUp(Area_JobQueue / NumberOfJobs, 3));
            RichTextBox_result.Text += string.Format("Average Service Time: {0}, Service Rate: {1}\n", (RoundUp((Length_JobService / NumberOfJobs), 3)), RoundUp(1 / (Area_JobServer / NumberOfJobs), 4));
;
            RichTextBox_result.Text += string.Format("Time_Averaged Job in Nodes: {0}\n", RoundUp((Area_JobCount / Last_event), 2));
            RichTextBox_result.Text += string.Format("Time_Averaged Job in Queue: {0}\n", RoundUp((Area_JobQueue / Last_event), 2));
            RichTextBox_result.Text += string.Format("Time_Averaged Job in Server: {0}\n", RoundUp((Area_JobServer / Last_event), 2));

            RichTextBox_result.Text += string.Format("Feedback ratio: {0}/{1} = {2} \n", feed_back,NumberOfJobs, RoundUp((feed_back / NumberOfJobs), 2));

            series1 = Series_JobCounts;
            series2 = Series_JobQueue;
            series3 = Series_JobServer;
            MainChart.Series.Clear();
            if (CheckBox_JocCount.Checked == true)
                MainChart.Series.Add(Series_JobCounts);
            if (CheckBox_JobQueue.Checked == true)
                MainChart.Series.Add(Series_JobQueue);
            if (CheckBox_ServerStatus.Checked == true)
                MainChart.Series.Add(Series_JobServer);

            MainChart.Legends.Add(s);
            MainChart.ChartAreas[0].RecalculateAxesScale();

            MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].AxisX.ScrollBar.Size = 20;
            MainChart.ChartAreas[0].AxisX.Maximum = Last_event+10;


            CheckBox_JobQueue.Enabled = true;
            CheckBox_JocCount.Enabled = true;
            CheckBox_ServerStatus.Enabled = true;
        }

        private void RichTextBox_result_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            RichTextBox_result.SelectionStart = RichTextBox_result.Text.Length;
            // scroll it automatically
            RichTextBox_result.ScrollToCaret();
            
        }


    }
}
