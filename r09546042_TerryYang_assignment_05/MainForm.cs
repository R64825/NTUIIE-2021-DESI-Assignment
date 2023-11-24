using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using My_First_Class_Library;//using 

namespace r09546042_TerryYang_assignment_02
{
    public delegate int FunTakeOneStringReturnInt(string s);

    public partial class MainForm : Form
    {
        double[] NewArrivalData;
        double[] NewServiceData;
        double AIT;
        double AITD;
        double AST;
        double ASTD;
        int NOJ;

        int NumberOfJobs = 0;
        double[] JobsArrivalTimes;
        double[] JobsServiceTimespans;
        double[] JobsCompletionTimes;
        double[] JobsDelayTimes;
        double[] JobInterarrivalTimes;

        //double[] TimeEvent;
        ExponenitalRVG Arrival_Generator;
        UniformRVG Service_Generator;

        int Sim_index = 0;
        //int Number_of_steady_Test = 0;


        Series series1, series2, series3;
        public MainForm()
        {
            InitializeComponent();
            TabControl_Data.TabPages.Remove(TabPage_Stochastic);
            TabControl_Chart.TabPages.Remove(TabPage_SteadyTest);
          
        }
        double RoundUp(double d, int r)
        {
            return Math.Round(d, r);
        }
        double[] SortFormSmallToLarge(double[] a)//bubble sort
        {
            double tmp=0;
            for (int i = 0; i < NumberOfJobs; i++)
            {
                for (int j = 0; j < NumberOfJobs-1; j++)
                            {
                                    if (a[j]>a[j+1])
                                    {
                                        tmp = a[j];
                                        a[j] = a[j + 1];
                                        a[j + 1] = tmp;                 
                                    }
                            }
            }
          return a;
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

        private void BTN_simulate_Click(object sender, EventArgs e)
        {
            Chart_simulation.Series.Clear();
            Chart_simulation.Titles.Clear();
            int NumberOfTest = Convert.ToInt32(TB_TestNumber.Text);
            double FactorFrom = Convert.ToDouble(TB_factor1.Text);
            double FactorTo = Convert.ToDouble(TB_factor2.Text);
            double Length = FactorTo - FactorFrom;
            double [] FactorsArray;
            double timeindex=0;
            FactorsArray = new double[NumberOfTest];
            for (int i = 0; i < NumberOfTest; i++)
            {
                FactorsArray[i] = RoundUp( FactorFrom + i * (Length / (NumberOfTest - 1)),2);
            }

            Series Series_simulation = new Series("simulation");           
            Series_simulation.Color = Color.Red;
            Series_simulation.ChartType = SeriesChartType.Line;
            Series_simulation.BorderWidth = 2;
            Series_simulation.IsValueShownAsLabel = true;
            Series_simulation.MarkerSize = 10;
            Series_simulation.MarkerStyle = MarkerStyle.Circle;

            Title t = new Title();
            t.Text = "Queue_Utilization of Different Service Rates";         

            for (int i = 0; i < NumberOfTest; i++)
            {
                for (int f = 0; f < NumberOfJobs; f++)
                {
                    if (f != 0)
                    {
                        if (JobsArrivalTimes[f] <= JobsCompletionTimes[f - 1])//delay
                        {
                            JobsDelayTimes[f] = RoundUp(JobsCompletionTimes[f - 1] - JobsArrivalTimes[f], 3);
                        }
                        else
                        { JobsDelayTimes[f] = 0; }
                        JobInterarrivalTimes[f] = JobsArrivalTimes[f] - JobsArrivalTimes[f - 1];
                    }
                    else
                    {
                        JobsDelayTimes[f] = 0;
                        JobInterarrivalTimes[f] = JobsArrivalTimes[f];
                    }
                    JobsCompletionTimes[f] = RoundUp((JobsArrivalTimes[f] + JobsDelayTimes[f] + JobsServiceTimespans[f] * FactorsArray[i]), 3);
                    //dataGridView1.Rows.Add(f, JobsArrivalTimes[f], JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text), JobsDelayTimes[f], JobsCompletionTimes[f]);
                }
                timeindex = JobsCompletionTimes[NumberOfJobs-1];
                DataPoint D = new DataPoint();
                D.SetValueXY(RoundUp(FactorsArray[i] * JobsServiceTimespans.Sum() / timeindex, 2), RoundUp(JobsDelayTimes.Sum() / timeindex, 2));
                D.Label = FactorsArray[i].ToString();
                Series_simulation.Points.Add(D);
            }


            ////sorting
            //JobsCompletionTimes = SortFormSmallToLarge(JobsCompletionTimes);
            //JobsArrivalTimes = SortFormSmallToLarge(JobsArrivalTimes);
            Chart_simulation.Series.Add(Series_simulation);
            Chart_simulation.Titles.Add(t);
            Chart_simulation.ChartAreas[0].RecalculateAxesScale();
        }
        
        private void TOS_BTN_open_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainChart.Series.Clear();
                MainChart.Legends.Clear();
                MainChart.Titles.Clear();
                dataGridView1.Rows.Clear();
                //richTextBox1.Text = "";
                BTN_ResetPlot.Enabled = false;

                BTN_ShowPlot.Enabled = true;
                StreamReader sr = new StreamReader(OpenFileDialog.FileName);
                NumberOfJobs = Convert.ToInt32(sr.ReadLine());
                JobsArrivalTimes = new double[NumberOfJobs];
                JobsServiceTimespans = new double[NumberOfJobs];
                JobsCompletionTimes = new double[NumberOfJobs];
                JobsDelayTimes = new double[NumberOfJobs];
                JobsDelayTimes = new double[NumberOfJobs];
                JobInterarrivalTimes = new double[NumberOfJobs];
                //TimeEvent = new double[2 * NumberOfJobs];
                string[] tmp;
                char[] seps = { ' ', ',', '@' };//分割子
                for (int i = 0; i < NumberOfJobs; i++)
                {
                    tmp = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    JobsArrivalTimes[i] = Convert.ToDouble(tmp[0]);
                    JobsServiceTimespans[i] = Convert.ToDouble(tmp[1]);
                }
                sr.Close();

                //richTextBox1.Text += "Number of jobs:" + NumberOfJobs + "\n";
                for (int i = 0; i < NumberOfJobs; i++)
                {
                    dataGridView1.Rows.Add(i, JobsArrivalTimes[i], JobsServiceTimespans[i]);
                }

                BTN_simulate.Enabled = true;
            }
        }

        private void BTN_ShowPlot_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // Series Series_JobCounts = new Series("Job Count");

            Series Series_JobCounts = new Series("Job Count");
            Series Series_JobQueue = new Series("Job Queue");
            Series Series_JobServer = new Series("Server Status");

            Series_JobCounts.Color = Color.Red;
            Series_JobCounts.ChartType = SeriesChartType.StepLine;
            Series_JobCounts.BorderWidth = 2;

            //Series Series_JobQueue = new Series("Job Queue");
            Series_JobQueue.Color = Color.Green;
            Series_JobQueue.ChartType = SeriesChartType.StepLine;
            Series_JobQueue.BorderWidth = 2;

            //Series Series_JobServer = new Series("Server Status");
            Series_JobServer.Color = Color.Blue;
            Series_JobServer.ChartType = SeriesChartType.StepLine;
            Series_JobServer.BorderWidth = 2;

            Title t = new Title();
            t.Text = "Job service Chart";
            Legend s = new Legend("Job Count");
            s.Docking = Docking.Bottom;
            s.Alignment = StringAlignment.Center;

            for (int f = 0; f < NumberOfJobs; f++)
            {
                if (f != 0)
                {
                    if (JobsArrivalTimes[f] <= JobsCompletionTimes[f - 1])//delay
                    {
                        JobsDelayTimes[f] = RoundUp(JobsCompletionTimes[f - 1] - JobsArrivalTimes[f], 3);
                    }
                    else
                    { JobsDelayTimes[f] = 0; }
                    JobInterarrivalTimes[f] = JobsArrivalTimes[f] - JobsArrivalTimes[f - 1];
                }
                else
                {
                    JobsDelayTimes[f] = 0;
                    JobInterarrivalTimes[f] = JobsArrivalTimes[f];
                }
                JobsCompletionTimes[f] = RoundUp((JobsArrivalTimes[f] + JobsDelayTimes[f] + JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text)), 3);

                dataGridView1.Rows.Add(f, JobsArrivalTimes[f], JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text), JobsDelayTimes[f], JobsCompletionTimes[f]);
            }
            //sorting

            JobsCompletionTimes = SortFormSmallToLarge(JobsCompletionTimes);
            JobsArrivalTimes = SortFormSmallToLarge(JobsArrivalTimes);


            int ArriveSeq = 0;
            int LeaveSeq = 0;
            int JobCount = 0;
            int ServerStatus = 0;
            int JobQueue = 0;
            double LastEventTime = 0;
            double Area_JobCount = 0;
            double Area_JobQueue = 0;
            double Area_ServerStatus = 0;

            Series_JobCounts.Points.AddXY(0, 0);
            Series_JobCounts.Points.AddXY(JobsArrivalTimes[0], 0);

            Series_JobQueue.Points.AddXY(0, 0);
            Series_JobQueue.Points.AddXY(JobsArrivalTimes[0], 0);

            Series_JobServer.Points.AddXY(0, 0);
            Series_JobServer.Points.AddXY(JobsArrivalTimes[0], 0);
            //Neat
            do
            {
                // Leave Event
                if (ArriveSeq >= NumberOfJobs || JobsCompletionTimes[LeaveSeq] < JobsArrivalTimes[ArriveSeq])
                {
                    LastEventTime = (JobsCompletionTimes[LeaveSeq] - LastEventTime);
                    Area_JobCount += JobCount * (LastEventTime);
                    Area_JobQueue += JobQueue * (LastEventTime);
                    Area_ServerStatus += ServerStatus * (LastEventTime);
                    JobCount = JobCount - 1;
                    Series_JobCounts.Points.AddXY(JobsCompletionTimes[LeaveSeq], JobCount);
                    ServerStatus = ServerStatus - 1;// Server idle
                    Series_JobServer.Points.AddXY(JobsCompletionTimes[LeaveSeq], ServerStatus);
                    if (JobQueue > 0)// Queue Job enter Server
                    {
                        JobQueue = JobQueue - 1;
                        ServerStatus = ServerStatus + 1;
                        Series_JobQueue.Points.AddXY(JobsCompletionTimes[LeaveSeq], JobQueue);
                        Series_JobServer.Points.AddXY(JobsCompletionTimes[LeaveSeq], ServerStatus);
                    }
                    LastEventTime = JobsCompletionTimes[LeaveSeq];
                    LeaveSeq++;
                }
                // Arrival Event
                else
                {
                    LastEventTime = (JobsArrivalTimes[ArriveSeq] - LastEventTime);
                    Area_JobCount += JobCount * (LastEventTime);
                    Area_JobQueue += JobQueue * (LastEventTime);
                    Area_ServerStatus += ServerStatus * (LastEventTime);
                    JobCount = JobCount + 1;
                    Series_JobCounts.Points.AddXY(JobsArrivalTimes[ArriveSeq], JobCount);
                    if (ServerStatus > 0)// Server Busy
                    {
                        JobQueue = JobQueue + 1;
                        Series_JobQueue.Points.AddXY(JobsArrivalTimes[ArriveSeq], JobQueue);
                    }
                    else// Server idle
                    {
                        ServerStatus = ServerStatus + 1;
                        Series_JobServer.Points.AddXY(JobsArrivalTimes[ArriveSeq], ServerStatus);
                    }
                    LastEventTime = JobsArrivalTimes[ArriveSeq];
                    ArriveSeq++;
                }
               
            } while (LeaveSeq != NumberOfJobs);
            LB_AvgIntTime.Text = "Average Interarrival Time: " + Convert.ToString(RoundUp(JobInterarrivalTimes.Average(), 3)) + ", Arrival Rate: " + Convert.ToString(RoundUp(1 / JobInterarrivalTimes.Average(), 4));
            LB_WatTime.Text = "Average Wait Time: " + Convert.ToString(RoundUp((Area_JobCount / NumberOfJobs), 3));
            LB_AvgDlyTime.Text = "Average Delay Time: " + Convert.ToString(RoundUp(Area_JobQueue / NumberOfJobs, 3));
            LB_AvgSerTime.Text = "Average Service Time: " + Convert.ToString(RoundUp((Area_ServerStatus / NumberOfJobs), 3)) + ", Service Rate: " + Convert.ToString(RoundUp(1 / (Area_ServerStatus / NumberOfJobs), 4));

            double timeindex = JobsCompletionTimes[NumberOfJobs - 1];
            LB_AJN.Text = "Time_Averaged Job in Nodes: " + Convert.ToString(RoundUp(((JobsServiceTimespans.Sum() + JobsDelayTimes.Sum()) / timeindex), 2));
            LB_AJQ.Text = "Time_Averaged Job in Queue: " + Convert.ToString(RoundUp((JobsDelayTimes.Sum() / timeindex), 2));
            LB_AJS.Text = "Time_Averaged Job in Server: " + Convert.ToString(RoundUp((JobsServiceTimespans.Sum() / timeindex), 2));


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
            BTN_ResetPlot.Enabled = true;
            BTN_ShowPlot.Enabled = false;

            MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].AxisX.ScrollBar.Size = 20;
        }

        private void Buttom_Simulate_Stochastic_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
            JobsArrivalTimes = new double[NumberOfJobs];
            JobsCompletionTimes = new double[NumberOfJobs];
            JobsDelayTimes = new double[NumberOfJobs];
            JobInterarrivalTimes = new double[NumberOfJobs];
            JobsServiceTimespans = new double[NumberOfJobs];


            Arrival_Generator = new ExponenitalRVG(Convert.ToDouble(TextBox_Average_InterarrivalTime.Text));
            Service_Generator = new UniformRVG(Convert.ToDouble(TextBox_LowerBound.Text), Convert.ToDouble(TextBox_UpperBound.Text));

            if (ComboBox_Seed.Text == "New Random")
            {
                Arrival_Generator.SetSeed(-1);
                Service_Generator.SetSeed(-1);
            }
            else
            {
                Arrival_Generator.SetSeed(Convert.ToInt32(ComboBox_Seed.Text));
                Service_Generator.SetSeed(Convert.ToInt32(ComboBox_Seed.Text));
            }

            for (int i = 0; i < NumberOfJobs; i++)
            {
                //using RVG generate interarrival_times & Service_times
                JobInterarrivalTimes[i] = Arrival_Generator.GenerateARealRandomNumber();
                JobsServiceTimespans[i] = Service_Generator.GenerateARealRandomNumber();
            }

            for (int f = 0; f < NumberOfJobs; f++)
            {
                if (f != 0)
                {
                    JobsArrivalTimes[f] = JobsArrivalTimes[f - 1] + JobInterarrivalTimes[f];
                    if (JobsArrivalTimes[f] <= JobsCompletionTimes[f - 1])//delay
                    {
                        JobsDelayTimes[f] = RoundUp(JobsCompletionTimes[f - 1] - JobsArrivalTimes[f], 3);
                    }
                    else
                    { JobsDelayTimes[f] = 0; }
                  
                }
                else
                {
                    JobsDelayTimes[f] = 0;
                   JobsArrivalTimes[f]=  JobInterarrivalTimes[f] ;
                }
                JobsCompletionTimes[f] = RoundUp((JobsArrivalTimes[f] + JobsDelayTimes[f] + JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text)), 3);

                dataGridView1.Rows.Add(f, JobsArrivalTimes[f], JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text), JobsDelayTimes[f], JobsCompletionTimes[f]);
            }
            //sorting

            JobsCompletionTimes = SortFormSmallToLarge(JobsCompletionTimes);
            JobsArrivalTimes = SortFormSmallToLarge(JobsArrivalTimes);


            int ArriveSeq = 0;
            int LeaveSeq = 0;
            int JobCount = 0;
            int ServerStatus = 0;
            int JobQueue = 0;
            double LastEventTime = 0;
            double Area_JobCount = 0;
            double Area_JobQueue = 0;
            double Area_ServerStatus = 0;

            Series_JobCounts.Points.AddXY(0, 0);
            Series_JobCounts.Points.AddXY(JobsArrivalTimes[0], 0);

            Series_JobQueue.Points.AddXY(0, 0);
            Series_JobQueue.Points.AddXY(JobsArrivalTimes[0], 0);

            Series_JobServer.Points.AddXY(0, 0);
            Series_JobServer.Points.AddXY(JobsArrivalTimes[0], 0);
            //Neat
            do
            {
                // Leave Event
                if (ArriveSeq >= NumberOfJobs || JobsCompletionTimes[LeaveSeq] < JobsArrivalTimes[ArriveSeq])
                {
                    LastEventTime = (JobsCompletionTimes[LeaveSeq] - LastEventTime);
                    Area_JobCount += JobCount * (LastEventTime);
                    Area_JobQueue += JobQueue * (LastEventTime);
                    Area_ServerStatus += ServerStatus * (LastEventTime);
                    JobCount = JobCount - 1;
                    Series_JobCounts.Points.AddXY(JobsCompletionTimes[LeaveSeq], JobCount);
                    ServerStatus = ServerStatus - 1;// Server idle
                    Series_JobServer.Points.AddXY(JobsCompletionTimes[LeaveSeq], ServerStatus);
                    if (JobQueue > 0)// Queue Job enter Server
                    {
                        JobQueue = JobQueue - 1;
                        ServerStatus = ServerStatus + 1;
                        Series_JobQueue.Points.AddXY(JobsCompletionTimes[LeaveSeq], JobQueue);
                        Series_JobServer.Points.AddXY(JobsCompletionTimes[LeaveSeq], ServerStatus);
                    }
                    LastEventTime = JobsCompletionTimes[LeaveSeq];
                    LeaveSeq++;
                }
                // Arrival Event
                else
                {
                    LastEventTime = (JobsArrivalTimes[ArriveSeq] - LastEventTime);
                    Area_JobCount += JobCount * (LastEventTime);
                    Area_JobQueue += JobQueue * (LastEventTime);
                    Area_ServerStatus += ServerStatus * (LastEventTime);
                    JobCount = JobCount + 1;
                    Series_JobCounts.Points.AddXY(JobsArrivalTimes[ArriveSeq], JobCount);
                    if (ServerStatus > 0)// Server Busy
                    {
                        JobQueue = JobQueue + 1;
                        Series_JobQueue.Points.AddXY(JobsArrivalTimes[ArriveSeq], JobQueue);
                    }
                    else// Server idle
                    {
                        ServerStatus = ServerStatus + 1;
                        Series_JobServer.Points.AddXY(JobsArrivalTimes[ArriveSeq], ServerStatus);
                    }
                    LastEventTime = JobsArrivalTimes[ArriveSeq];
                    ArriveSeq++;
                }

            } while (LeaveSeq != NumberOfJobs);
            LB_AvgIntTime.Text = "Average Interarrival Time: " + Convert.ToString(RoundUp(JobInterarrivalTimes.Average(), 3)) + ", Arrival Rate: " + Convert.ToString(RoundUp(1 / JobInterarrivalTimes.Average(), 4));
            LB_WatTime.Text = "Average Wait Time: " + Convert.ToString(RoundUp((Area_JobCount / NumberOfJobs), 3));
            LB_AvgDlyTime.Text = "Average Delay Time: " + Convert.ToString(RoundUp(Area_JobQueue / NumberOfJobs, 3));
            LB_AvgSerTime.Text = "Average Service Time: " + Convert.ToString(RoundUp((Area_ServerStatus / NumberOfJobs), 3)) + ", Service Rate: " + Convert.ToString(RoundUp(1 / (Area_ServerStatus / NumberOfJobs), 4));

            double timeindex = JobsCompletionTimes[NumberOfJobs - 1];
            LB_AJN.Text = "Time_Averaged Job in Nodes: " + Convert.ToString(RoundUp(((JobsServiceTimespans.Sum() + JobsDelayTimes.Sum()) / timeindex), 2));
            LB_AJQ.Text = "Time_Averaged Job in Queue: " + Convert.ToString(RoundUp((JobsDelayTimes.Sum() / timeindex), 2));
            LB_AJS.Text = "Time_Averaged Job in Server: " + Convert.ToString(RoundUp((JobsServiceTimespans.Sum() / timeindex), 2));


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
            BTN_ResetPlot.Enabled = true;
            BTN_ShowPlot.Enabled = false;

            MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].AxisX.ScrollBar.Size = 20;

            //Buttom_Simulate_Stochastic.Enabled = false;
        }

        private void BTN_ResetPlot_Click(object sender, EventArgs e)
        {
            MainChart.Series.Clear();
            MainChart.Titles.Clear();
            MainChart.Legends.Clear();
            BTN_ResetPlot.Enabled = false;
            BTN_ShowPlot.Enabled = true;
            Buttom_Simulate_Stochastic.Enabled = true;
            dataGridView1.Rows.Clear();
        }

        private void ToolButton_Stochastic_Click(object sender, EventArgs e)
        {
            TabControl_Data.TabPages.Insert(0, TabPage_Stochastic);
            TabControl_Data.TabPages.Remove(TabPage_CreatePRO);
            ToolButton_Tracedown.Enabled = true;
            ToolButton_Stochastic.Enabled = false;
            TabControl_Chart.TabPages.Remove(TabPage_RateSimulation);
            TabControl_Chart.TabPages.Insert(1,TabPage_SteadyTest);

            TabControl_Data.SelectedTab = TabPage_Stochastic;
            TOS_BTN_open.Enabled = false;

        }

        private void ToolButton_Tracedown_Click(object sender, EventArgs e)
        {
            TabControl_Data.TabPages.Insert(2, TabPage_CreatePRO);
            TabControl_Data.TabPages.Remove(TabPage_Stochastic);
            ToolButton_Tracedown.Enabled = false;
            ToolButton_Stochastic.Enabled = true;
            TabControl_Chart.TabPages.Remove(TabPage_SteadyTest);
            TabControl_Chart.TabPages.Insert(1, TabPage_RateSimulation);

            TabControl_Data.SelectedTab = TabPage_CurrentPRO;
            TOS_BTN_open.Enabled = true;

        }

        private void Button_steady_simulate_Click(object sender, EventArgs e)
        {

            //Chart_Steady_Test.Series.Clear();
            Chart_Steady_Test.Titles.Clear();
            int NumberOfTest = Convert.ToInt32(TextBox_NumberOfTests.Text);
            double FactorFrom = Convert.ToDouble(TextBox_StartFrom.Text);
            double FactorTo = Convert.ToDouble(TextBox_StartTo.Text);
            double Length = FactorTo - FactorFrom;
            int[] Jobs_Numbers_Array;
            double[] wait_time_array;

            Jobs_Numbers_Array = new int[NumberOfTest];
            wait_time_array = new double[NumberOfTest];

            for (int i = 0; i < NumberOfTest; i++)
            {
                Jobs_Numbers_Array[i] = Convert.ToInt32( RoundUp(FactorFrom + i * (Length / (NumberOfTest - 1)), 2));
            }


            Series Series_simulation = new Series("Sim_"+ Sim_index+" ("+ComboBox_Seed.Text+")");
            Sim_index++;
            //Series_simulation.Color = Colors[Color_index];
            Series_simulation.ChartType = SeriesChartType.Point;
            Series_simulation.BorderWidth = 1;
            //Series_simulation.IsValueShownAsLabel = true;
            Series_simulation.MarkerSize = 10;
            //Series_simulation.MarkerStyle = MarkerStyle.Square;

            Title t = new Title();
            t.Text = "Stead State Test";

            for (int i = 0; i < NumberOfTest; i++)
            {
                NumberOfJobs = Jobs_Numbers_Array[i];

                JobsArrivalTimes = new double[NumberOfJobs];
                JobsCompletionTimes = new double[NumberOfJobs];
                JobsDelayTimes = new double[NumberOfJobs];
                JobInterarrivalTimes = new double[NumberOfJobs];
                JobsServiceTimespans = new double[NumberOfJobs];
                double Total_wait_time = 0;

                Arrival_Generator = new ExponenitalRVG(Convert.ToDouble(TextBox_Average_InterarrivalTime.Text));
                Service_Generator = new UniformRVG(Convert.ToDouble(TextBox_LowerBound.Text), Convert.ToDouble(TextBox_UpperBound.Text));

                if (ComboBox_Seed.Text == "New Random")
                {
                    Arrival_Generator.SetSeed(-1);
                    Service_Generator.SetSeed(-1);
                }
                else
                {
                    Arrival_Generator.SetSeed(Convert.ToInt32(ComboBox_Seed.Text));
                    Service_Generator.SetSeed(Convert.ToInt32(ComboBox_Seed.Text));
                }

                NumberOfJobs = Jobs_Numbers_Array[i];
                for (int a = 0; a < NumberOfJobs; a++)
                {
                    //using RVG generate interarrival_times & Service_times
                    JobInterarrivalTimes[a] = Arrival_Generator.GenerateARealRandomNumber();
                    JobsServiceTimespans[a] = Service_Generator.GenerateARealRandomNumber();
                }

                for (int f = 0; f < NumberOfJobs; f++)
                {
                    if (f != 0)
                    {
                        JobsArrivalTimes[f] = JobsArrivalTimes[f - 1] + JobInterarrivalTimes[f];
                        if (JobsArrivalTimes[f] <= JobsCompletionTimes[f - 1])//delay
                        {
                            JobsDelayTimes[f] = RoundUp(JobsCompletionTimes[f - 1] - JobsArrivalTimes[f], 3);
                        }
                        else
                        { JobsDelayTimes[f] = 0; }

                    }
                    else
                    {
                        JobsDelayTimes[f] = 0;
                        JobsArrivalTimes[f] = JobInterarrivalTimes[f];
                    }
                    JobsCompletionTimes[f] = RoundUp((JobsArrivalTimes[f] + JobsDelayTimes[f] + JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text)), 3);
                    //dataGridView1.Rows.Add(f, JobsArrivalTimes[f], JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text), JobsDelayTimes[f], JobsCompletionTimes[f]);
                }
                //sorting

                JobsCompletionTimes = SortFormSmallToLarge(JobsCompletionTimes);
                JobsArrivalTimes = SortFormSmallToLarge(JobsArrivalTimes);

                for (int j = 0; j < NumberOfJobs; j++)
                {

                    Total_wait_time += JobsCompletionTimes[j] - JobsArrivalTimes[j];
                }
                Series_simulation.Points.AddXY(NumberOfJobs, RoundUp((Total_wait_time/NumberOfJobs), 3));
                
            }

            Chart_Steady_Test.ChartAreas[0].AxisX.Minimum = Jobs_Numbers_Array.First();
            Chart_Steady_Test.ChartAreas[0].AxisX.Maximum = Jobs_Numbers_Array.Last();
            //Chart_Steady_Test.ChartAreas[0].AxisY.Minimum = Convert.ToInt32( wait_time_array.Min())-1;
            //Chart_Steady_Test.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(wait_time_array.Max())+1;

            Chart_Steady_Test.Series.Add(Series_simulation);
            Chart_Steady_Test.Titles.Add(t);
            Chart_Steady_Test.ChartAreas[0].RecalculateAxesScale();


        }

        private void Button_Steady_clear_Click(object sender, EventArgs e)
        {
            Sim_index = 0;
            Chart_Steady_Test.Series.Clear();
            Chart_Steady_Test.Titles.Clear();
        }

        private void BTN_Creat_Click(object sender, EventArgs e)
        {
            if (TB_AIT.Text != null && TB_AITD.Text != null && TB_AST.Text != null && TB_ASTD.Text != null && TB_NOJ.Text != null)
            {
                Random ranD = new Random();
                Random ranPN = new Random();
                AIT = Convert.ToDouble(TB_AIT.Text);
                AITD = Convert.ToDouble(TB_AITD.Text);
                AST = Convert.ToDouble(TB_AST.Text);
                ASTD = Convert.ToDouble(TB_ASTD.Text);
                NOJ = Convert.ToInt32(TB_NOJ.Text);
                NewArrivalData = new double[NOJ];
                NewServiceData = new double[NOJ];

                if (ranPN.NextDouble() > 0.5)
                    NewArrivalData[0] = RoundUp(0.0 + AIT + ranD.NextDouble() * AITD, 3);
                else
                    NewArrivalData[0] = RoundUp(0.0 + AIT - ranD.NextDouble() * AITD, 3);

                for (int i = 1; i < NOJ; i++)
                {
                    if (ranPN.NextDouble() > 0.5)
                        NewArrivalData[i] = RoundUp(NewArrivalData[i - 1] + AIT + ranD.NextDouble() * AITD, 3);
                    else
                        NewArrivalData[i] = RoundUp(NewArrivalData[i - 1] + AIT - ranD.NextDouble() * AITD, 3);
                }

                for (int i = 0; i < NOJ; i++)
                {
                    if (ranPN.NextDouble() > 0.5)
                        NewServiceData[i] = RoundUp(AST + ranD.NextDouble() * ASTD, 3);
                    else
                        NewServiceData[i] = RoundUp(AST - ranD.NextDouble() * ASTD, 3);
                }

                BTN_save.Enabled = true;
            }
        }

        private void BTN_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
            //saveFileDialog1.DefaultExt = ".DAT";
            if (SaveFileDialog.FileName != "")
            {

                StreamWriter sw = new StreamWriter(SaveFileDialog.FileName + ".DAT");
                sw.WriteLine(NOJ);
                for (int i = 0; i < NOJ; i++)
                {
                    sw.WriteLine(NewArrivalData[i].ToString() + " " + NewServiceData[i].ToString());
                    //sw.WriteLine("\n");
                }
                sw.Close();
                BTN_save.Enabled = false;
                MessageBox.Show("Data saved!");
            }
        }


    }
}
