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

namespace r09546042_楊雲皓_assignment_01
{
    public delegate int FunTakeOneStringReturnInt(string s);

    public partial class MainForm : Form
    {
        FunTakeOneStringReturnInt myfun;
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
        double[] JobsLeaveTimes;       
        public MainForm()
        {
            InitializeComponent();

         //   button1.Click += Button1_Click;
         //   button1.Click += aaa;
         //   button1.Click += bbb;

         //   int i;
         //  i =  kkk("first");
         //   myfun = kkk;
         //  i = myfun("second");
         //   myfun = gggg;
         //  i= myfun("third");


         //   myfun += kkk;
         //i =    myfun("zzzzz");

        }

        int kkk( string s )
        {
            MessageBox.Show($"kkk {s}");
            return 99;
        }
        int gggg(string s)
        {
             MessageBox.Show($"ggg { s}");
            return 88;
        }
        void bbb(object o, EventArgs ee )
        {
            MessageBox.Show("Hi");
           // return 1;
        }
        private void aaa(object sender, EventArgs e)
        {
             
            Button b = (Button)sender;
            b.Text = "XXXX";

            MessageBox.Show("Hey");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            //  throw new NotImplementedException();
            MessageBox.Show("Hello");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                richTextBox1.Text = "";
                button2.Enabled = false;

                button1.Enabled = true;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                NumberOfJobs = Convert.ToInt32( sr.ReadLine());
                JobsArrivalTimes = new double[NumberOfJobs];
                JobsServiceTimespans = new double[NumberOfJobs];
                JobsLeaveTimes = new double[NumberOfJobs];
                string[] tmp;
                for (int i = 0; i < NumberOfJobs; i++)
                {
                    tmp = sr.ReadLine().Split(' ');
                    JobsArrivalTimes[i] = Convert.ToDouble( tmp[0]);
                    JobsServiceTimespans[i] = Convert.ToDouble(tmp[1]);
                }
                sr.Close();

                richTextBox1.Text += "Number of jobs:" + NumberOfJobs + "\n";
                for (int i = 0; i < NumberOfJobs; i++)
                {
                    richTextBox1.Text += "Job "+i +  " arrive at " + JobsArrivalTimes[i] 
                        +", servive last for "+JobsServiceTimespans[i] + "\n";
                }


            }
        }

        double[] SortFormSmallToLarge(double[] a)//bubble sort
        {
            double tmp=0;
            for (int i = 0; i < NumberOfJobs; i++)
            {
                for (int j = 0; j < NumberOfJobs-1; j++)
                            {
                               /* if (a[i+1] != null)
                                {*/
                                    if (a[j]>a[j+1])
                                    {
                                        tmp = a[j];
                                        a[j] = a[j + 1];
                                        a[j + 1] = tmp;                 
                                    }
                                /*}*/
                            }
            }
            

            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            Series series1 = new Series("Job Count");
            series1.Color = Color.Red;
            series1.ChartType = SeriesChartType.StepLine;
            series1.BorderWidth = 2;
            //series1.IsXValueIndexed = true;
            //series1.IsValueShownAsLabel = true;
            //series1.y
            Title t = new Title();
            t.Text = "Job service Chart";
            //Legend s = new Legend("Job Count");
            
            for (int f = 0; f < NumberOfJobs; f++)
            {
                JobsLeaveTimes[f] = JobsArrivalTimes[f] + JobsServiceTimespans[f];
            }
            //sorting
            JobsLeaveTimes = SortFormSmallToLarge(JobsLeaveTimes);
            JobsArrivalTimes = SortFormSmallToLarge(JobsArrivalTimes);

            int ArriveSeq = 0;
            int LeaveSeq = 0;
            int JobCount = 0;
            series1.Points.AddXY(0, 0);
            series1.Points.AddXY(JobsArrivalTimes[0], 0);
            do
            {
                if (ArriveSeq != NumberOfJobs)
                {
                    if (JobsArrivalTimes[ArriveSeq] <= JobsLeaveTimes[LeaveSeq])
                    {
                        JobCount++;
                        series1.Points.AddXY(JobsArrivalTimes[ArriveSeq], JobCount);
                        ArriveSeq++;
                    }
                }
                if (ArriveSeq!=NumberOfJobs)
                {
                    if (JobsLeaveTimes[LeaveSeq] < JobsArrivalTimes[ArriveSeq])
                    {
                        JobCount--;
                        series1.Points.AddXY(JobsLeaveTimes[LeaveSeq], JobCount);
                        LeaveSeq++;
                    }
                }
                if (ArriveSeq==NumberOfJobs)
                {
                    JobCount--;
                    series1.Points.AddXY(JobsLeaveTimes[LeaveSeq], JobCount);
                    LeaveSeq++;
                }
            } while (LeaveSeq!=NumberOfJobs);           

            chart1.Series.Add(series1);
            //chart1.Legends.Add(s);
            //chart1.Titles.Add(t);
            //series1.Points.Clear();

            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            richTextBox1.Text = "";
            button2.Enabled = false;
            button1.Enabled = true;
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
                    NewArrivalData[0] = Math.Round(0.0 + AIT +  ranD.NextDouble() * AITD,2);
                else
                    NewArrivalData[0] = Math.Round(0.0 + AIT - ranD.NextDouble() * AITD,2);

                for (int i = 1; i < NOJ; i++)
                {
                    if (ranPN.NextDouble() > 0.5)
                        NewArrivalData[i] = Math.Round(NewArrivalData[i - 1] + AIT + ranD.NextDouble() * AITD,2);
                    else
                        NewArrivalData[i] = Math.Round(NewArrivalData[i - 1] + AIT - ranD.NextDouble() * AITD,2);
                }

                for (int i = 0; i < NOJ; i++)
                {
                    if (ranPN.NextDouble() > 0.5)
                        NewServiceData[i] = Math.Round(AST + ranD.NextDouble() * ASTD, 2);
                    else
                        NewServiceData[i] = Math.Round(AST - ranD.NextDouble() * ASTD, 2);
                }

                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            //saveFileDialog1.DefaultExt = ".DAT";
            if (saveFileDialog1.FileName != "")
        { 

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName+".DAT");
            sw.WriteLine(NOJ);
            for (int i = 0; i < NOJ; i++)
            {
                sw.WriteLine(NewArrivalData[i].ToString() + " " + NewServiceData[i].ToString());
                //sw.WriteLine("\n");
            }
            sw.Close();
            button4.Enabled = false;
            MessageBox.Show("Data saved!");
        }
            
        }

        //private void button5_MouseDown(object sender, MouseEventArgs e)
        //{

        //}
    }
}
