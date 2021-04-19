using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //object linked and emabedded
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace r09546042_TerryYang_assignment_02
{
    public delegate int FunTakeOneStringReturnInt(string s);

    public partial class MainForm : Form
    {
        OleDbCommand cmd1;
        OleDbConnection connetor;
        OleDbDataAdapter DatAda;
        DataSet mds = new DataSet();
        DataTable mdt = new DataTable();

        DateTime [] excel_request_time ;
        DateTime[] excel_start_time ;
        DateTime[] excel_end_time ;

        TimeSpan[] excel_delay_time;
        TimeSpan[] excel_interarrival_time;
        TimeSpan[] excel_wait_time;
        TimeSpan[] excel_service_time;

        bool Chart_selection = false;

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

        Series series1, series2, series3;
        
        public MainForm()
        {
            InitializeComponent();
            
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            
            //  throw new NotImplementedException();
            MessageBox.Show("Hello");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainChart_stepline.Series.Clear();
                MainChart_stepline.Legends.Clear();
                MainChart_stepline.Titles.Clear();
                DGV1.Rows.Clear();
                //richTextBox1.Text = "";
                BTN_ResetPlot.Enabled = false;

                BTN_ShowPlot.Enabled = true;
                StreamReader sr = new StreamReader(OpenFileDialog.FileName);
                NumberOfJobs = Convert.ToInt32( sr.ReadLine());
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
                    JobsArrivalTimes[i] = Convert.ToDouble( tmp[0]);
                    JobsServiceTimespans[i] = Convert.ToDouble(tmp[1]);
                }
                sr.Close();

                //richTextBox1.Text += "Number of jobs:" + NumberOfJobs + "\n";
                for (int i = 0; i < NumberOfJobs; i++)
                {
                    DGV1.Rows.Add(i, JobsArrivalTimes[i], JobsServiceTimespans[i]);
                }

                BTN_simulate.Enabled = true;
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox_JocCount.Enabled = true;
            CheckBox_JobQueue.Enabled = true;
            CheckBox_ServerStatus.Enabled = true;
            DGV1.Rows.Clear();
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
                JobsCompletionTimes[f] = RoundUp((JobsArrivalTimes[f] + JobsDelayTimes[f]+ JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text)), 3);

                DGV1.Rows.Add(f, JobsArrivalTimes[f], JobsServiceTimespans[f] * Convert.ToDouble(TextBox_Server_Constant.Text), JobsDelayTimes[f], JobsCompletionTimes[f]);
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
                LB_AvgIntTime.Text = "Average Interarrival Time: " + Convert.ToString(RoundUp(JobInterarrivalTimes.Average(), 3)) + ", Arrival Rate: " + Convert.ToString(RoundUp(1 / JobInterarrivalTimes.Average(), 4));
                LB_WatTime.Text = "Average Wait Time: " + Convert.ToString(RoundUp((Area_JobCount / NumberOfJobs), 3));
                LB_AvgDlyTime.Text = "Average Delay Time: " + Convert.ToString(RoundUp(Area_JobQueue / NumberOfJobs, 3));
                LB_AvgSerTime.Text = "Average Service Time: " + Convert.ToString(RoundUp((Area_ServerStatus / NumberOfJobs), 3)) + ", Service Rate: " + Convert.ToString(RoundUp(1 / (Area_ServerStatus / NumberOfJobs), 4));

                double timeindex = JobsCompletionTimes[NumberOfJobs - 1];
                LB_AJN.Text = "Time_Averaged Job in Nodes: " + Convert.ToString(RoundUp(((JobsServiceTimespans.Sum() + JobsDelayTimes.Sum()) / timeindex), 2));
                LB_AJQ.Text = "Time_Averaged Job in Queue: " + Convert.ToString(RoundUp((JobsDelayTimes.Sum() / timeindex), 2));
                LB_AJS.Text = "Time_Averaged Job in Server: " + Convert.ToString(RoundUp((JobsServiceTimespans.Sum() / timeindex), 2));
            } while (LeaveSeq != NumberOfJobs);

            series1 = Series_JobCounts;
            series2 = Series_JobQueue;
            series3 = Series_JobServer;
            MainChart_stepline.Series.Clear();
            if (CheckBox_JocCount.Checked == true)
                MainChart_stepline.Series.Add(Series_JobCounts);
            if (CheckBox_JobQueue.Checked == true)
                MainChart_stepline.Series.Add(Series_JobQueue);
            if (CheckBox_ServerStatus.Checked == true)
                MainChart_stepline.Series.Add(Series_JobServer);

            MainChart_stepline.Legends.Add(s);
            MainChart_stepline.ChartAreas[0].RecalculateAxesScale();
            BTN_ResetPlot.Enabled = true;
            BTN_ShowPlot.Enabled = false;

            MainChart_stepline.ChartAreas[0].CursorX.IsUserEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            MainChart_stepline.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            MainChart_stepline.ChartAreas[0].AxisX.ScrollBar.Size = 20;

        }

        //新增類別
        //double ComputeArea(Series s)
        //{
        //    double a = 0;
        //    for (int i = 0; i < 0; i++)
        //    {

        //    }
        //    return 0;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            MainChart_stepline.Series.Clear();
            MainChart_stepline.Titles.Clear();
            MainChart_stepline.Legends.Clear();
            BTN_ResetPlot.Enabled = false;
            BTN_ShowPlot.Enabled = true;
            DGV1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TB_AIT.Text != null && TB_AITD.Text != null && TB_AST.Text != null && TB_ASTD.Text!= null && TB_NOJ.Text != null)
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

                if (ranPN.NextDouble()>0.5)
                    NewArrivalData[0] = RoundUp(0.0 + AIT +  ranD.NextDouble() * AITD,3);
                else
                    NewArrivalData[0] = RoundUp(0.0 + AIT - ranD.NextDouble() * AITD,3);

                for (int i = 1; i < NOJ; i++)
                {
                    if (ranPN.NextDouble() > 0.5)
                        NewArrivalData[i] = RoundUp(NewArrivalData[i - 1] + AIT + ranD.NextDouble() * AITD,3);
                    else
                        NewArrivalData[i] = RoundUp(NewArrivalData[i - 1] + AIT - ranD.NextDouble() * AITD,3);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
            //saveFileDialog1.DefaultExt = ".DAT";
            if (SaveFileDialog.FileName != "")
        { 

            StreamWriter sw = new StreamWriter(SaveFileDialog.FileName+".DAT");
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

        private void CheckBox_JocCount_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_JocCount.Checked == true)
                MainChart_stepline.Series.Add(series1);
            else
                MainChart_stepline.Series.Remove(series1);
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            TOS_BTN_analyze.Enabled = true;
            MainChart_stepline.Series.Clear();
            MainChart_stepline.Series.Clear();
            MainChart_bar.Series.Clear();
            MainChart_bar.Legends.Clear();
            mdt.Clear();

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            string cmdString = "select MICRO_RECEIVED_TIME, MICRO_START_TIME, MICRO_END_TIME from [r40$]";
            string connString = $"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={ dlg.FileName }; Extended Properties= Excel 8.0";
            DatAda = new OleDbDataAdapter(cmdString, connString);

            
            //int num = DA1.Fill(mds);
            int nu = DatAda.Fill(mdt);
            //int num = DA1.Fill(mdt); //read whole data table
            DGV1.Columns.Clear();
            //dataGridView1.Rows.Clear();
            //dataGridView1.DataSource = mds.Tables[0];
            DGV1.DataSource = mdt;

            //DateTime[] requestTime, startTime, endTime;
            excel_request_time = new DateTime[mdt.Rows.Count];
            excel_start_time = new DateTime[mdt.Rows.Count];
            excel_end_time = new DateTime[mdt.Rows.Count];

            excel_wait_time = new TimeSpan[mdt.Rows.Count];
            excel_delay_time =new TimeSpan[mdt.Rows.Count];
            excel_interarrival_time= new TimeSpan[mdt.Rows.Count];
            excel_service_time = new TimeSpan[mdt.Rows.Count];

            for (int r = 0; r < mdt.Rows.Count; r++)
            {
                excel_request_time[r] = Convert.ToDateTime(mdt.Rows[r].ItemArray[0]);
                excel_start_time[r] = Convert.ToDateTime(mdt.Rows[r].ItemArray[1]);
                excel_end_time[r] = Convert.ToDateTime(mdt.Rows[r].ItemArray[2]);
                //dataGridView1.Rows.Add(r, requestTime[r], startTime[r], endTime[r]);
            }

            foreach (DataColumn dc in mdt.Columns)
            {
                string ColType = dc.DataType.ToString();
            }
            //cmd1 = new OleDbCommand();
            //connetor = new OleDbConnection();//"provider=microsoft.jet.oledb.4.0;data source=" + saveResult +";extended properties=" + "\"excel 8.0;HDR=No;IMEX=1\"";
            //connetor.ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={ dlg.FileName }; Extended Properties= Excel 8.0";

            ////connetor.Open();
            //cmd1.CommandText = $"select job_id from [r40$]";
            //cmd1.Connection = connetor;
            //OleDbDataReader reader = cmd1.ExecuteReader();
            //while (reader.Read() )
            //{
            //    string id = reader.GetString(0);
            //}

            //connetor.Close();
        }
        DateTime[] SortFormSmallToLargeDate(DateTime[] a)//bubble sort
        {
            DateTime tmp;
            for (int i = 0; i < NumberOfJobs; i++)
            {
                for (int j = 0; j < NumberOfJobs - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
            return a;
        }
        private void ChartGannt(Series ser, DateTime start, DateTime end, Color c)
        {
            DataPoint dp = new DataPoint();
            dp.Color = c;
            dp.SetValueXY(1, start, end);
            ser.Points.Add(dp);
        }
        DateTime fromTimeString(string time)
        {
            var p = time.Split(':');
            int sec = p.Length == 3 ? Convert.ToInt16(p[2]) : 0;
            TimeSpan t = new TimeSpan(Convert.ToInt16(p[0]), Convert.ToInt16(p[1]), sec);
            return DateTime.Today.Add(t);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
 
            Series Series_JobCounts = new Series("Job in Node");
            Series Series_JobQueue = new Series("Job in Queue");

            //Step Line
            Series_JobCounts.Color = Color.Red;
            Series_JobCounts.ChartType = SeriesChartType.StepLine;
            Series_JobCounts.BorderWidth = 2;
            Series_JobCounts.XValueType = ChartValueType.DateTime;

            Series_JobQueue.Color = Color.Green;
            Series_JobQueue.ChartType = SeriesChartType.StepLine;
            Series_JobQueue.BorderWidth = 2;
            Series_JobQueue.XValueType = ChartValueType.DateTime;

            //Stacked Bar
            Series Series_Server_Free = new Series("Free");
            Series_Server_Free.Color = Color.Lime;
            Series_Server_Free.ChartType = SeriesChartType.RangeBar;
            Series_Server_Free.BorderWidth = 2;
            Series_Server_Free.YValueType = ChartValueType.DateTime;
            Series_Server_Free.YValuesPerPoint = 2;

            Series Series_Server_Busy = new Series("Busy");
            Series_Server_Busy.Color = Color.Red;
            Series_Server_Busy.ChartType = SeriesChartType.RangeBar;
            Series_Server_Busy.BorderWidth = 2;
            Series_Server_Busy.YValueType = ChartValueType.DateTime;
            Series_Server_Busy.YValuesPerPoint = 2;

            Series Series_Server_Idle = new Series("Idle");
            Series_Server_Idle.Color = Color.Blue;
            Series_Server_Idle.ChartType = SeriesChartType.RangeBar;
            Series_Server_Idle.BorderWidth = 2;
            Series_Server_Idle.YValueType = ChartValueType.DateTime;
            Series_Server_Idle.YValuesPerPoint = 2;

            MainChart_bar.ChartAreas[0].AxisX.Maximum = 1.5;
            MainChart_bar.ChartAreas[0].AxisX.Minimum = 0.5;

            Legend l = new Legend("Sever Status");
            l.Docking = Docking.Bottom;
            l.Alignment = StringAlignment.Center;

            Legend s = new Legend("Job Count");
            s.Docking = Docking.Bottom;
            s.Alignment = StringAlignment.Center;

            NumberOfJobs = excel_end_time.Count();

            //get, excel_delay_time, excel_wait_time, excel_service_time
            for (int f = 0; f < NumberOfJobs; f++)
            {             
                excel_delay_time[f] = (excel_start_time[f] - excel_request_time[f]);
                excel_wait_time[f] =  excel_end_time[f] - excel_request_time[f];
                excel_service_time[f] = excel_end_time[f] - excel_start_time[f];
            }

            //sorting
            excel_end_time = SortFormSmallToLargeDate(excel_end_time);
            excel_request_time = SortFormSmallToLargeDate(excel_request_time);
            excel_start_time = SortFormSmallToLargeDate(excel_start_time);

            //get excel_interarrival_time
            for (int f = 0; f < NumberOfJobs; f++)
            {
                if (f != 0)
                    excel_interarrival_time[f] = excel_request_time[f] - excel_request_time[f - 1];
                else
                    excel_interarrival_time[f] = TimeSpan.Zero;
            }
            int StartSeq = 0;
            int ArriveSeq = 0;
            int LeaveSeq = 0;
            double Area_JobCount=0;
            double Area_JobQueue=0;
            double Area_JobServer_Busy=0;
            double Area_JobServer_Idle = 0;

            int JobCount = 0;
            int ServerStatus = 0;
            int JobQueue = 0;
            string status = "free";
            DateTime LastEventTime = excel_request_time[0];
            TimeSpan Total_Time_Span = excel_end_time[NumberOfJobs - 1] - excel_request_time[0];
            //double Area_JobCount = 0;
            //double Area_JobQueue = 0;
            double Area_ServerStatus = 0;

            //Series_JobCounts.Points.AddXY(0, 0);
            Series_JobCounts.Points.AddXY(excel_request_time[0], 0);
            //Series_JobQueue.Points.AddXY(0, 0);
            Series_JobQueue.Points.AddXY(excel_request_time[0], 0);




            //Neat
            do
            {
                //arrival
                if (excel_request_time[ArriveSeq] <= excel_start_time[StartSeq] && excel_request_time[ArriveSeq] <= excel_end_time[LeaveSeq])
                {
                    Area_JobCount = Area_JobCount + (excel_request_time[ArriveSeq] - LastEventTime).TotalSeconds * JobCount;
                    Area_JobQueue = Area_JobQueue + (excel_request_time[ArriveSeq] - LastEventTime).TotalSeconds * JobQueue;

                    JobCount = JobCount + 1;
                    JobQueue = JobQueue + 1;

                    //checking server status
                    //if (status == "free")//free to idle
                    //{
                    Series_JobCounts.Points.AddXY(excel_request_time[ArriveSeq], JobCount);
                    Series_JobQueue.Points.AddXY(excel_request_time[ArriveSeq], JobQueue);
                    
                    if (status == "free")
                    {                  
                        ChartGannt(Series_Server_Free, LastEventTime, excel_request_time[ArriveSeq], Color.Lime);
                        Area_JobServer_Idle = Area_JobServer_Idle + (excel_request_time[ArriveSeq] - LastEventTime).TotalSeconds;
                        status = "idle";
                    }
                    else if (status == "idle")
                    {
                        ChartGannt(Series_Server_Free, LastEventTime, excel_request_time[ArriveSeq], Color.Blue);
                    }
                    else if (status == "busy")
                    {
                        ChartGannt(Series_Server_Free, LastEventTime, excel_request_time[ArriveSeq], Color.Red);
                        Area_JobServer_Busy = Area_JobServer_Busy + (excel_request_time[ArriveSeq] - LastEventTime).TotalSeconds;
                    }



                    LastEventTime = excel_request_time[ArriveSeq];

                    if (ArriveSeq != NumberOfJobs-1)
                        ArriveSeq = ArriveSeq + 1;
                    else
                        excel_request_time[ArriveSeq] = DateTime.Now;//set to infinity
                }
                //service start
                else if (excel_start_time[StartSeq] <= excel_end_time[LeaveSeq])
                {
                    Area_JobCount = Area_JobCount + (excel_start_time[StartSeq] - LastEventTime).TotalSeconds * JobCount;
                    Area_JobQueue = Area_JobQueue + (excel_start_time[StartSeq] - LastEventTime).TotalSeconds * JobQueue;

                    JobQueue = JobQueue - 1;

                    Series_JobCounts.Points.AddXY(excel_start_time[StartSeq], JobCount);
                    Series_JobQueue.Points.AddXY(excel_start_time[StartSeq], JobQueue);                   

                    if (status=="free")
                    {
                        ChartGannt(Series_Server_Free, LastEventTime, excel_start_time[StartSeq],Color.Lime);
                        Area_JobServer_Idle = Area_JobServer_Idle + (excel_start_time[StartSeq] - LastEventTime).TotalSeconds;
                    }
                    else if (status == "idle")
                    {
                        ChartGannt(Series_Server_Free, LastEventTime, excel_start_time[StartSeq], Color.Blue);
                    }
                    else if (status == "busy")
                    {
                        ChartGannt(Series_Server_Free, LastEventTime, excel_start_time[StartSeq], Color.Red);
                        Area_JobServer_Busy = Area_JobServer_Busy+(excel_start_time[StartSeq] - LastEventTime).TotalSeconds;
                    }
                    status = "busy";


                    LastEventTime = excel_start_time[StartSeq];
                    if (StartSeq != NumberOfJobs-1)
                        StartSeq = StartSeq + 1;
                    else
                        excel_start_time[StartSeq] = DateTime.Now;//set to infinity
                }
                //complete
                else
                {
                    Area_JobCount = Area_JobCount + (excel_end_time[LeaveSeq] - LastEventTime).TotalSeconds * JobCount;
                    Area_JobQueue = Area_JobQueue + (excel_end_time[LeaveSeq] - LastEventTime).TotalSeconds * JobQueue;

                    JobCount = JobCount - 1;
                    Series_JobCounts.Points.AddXY(excel_end_time[LeaveSeq], JobCount);
                    Series_JobQueue.Points.AddXY(excel_end_time[LeaveSeq], JobQueue);

                    ChartGannt(Series_Server_Free, LastEventTime, excel_end_time[LeaveSeq],Color.Red);
                    Area_JobServer_Busy = Area_JobServer_Busy + (excel_end_time[LeaveSeq] - LastEventTime).TotalSeconds;

                    if (JobQueue==0)
                    {
                        status = "free";
                    }
                    else
                    {
                        status = "idle";
                    }



                    LastEventTime = excel_end_time[LeaveSeq];

                    if (LeaveSeq != NumberOfJobs)
                        LeaveSeq = LeaveSeq + 1;
                }
                //MessageBox.Show(Area_JobCount.ToString());
                
            } while (LeaveSeq != NumberOfJobs);//all jobs leaves, end while

            //var totalSpan = new TimeSpan(excel_wait_time.Sum(r => r.Ticks));
            LB_AvgIntTime.Text = "Average Interarrival Time: " + (RoundUp(TimeSpansToMinutes(excel_interarrival_time) / Convert.ToDouble(NumberOfJobs-1), 2)).ToString()+" mins" + ", Arrival Rate: " +RoundUp(1.0/ (RoundUp(TimeSpansToMinutes(excel_interarrival_time) / Convert.ToDouble(NumberOfJobs-1), 2)), 4);
             LB_AvgSerTime.Text = "Average Service Time: "+(RoundUp(TimeSpansToMinutes(excel_service_time) / Convert.ToDouble(NumberOfJobs), 2)).ToString() + " mins" + ", Service Rate: " + RoundUp(1.0 / (RoundUp(TimeSpansToMinutes(excel_service_time) / Convert.ToDouble(NumberOfJobs), 2)), 4);
            LB_WatTime.Text = "Average Wait Time: "+(RoundUp(TimeSpansToMinutes(excel_wait_time) / Convert.ToDouble( NumberOfJobs),2)).ToString() + " mins";
            LB_AvgDlyTime.Text = "Average Delay Time: "+(RoundUp(TimeSpansToMinutes(excel_delay_time) / Convert.ToDouble(NumberOfJobs), 2)).ToString() + " mins";
            
            LB_AJN.Text = "Time_Averaged Job in Nodes: " + (RoundUp(Area_JobCount / Convert.ToDouble((Total_Time_Span).TotalSeconds), 2)).ToString();
            LB_AJQ.Text = "Time_Averaged Job in Queue: " + (RoundUp(Area_JobQueue /Convert.ToDouble( (Total_Time_Span).TotalSeconds), 2)).ToString(); 
            LB_AJS.Text = "Server: "+ (RoundUp(Area_JobServer_Busy/ Convert.ToDouble((Total_Time_Span).TotalSeconds),2)*100.0).ToString()+"%"+" Busy, "
                + (RoundUp(Area_JobServer_Idle / Convert.ToDouble((Total_Time_Span).TotalSeconds), 2) * 100.0).ToString() + "%" + " Idle, "+
                (100-(RoundUp(Area_JobServer_Idle / Convert.ToDouble((Total_Time_Span).TotalSeconds), 2) * 100.0)).ToString() + "%" + " Free";
            //LB_AvgIntTime.Text = (TimeSpansToMinutes(excel_wait_time) / Convert.ToDouble(NumberOfJobs)).ToString();

            MainChart_stepline.Series.Add(Series_JobCounts);
            MainChart_stepline.Series.Add(Series_JobQueue);
            MainChart_stepline.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd hh:mm:ss";

            MainChart_bar.Legends.Add(l);
            MainChart_bar.Series.Add(Series_Server_Free);
            MainChart_bar.Series.Add(Series_Server_Busy);
            MainChart_bar.Series.Add(Series_Server_Idle);
            MainChart_bar.ChartAreas[0].RecalculateAxesScale();
            MainChart_bar.ChartAreas[0].AxisY.IsMarginVisible = false;
            MainChart_bar.ChartAreas[0].AxisY.Minimum = excel_request_time[0].ToOADate();
            MainChart_bar.ChartAreas[0].AxisY.LabelStyle.Format = "MM/dd hh:mm:ss";

            //Chart_bar.ChartAreas[0].AxisY.Maximum
            //Chart_bar.ChartAreas[0].AxisY.
            //Chart_bar.ChartAreas[0].AxisY.Maximum = excel_end_time[NumberOfJobs];
            //Chart_bar.Series.Add(Series_Server_Busy);
            //Chart_bar.Series.Add(Series_Server_Idle);

            //Scyn two charts
            ChartArea ca1 = MainChart_stepline.ChartAreas[0];
            ChartArea ca2= MainChart_bar.ChartAreas[0];
            Axis ax1 = ca1.AxisX;
            Axis ax2 = ca2.AxisY;
            ax1.ScaleView.Zoomable = true;
            ax2.ScaleView.Zoomable = true;

            ca1.CursorX.IsUserSelectionEnabled = true;
            ca2.CursorY.IsUserSelectionEnabled = true;
        }
        double TimeSpansToMinutes(TimeSpan[] a)//bubble sort
        {
            double min = 0.0;
            for (int i = 0; i < a.Length; i++)
            {
                min = min + a[i].TotalMinutes;
            }

            return min;
        }
        private void MainChart_AxisViewChanged(object sender, ViewEventArgs e)
        {
            ChartArea ca1 = MainChart_stepline.ChartAreas[0];
            ChartArea ca2 = MainChart_bar.ChartAreas[0];
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

        private void Chart_bar_AxisViewChanged(object sender, ViewEventArgs e)
        {
            ChartArea ca1 = MainChart_stepline.ChartAreas[0];
            ChartArea ca2 = MainChart_bar.ChartAreas[0];
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

        private void MainChart_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (Chart_selection == true)
            {
                MainChart_bar.ChartAreas[0].CursorY.IsUserEnabled = true;
                MainChart_bar.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                //Chart_bar.ChartAreas[0].CursorY.SelectionStart = MainChart.ChartAreas[0].CursorX.SelectionStart;
                //Chart_bar.ChartAreas[0].CursorY.SelectionEnd = MainChart.ChartAreas[0].CursorX.SelectionEnd;
                //Chart_bar.ChartAreas[0].CursorY.SetSelectionPosition(MainChart.ChartAreas[0].CursorX.SelectionStart, MainChart.ChartAreas[0].CursorX.SelectionEnd);

                MainChart_bar.ChartAreas[0].CursorY = MainChart_stepline.ChartAreas[0].CursorX;
                //Chart_bar.ChartAreas[0].AxisY.ScaleView.
                //Chart_bar.ChartAreas[0].CursorY.;
                //MessageBox.Show(Convert.ToString(MainChart.ChartAreas[0].CursorX.SelectionStart));
                //MessageBox.Show(Convert.ToString(MainChart.ChartAreas[0].CursorX.SelectionEnd));
            }
            Chart_selection = false;
        }


        private void MainChart_SelectionRangeChanging(object sender, CursorEventArgs e)
        {
            //Chart_bar.ChartAreas[0].CursorY.SelectionStart = MainChart.ChartAreas[0].CursorX.SelectionStart;
            //Chart_bar.ChartAreas[0].CursorY.SelectionEnd = MainChart.ChartAreas[0].CursorX.SelectionEnd;
        }

        

        private void CheckBox_JobQueue_CheckedChanged(object sender, EventArgs e)
        {
            if ( CheckBox_JobQueue.Checked == true)
                MainChart_stepline.Series.Add(series2);
            else
                MainChart_stepline.Series.Remove(series2);
        }

        private void CheckBox_ServerStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_ServerStatus.Checked == true)
                MainChart_stepline.Series.Add(series3);
            else
                MainChart_stepline.Series.Remove(series3);
        }
    }
}
