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

namespace r09546042_TerryYang_assignment_03
{
    public delegate int FunTakeOneStringReturnInt(string s);

    public partial class MainForm : Form
    {
        //write new file
        double[] NewDemandQuantity;
        //double[] NewServiceData;
        double MinInv;
        double MaxInv;
        int NumOfInt;
        double AvgDem;
        double DemVar;
        double Cost_item;
        double Cost_setup;
        double Cost_holding;
        double Cost_shortage;

        int NumberOfJobs = 0;
        //double[] JobsArrivalTimes;
        //double[] JobsServiceTimespans;
        //double[] JobsCompletionTimes;
        //double[] JobsDelayTimes;
        //double[] JobInterarrivalTimes;
        //double[] TimeEvent;


        //read data
        int min = 0;
        int max = 0;
        double period = 0;
        double[] quantity;
        double cost_item = 0;
        double cost_holding = 0;
        double cost_setup = 0;
        double cost_shortage = 0;

        //Series series1, series2, series3;
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
                
                LB_FilNam.Text = "File name: "+ Path.GetFileName(OpenFileDialog.FileName);
                richTextBox1.Text = "";
                MainChart.Series.Clear();
                MainChart.Legends.Clear();
                MainChart.Titles.Clear();
                //dataGridView1.Rows.Clear();
                //richTextBox1.Text = "";
                BTN_ResetPlot.Enabled = false;
                BTN_ShowPlot.Enabled = true;

                StreamReader sr = new StreamReader(OpenFileDialog.FileName);
                string[] tmp;
                char[] seps = { ' ', ',', '@' };//分割子

                tmp = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                min = Convert.ToInt32(tmp[0]);
                max = Convert.ToInt32(tmp[1]);
                period = Convert.ToInt32(tmp[2]);
                quantity = new double[Convert.ToInt32( period)];
                

                for (int i = 0; i < period; i++)
                {
                    quantity[i] = Convert.ToInt32(sr.ReadLine());
                }
                //NumberOfJobs = Convert.ToInt32( sr.ReadLine());
                //JobsArrivalTimes = new double[NumberOfJobs];
                //JobsServiceTimespans = new double[NumberOfJobs];
                //JobsCompletionTimes = new double[NumberOfJobs];
                //JobsDelayTimes = new double[NumberOfJobs];
                //JobsDelayTimes = new double[NumberOfJobs];
                //JobInterarrivalTimes = new double[NumberOfJobs];
                //TimeEvent = new double[2 * NumberOfJobs];

                //char[] seps = { ' ', ',', '@' };//分割子
                //for (int i = 0; i < NumberOfJobs; i++)
                //{
                //    tmp = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                //    JobsArrivalTimes[i] = Convert.ToDouble( tmp[0]);
                //    JobsServiceTimespans[i] = Convert.ToDouble(tmp[1]);
                //}
                tmp = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                cost_item = Convert.ToInt32(tmp[0]);
                cost_setup = Convert.ToInt32(tmp[1]);
                cost_holding = Convert.ToInt32(tmp[2]);
                cost_shortage = Convert.ToInt32(tmp[3]);

                sr.Close();

                //richTextBox1.Text += "Number of jobs:" + NumberOfJobs + "\n";
                //for (int i = 0; i < NumberOfJobs; i++)
                //{
                //    dataGridView1.Rows.Add(i, JobsArrivalTimes[i], JobsServiceTimespans[i]);
                //}
                richTextBox1.Text += min.ToString()+" ";
                richTextBox1.Text += max.ToString() + " ";
                richTextBox1.Text += period.ToString() + "\n" ;
                for (int i = 0; i < period; i++)
                {
                    richTextBox1.Text += quantity[i].ToString() + "\n" ;
                }
                richTextBox1.Text += cost_item.ToString() + " ";
                richTextBox1.Text += cost_setup.ToString() + " ";
                richTextBox1.Text += cost_holding.ToString() + " ";
                richTextBox1.Text += cost_shortage.ToString() + " ";
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
            //dataGridView1.Rows.Clear();
            // Series Series_Max = new Series("Job Count");

            Series Series_Min = new Series("Minimum Level");
            Series Series_Max = new Series("Maximum Level");
            Series Series_Inv = new Series("Inventory Level");

            Series_Min.Color = Color.Red;
            Series_Min.ChartType = SeriesChartType.Line;
            Series_Min.BorderWidth = 2;
            Series_Min.Points.AddXY(0, min);
            Series_Min.Points.AddXY(period, min);
            Series_Min.BorderDashStyle = ChartDashStyle.Dash;
            //Series Series_JobQueue = new Series("Job Queue");
            Series_Max.Color = Color.Green;
            Series_Max.ChartType = SeriesChartType.Line;
            Series_Max.BorderWidth = 2;
            Series_Max.Points.AddXY(0, max);
            Series_Max.Points.AddXY(period, max);
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


            double inventory = max;
            double order_times = 0;
            //DataPoint dp = new DataPoint();
            double Area_holding = 0;
            double Area_shortage = 0;

            Series_Inv.Points.AddXY(0, max);

            for (int i = 0; i < period; i++)
            {
                inventory = inventory - quantity[i];
                Series_Inv.Points.AddXY(i+1, inventory);

                if (inventory>0)//計算面積(沒缺貨)
                {
                    Area_holding = Area_holding + inventory + (quantity[i] / 2);
                }
                else//計算面積(缺貨)
                {
                    Area_holding = Area_holding + (quantity[i] + inventory)/*height*/ * ((quantity[i] + inventory) / (quantity[i]))/*bottom*/* (0.5) ;
                    //holding <== holding + (Qi + Inv) * (Qi + Inv / Qi) * (1 / 2)
                    Area_shortage = Area_shortage + (-inventory)/*height*/ * ((-inventory) / (quantity[i]))/*bottom*/ * (0.5);
                    //shortage <== shortage + (-Inv *) * (-Inv / Qi) * (1 / 2)
                }

                if (min>inventory)//reorder
                {
                    order_times++;
                    inventory = max;
                    Series_Inv.Points.AddXY(i+1, max);
                }
            }

            if ( inventory != max)//still reorder at last time point
            {
                order_times++;
                Series_Inv.Points.AddXY(period, max);
            }
                      

            //series1 = Series_Min;
            //series2 = Series_Max;
            //series3 = Series_Inv;
            MainChart.Series.Clear();

            MainChart.Legends.Add(s);
            MainChart.ChartAreas[0].RecalculateAxesScale();
            BTN_ResetPlot.Enabled = true;
            BTN_ShowPlot.Enabled = false;


            Series_Inv.MarkerStyle = MarkerStyle.Diamond;
            Series_Inv.MarkerSize = 10;
            MainChart.Series.Add(Series_Min);
            MainChart.Series.Add(Series_Max);
            MainChart.Series.Add(Series_Inv);

            MainChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            MainChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            MainChart.ChartAreas[0].AxisX.ScrollBar.Size = 20;
            MainChart.ChartAreas[0].AxisX.Maximum = period;
            if (period>50)
            {
                MainChart.ChartAreas[0].AxisX.MinorGrid.Interval = 20;
            }
            else
            {
                MainChart.ChartAreas[0].AxisX.MinorGrid.Interval = 1;
            }

            LB_AvgDem.Text = "Average Demand: "+(RoundUp( quantity.Sum() / period,4)).ToString()+" per period";
            LB_AvgOrd.Text = "Average Order: "+"("+order_times.ToString()+"/"+period.ToString()+") = "+(RoundUp(order_times / period,4)).ToString() + " per period";
            LB_TimAvgHolding.Text = "Time-Average Holding Level: "+RoundUp( (Area_holding/period),4).ToString();
            LB_TimAvgShortage.Text = "Time-Average Shortage Level: "+ RoundUp((Area_shortage / period), 4).ToString();
        }

        //新增類別
        double ComputeArea(Series s)
        {
            double a = 0;
            for (int i = 0; i < 0; i++)
            {

            }
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainChart.Series.Clear();
            MainChart.Titles.Clear();
            MainChart.Legends.Clear();
            BTN_ResetPlot.Enabled = false;
            BTN_ShowPlot.Enabled = true;
            //dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TB_MinInvLev.Text != null && TB_MaxInvLev.Text != null && TB_NumOfInt.Text != null && TB_AvgDem.Text!= null && TB_DemVar.Text != null && TB_IteCost.Text!=null &&TB_HolCost.Text!=null&&TB_ShoCost!=null&& TB_OrdSetCost.Text!=null)
            {
                Random ranD = new Random();
                MinInv = Convert.ToDouble(TB_MinInvLev.Text);
                MaxInv = Convert.ToDouble(TB_MaxInvLev.Text);
                NumOfInt = Convert.ToInt32(TB_NumOfInt.Text);
                AvgDem = Convert.ToDouble(TB_AvgDem.Text);
                DemVar = Convert.ToDouble(TB_DemVar.Text);

                Cost_holding = Convert.ToDouble(TB_HolCost.Text);
                Cost_item = Convert.ToDouble(TB_IteCost.Text);
                Cost_setup = Convert.ToDouble(TB_OrdSetCost.Text);
                Cost_shortage = Convert.ToDouble(TB_ShoCost.Text);

                NewDemandQuantity = new double[NumOfInt];
                for (int i = 0; i < NumOfInt; i++)
                {
                    NewDemandQuantity[i] = AvgDem + 2 * (ranD.NextDouble() - 0.5) * DemVar;
                }             
                BTN_save.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
            if (SaveFileDialog.FileName != "")
        { 
            StreamWriter sw = new StreamWriter(SaveFileDialog.FileName+".txt");

            sw.WriteLine(MinInv + " " +MaxInv + " " +NumOfInt);
                for (int i = 0; i < NumOfInt; i++)
                {
                    sw.WriteLine(RoundUp( NewDemandQuantity[i],0));
                }
                //for (int i = 0; i < NOJ; i++)
                //{
                //    sw.WriteLine(NewArrivalData[i].ToString() + " " + NewServiceData[i].ToString());
                //    //sw.WriteLine("\n");
                //}
                sw.WriteLine(Cost_item.ToString() + " " + Cost_setup.ToString() + " " + Cost_holding.ToString() +" " + Cost_shortage.ToString());
                sw.Close();
            BTN_save.Enabled = false;
            MessageBox.Show("Data saved!");
        }
            
        }       

        //private void CheckBox_JocCount_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (CheckBox_JocCount.Checked == true)
        //        MainChart.Series.Add(series1);
        //    else
        //        MainChart.Series.Remove(series1);
        //}

        private void BTN_simulate_Click(object sender, EventArgs e)
        {
            Chart_simulation.Series.Clear();
            Chart_simulation.Titles.Clear();
            Chart_simulation.Legends.Clear();

            double[] setup_cost = new double[max];
            double[] holding_cost = new double[max];
            double[] shortage_cost = new double[max];
            double Minimum_cost=0;
            double current_cost = 0;
            int Minimum_index = 0;

            Series Series_Setup_Cost = new Series("Setup Cost");           
            Series_Setup_Cost.Color = Color.Magenta;
            Series_Setup_Cost.ChartType = SeriesChartType.StackedColumn;
            Series_Setup_Cost.BorderWidth = 2;

            Series Series_Holding_Cost = new Series("Holding Cost");
            Series_Holding_Cost.Color = Color.Yellow;
            Series_Holding_Cost.ChartType = SeriesChartType.StackedColumn;
            Series_Holding_Cost.BorderWidth = 2;

            Series Series_Shortage_Cost = new Series("Shortage Cost");
            Series_Shortage_Cost.Color = Color.Red;
            Series_Shortage_Cost.ChartType = SeriesChartType.StackedColumn;
            Series_Shortage_Cost.BorderWidth = 2;

            Legend l = new Legend("Spend");
            l.Docking = Docking.Bottom;
            l.Alignment = StringAlignment.Center;

            for (int min_level = 0; min_level < max; min_level++)
            {
                double inventory = max;
                double order_times = 0;
                double Area_holding = 0;
                double Area_shortage = 0;

                for (int i = 0; i < period; i++)
                {
                    inventory = inventory - quantity[i];

                    if (inventory > 0)//計算面積(沒缺貨)
                    {
                        Area_holding = Area_holding + inventory + (quantity[i] / 2);
                    }
                    else//計算面積(缺貨)
                    {
                        Area_holding = Area_holding + (quantity[i] + inventory)/*height*/ * ((quantity[i] + inventory) / (quantity[i]))/*bottom*/* (0.5);
                        //holding <== holding + (Qi + Inv) * (Qi + Inv / Qi) * (1 / 2)
                        Area_shortage = Area_shortage + (-inventory)/*height*/ * ((-inventory) / (quantity[i]))/*bottom*/ * (0.5);
                        //shortage <== shortage + (-Inv *) * (-Inv / Qi) * (1 / 2)
                    }
                    if (min_level > inventory)//reorder
                    {
                        order_times++;
                        inventory = max;
                    }
                }

                if (inventory != max)//still reorder at last time point
                {
                    order_times++;
                    //Series_Inv.Points.AddXY(period, max);
                }
                setup_cost[min_level] = order_times / period;
                holding_cost[min_level] = Area_holding / period;
                shortage_cost[min_level] = Area_shortage / period;

                Series_Setup_Cost.Points.AddXY(min_level, setup_cost[min_level] * cost_setup);
                Series_Holding_Cost.Points.AddXY(min_level, holding_cost[min_level] * cost_holding);
                Series_Shortage_Cost.Points.AddXY(min_level, shortage_cost[min_level] * cost_shortage);

                current_cost = setup_cost[min_level] * cost_setup + holding_cost[min_level] * cost_holding + shortage_cost[min_level] * cost_shortage;
                if (min_level != 0)
                {
                    if (current_cost < Minimum_cost)
                    {
                        Minimum_index = min_level;
                        Minimum_cost = current_cost;
                    }
                }
                else
                    Minimum_cost = current_cost;
            }
            //Series_Setup_Cost.IsValueShownAsLabel = true;
            //Series_Setup_Cost.MarkerSize = 10;
            //Series_Setup_Cost.MarkerStyle = MarkerStyle.Circle;

            Title t = new Title();
            t.Text = "Dependent Cost";

            LB_OptRe.Text = "Optimization Results: Minimal Spent = "+RoundUp( Minimum_cost,4).ToString()+" at Minimum Level = "+Minimum_index.ToString();
            //Series_Setup_Cost.Points.AddXY(0, 10);
            //Series_Setup_Cost.Points.AddXY(5, 20);
            //Series_Setup_Cost.Points.AddXY(6, 50);
            //Series_Holding_Cost.Points.AddXY(10, 50);
            //Series_Setup_Cost.Points.AddXY(10, 20);

            Chart_simulation.Series.Add(Series_Setup_Cost);
            Chart_simulation.Series.Add(Series_Holding_Cost);
            Chart_simulation.Series.Add(Series_Shortage_Cost);
            Chart_simulation.Legends.Add(l);
            
            Chart_simulation.Titles.Add(t);
            Chart_simulation.ChartAreas[0].RecalculateAxesScale();
        }

        //private void CheckBox_JobQueue_CheckedChanged(object sender, EventArgs e)
        //{
        //    if ( CheckBox_JobQueue.Checked == true)
        //        MainChart.Series.Add(series2);
        //    else
        //        MainChart.Series.Remove(series2);
        //}

        //private void CheckBox_ServerStatus_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (CheckBox_ServerStatus.Checked == true)
        //        MainChart.Series.Add(series3);
        //    else
        //        MainChart.Series.Remove(series3);
        //}
    }
}
