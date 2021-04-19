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

namespace r09546042_TerryYang_assignment_04
{

    public partial class Main_form : Form
    {
        int m = ((int)Math.Pow(2, 31) - 1);
        int a = 48271;

        //nodes_variables
        int number_of_nodes;
        int number_of_pahts;
        double[,] location_of_nodes;
        int[,] paths_from_to_length;

        //drawing
        int circle_radius = 25;
        Cursor NodeCursor;
        Cursor PathCrusor;

        //routing
        List<List<int>> All_paths = new List<List<int>>();
        List<List<int>> All_paths_Lengthes = new List<List<int>>();
        List<double> All_paths_time = new List<double>();

        //new nodes variables
        int number_of_nodes_new = 0;
        int number_of_pahts_new = 0;
        List<double> X_location_of_nodes_new = new List<double>();
        List<double> Y_location_of_nodes_new = new List<double>();
        int nearest_X_End_index;
        int nearest_Y_End_index;
        int nearest_X_start_index;
        int nearest_Y_start_index;

        bool whether_draw_TempLine = false;

        List<List<int>> paths_from_to_length_new = new List<List<int>>();
        public Main_form()
        {
            InitializeComponent();
            RM_RichTextBox_Result.Text = "Probability of Positive Determinant :\n";
            GC_RichTextBox_Result.Text = "Probability of Winning the Craps Game :\n";
            HG_RichTextBox_Result.Text = "Probability of All Hats Returned Wrong :\n";
            //ToolStrip_creat.Visible = false;
            ToolStrip_creat.Enabled = false
                ;
            NodeCursor = new Cursor("Node.cur");
            PathCrusor = new Cursor("Path.cur");
        }
        private double Round_up(double a, int i)
        {
            return Math.Round(a, i);
        }
        private Tuple<int, int> Rand_Number(double L, double U, int X)
        {
            if (X == -1)
                X = Convert.ToInt32(ComboBox_Seed.Text);
            int q = m / a;
            int r = m % a;
            int t = a * (X % q) - r * (X / q);
            double ratio;
            double R;

            if (t > 0)
                X = t;
            else
                X = t + m;
            ratio = (Convert.ToDouble(X) / m);
            R = L + (U - L) * ratio;
            return new Tuple<int, int>(Convert.ToInt32(Math.Floor(R)), X);
        }

        private Tuple<int[], int> Shuffle(int[] customer_seq, int Number_of_Customers, int seed)
        {
            int[] Shuffled_seq = new int[Number_of_Customers];
            int[] tmp = new int[Number_of_Customers];
            int seq = 0;
            //temping 
            for (int y = 0; y < Number_of_Customers; y++)
            {
                tmp[y] = customer_seq[y];
            }
            //shuffling
            for (int i = 0; i < Number_of_Customers; i++)
            {
                //random seq
                var tuple = Rand_Number(0, Number_of_Customers - i, seed);
                seq = tuple.Item1;
                seed = tuple.Item2;
                //seq = Rand_Number(0, Number_of_Customers - i, 1);
                Shuffled_seq[i] = customer_seq[seq];
                //move customer seq
                int left = Number_of_Customers - seq;
                for (int j = 0; j < left - 1; j++)
                {
                    customer_seq[seq] = tmp[seq + 1];
                    seq++;
                }
                //new tmp
                for (int y = 0; y < Number_of_Customers; y++)
                {
                    tmp[y] = customer_seq[y];
                }
            }

            return new Tuple<int[], int>(Shuffled_seq, seed);
        }

        private bool Check(int[] a, int length)
        {
            int[] b = new int[length];
            bool same = false;
            //original array
            for (int j = 0; j < length; j++)
            {
                b[j] = j;
            }
            //whether equal
            for (int i = 0; i < length; i++)
            {
                if (a[i] == b[i])
                {
                    same = true;
                    break;
                }
            }
            return same;
        }
        private int Shuffle_and_Check(int[] customer_seq, int Number_of_Customers, int Replications)
        {

            int seed = -1;
            int Times_of_all_Hats_Wrong = 0;
            int[] Shuffled_seq = new int[Number_of_Customers];
            int[] tmp = new int[Number_of_Customers];


            //do replocations
            for (int times = 0; times < Replications; times++)
            {
                //reset customer_seq array
                for (int j = 0; j < Number_of_Customers; j++)
                {
                    customer_seq[j] = j;
                }

                //checking
                var tuple = Shuffle(customer_seq, Number_of_Customers, seed);
                Shuffled_seq = tuple.Item1;
                seed = tuple.Item2;

                if (Check(Shuffled_seq, Number_of_Customers) == false)
                    Times_of_all_Hats_Wrong++;
            }
            return Times_of_all_Hats_Wrong;
        }

        private void Walk_to_next_node(List<int> Path_list, int Node, int Length, List<int> Path_Length_list)//return append next posibble node to list
        {
            //walk
            Path_list.Add(Node);
            Path_Length_list.Add(Length);

            //walk to the end
            if (Node == number_of_nodes - 1)
            {
                All_paths.Add(Path_list);
                All_paths_Lengthes.Add(Path_Length_list);
            }

            //check branches ahead
            for (int i = 0; i < number_of_pahts; i++)
            {
                if (paths_from_to_length[i, 0] == Node)
                {
                    List<int> b = new List<int>();
                    b = Path_list.ToList();
                    List<int> c = new List<int>();
                    c = Path_Length_list.ToList();
                    Walk_to_next_node(b, paths_from_to_length[i, 1], paths_from_to_length[i, 2], c);
                }
            }
        }

        private double[] Nearest_neibhior(List<double> l, double t)//return index
        {
            double index = 0;
            double min = 100;
            double[] dis = new double[(l.Count)];
            for (int i = 0; i < l.Count; i++)
            {
                dis[i] = Math.Abs(l[i] - t);
                if (dis[i] < min)
                {
                    min = dis[i];
                    index = i;
                }
            }


            double[] r = new double[2];
            r[0] = index;
            r[1] = min;
            return r;
        }

        private Graphics Draw_boundary(Rectangle r)
        {
            Graphics g = Panel_nodes.CreateGraphics();
            Pen pn = new Pen(Color.Black, 5);
            g.DrawRectangle(pn, r);
            return g;
        }
        private Graphics Draw_temp_line(int[] From_XY_index, int[] To_Cursor_Location, int Path_length)
        {
            Graphics g = Panel_nodes.CreateGraphics();
            //original 
            int From_X = Convert.ToInt32(Math.Floor(Panel_nodes.Width * X_location_of_nodes_new[From_XY_index[0]]));
            int From_Y = Convert.ToInt32(Math.Floor(Panel_nodes.Height * Y_location_of_nodes_new[From_XY_index[1]]));
            //int To_X = Convert.ToInt32(Math.Floor(Panel_nodes.Width * X_location_of_nodes_new[TO_XY_index[0]]));
            //int To_Y = Convert.ToInt32(Math.Floor(Panel_nodes.Height * Y_location_of_nodes_new[TO_XY_index[1]]));

            Point From = new Point(From_X, From_Y+ToolStrip_creat.Height);
            Point To = new Point(To_Cursor_Location[0], To_Cursor_Location[1] + ToolStrip_creat.Height);

            Font ft = new Font("Arial", 15);
            Pen pn = new Pen(Color.Black, 5);
            pn.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//set arrow
            g.DrawLine(pn, From, To);//draw line

            return g;
        }
        private Graphics Draw_line(int from, int to, int Path_length)
        {

            Graphics g = Panel_nodes.CreateGraphics();
            //original 
            double From_X = Panel_nodes.Width * location_of_nodes[from, 0];
            double From_Y = Panel_nodes.Height * location_of_nodes[from, 1];
            double To_X = Panel_nodes.Width * location_of_nodes[to, 0];
            double To_Y = Panel_nodes.Height * location_of_nodes[to, 1];

            double Length_X = To_X - From_X;
            double Length_Y = To_Y - From_Y;
            double ratio = (400 / (Length_X * Length_X + Length_Y * Length_Y));
            double Inner_Circle_To_X_Length = Math.Sqrt(Length_X * Length_X * ratio) + 5;
            double Inner_Circle_To_Y_Length = Math.Sqrt(Length_Y * Length_Y * ratio) + 5;
            Point From = new Point(Convert.ToInt32(From_X), Convert.ToInt32(From_Y) + ToolStrip_creat.Height);
            if (To_Y < From_Y)//higer
                Inner_Circle_To_Y_Length = -Inner_Circle_To_Y_Length;
            Point To_circle_edge = new Point(Convert.ToInt32(To_X - Inner_Circle_To_X_Length), Convert.ToInt32(To_Y - Inner_Circle_To_Y_Length) + ToolStrip_creat.Height);


            Rectangle r = new Rectangle(Convert.ToInt32(From_X + 0.5 * Length_X), Convert.ToInt32(From_Y + 0.5 * Length_Y), 100, 100);
            //Rectangle r = new Rectangle(Convert.ToInt32( From_X +0.5* Length_X), Convert.ToInt32(From_Y + 0.5 * Length_Y),100,100);
            Font ft = new Font("Arial", 15);
            Pen pn = new Pen(Color.Black, 5);
            pn.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//set arrow
            g.DrawLine(pn, From, To_circle_edge);//draw line

            g.DrawString((Path_length).ToString(), ft, Brushes.Red, r);//draw string
            ;

            return g;
        }
        private Graphics Draw_New_line(int[] From_XY_index, int[] TO_XY_index, int Path_length)
        {

            Graphics g = Panel_nodes.CreateGraphics();
            //original 
            int From_X = Convert.ToInt32(Math.Floor(Panel_nodes.Width * X_location_of_nodes_new[From_XY_index[0]]));
            int From_Y = Convert.ToInt32(Math.Floor(Panel_nodes.Height * Y_location_of_nodes_new[From_XY_index[1]]));
            int To_X = Convert.ToInt32(Math.Floor(Panel_nodes.Width * X_location_of_nodes_new[TO_XY_index[0]]));
            int To_Y = Convert.ToInt32(Math.Floor(Panel_nodes.Height * Y_location_of_nodes_new[TO_XY_index[1]]));

            Point From = new Point(From_X, From_Y + ToolStrip_creat.Height);
            Point To = new Point(To_X, To_Y+ToolStrip_creat.Height);
            int Length_X = To_X - From_X;
            int Length_Y = To_Y - From_Y;

            Rectangle r = new Rectangle(Convert.ToInt32(From_X + 0.5 * Length_X), Convert.ToInt32(From_Y + 0.5 * Length_Y), 100, 100);

            Font ft = new Font("Arial", 15);
            Pen pn = new Pen(Color.Black, 5);
            pn.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//set arrow
            g.DrawLine(pn, From, To);//draw line

            g.DrawString((Path_length).ToString(), ft, Brushes.Red, r);//draw string

            return g;
        }
        private Graphics Draw_circle(double x, double y, int node_NO)
        {
            int X = Convert.ToInt32(Math.Floor(Panel_nodes.Width * x));
            int Y = Convert.ToInt32(Math.Floor(Panel_nodes.Height * y));
            //MessageBox.Show(X.ToString()+ Y.ToString());
            Graphics g = Panel_nodes.CreateGraphics();
            Rectangle r = new Rectangle(X - circle_radius, Y - circle_radius+ToolStrip_creat.Height, 2 * circle_radius, 2 * circle_radius);

            StringFormat sr = new StringFormat();
            sr.Alignment = StringAlignment.Center;
            sr.LineAlignment = StringAlignment.Center;

            Font ft = new Font("Arial", 20);
            Pen pn = new Pen(Color.Black, 3);
            //g.DrawString()            
            g.FillEllipse(Brushes.White, r);
            g.DrawEllipse(pn, r);
            g.DrawString((node_NO + 1).ToString(), ft, Brushes.Black, r, sr);


            return g;
        }

        private void Panel_nodes_Paint(object sender, PaintEventArgs e)
        {
            Draw_boundary(e.ClipRectangle);
            if (TabControl_minor.SelectedTab != Creat_benchmark)
            {
                //Draw on Panel
                for (int i = 0; i < number_of_pahts; i++)
                {
                    int From = paths_from_to_length[i, 0];
                    int To = paths_from_to_length[i, 1];
                    int Length = paths_from_to_length[i, 2];
                    Draw_line(From, To, Length);
                }
                for (int i = 0; i < number_of_nodes; i++)
                {
                    Draw_circle(location_of_nodes[i, 0], location_of_nodes[i, 1], i);
                }
            }

            if (TabControl_minor.SelectedTab == Creat_benchmark)
            {
                //Draw on Panel
                if (number_of_pahts_new != 0)
                {
                    for (int i = 0; i < number_of_pahts_new; i++)
                    {
                        //paths_from_to_length_new
                        int[] From_XY = new int[2];
                        int[] To_XY = new int[2];
                        From_XY[0] = paths_from_to_length_new[i].First();
                        From_XY[1] = paths_from_to_length_new[i].First();
                        To_XY[0] = paths_from_to_length_new[i].Last();
                        To_XY[1] = paths_from_to_length_new[i].Last();

                        Draw_New_line(From_XY, To_XY, 10);
                    }
                }


                for (int i = 0; i < number_of_nodes_new; i++)
                {
                    Draw_circle(X_location_of_nodes_new[i], Y_location_of_nodes_new[i], i);
                }
            }
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == Random_Matrix)
                TextBox_Replications.Text = "2000000";
            else
                TextBox_Replications.Text = "10000";
        }

        private void TabControl_minor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStrip_creat.Enabled = true;
            if (TabControl_minor.SelectedTab == Creat_benchmark)
            {
                ToolStrip_creat.Enabled = true;
            }
            else
            {
                ToolStrip_creat.Enabled = false;
            }
        }
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            GC_RichTextBox_Result.Text = "";
            HG_RichTextBox_Result.Text = "";
            RM_RichTextBox_Result.Text = "";
            RM_RichTextBox_Result.Text = "Probability of Positive Determinant :\n";
            GC_RichTextBox_Result.Text = "Probability of Winning the Craps Game :\n";
            HG_RichTextBox_Result.Text = "Probability of All Hats Returned Wrong :\n";

        }
        private void RM_Button_Simulate_Click(object sender, EventArgs e)
        {
            long[,] test_matrix;
            int seed = -1;
            long D = 0;
            double Number_of_D_Positive = 0;
            for (int epoch = 0; epoch < Convert.ToInt32(TextBox_Replications.Text); epoch++)
            {
                //randomize the matrix


                test_matrix = new long[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var tuple = Rand_Number(0, 100000, seed);
                        test_matrix[i, j] = tuple.Item1;
                        seed = tuple.Item2;
                    }

                }
                //calculate the determind
                D = (test_matrix[0, 0] * test_matrix[1, 1] * test_matrix[2, 2]) -
                    (test_matrix[0, 1] * test_matrix[1, 2] * test_matrix[2, 0]) -
                    (test_matrix[0, 2] * test_matrix[1, 0] * test_matrix[2, 1]) -

                    (test_matrix[2, 0] * test_matrix[1, 1] * test_matrix[0, 2]) -
                    (test_matrix[2, 1] * test_matrix[1, 2] * test_matrix[0, 0]) -
                    (test_matrix[2, 2] * test_matrix[1, 0] * test_matrix[0, 1]);
                if (D > 0)
                {
                    Number_of_D_Positive++;
                }
            }
            RM_RichTextBox_Result.Text += "Probability = (" + Number_of_D_Positive + "/" + TextBox_Replications.Text + ") = ";
            RM_RichTextBox_Result.Text += (Number_of_D_Positive / Convert.ToDouble(TextBox_Replications.Text)).ToString() + "\n";
        }

        private void GC_Button_Simulate_Click(object sender, EventArgs e)
        {
            bool is_player_win;
            int two_dice_sum;
            int Point;
            int seed = -1;
            int dice_one;
            int dice_two;
            double Number_of_Player_wins = 0;
            for (int epoch = 0; epoch < Convert.ToInt32(TextBox_Replications.Text); epoch++)
            {
                //randomize two dice sum
                var tuple = Rand_Number(1, 7, seed);
                dice_one = tuple.Item1;
                seed = tuple.Item2;

                tuple = Rand_Number(1, 7, seed);
                dice_two = tuple.Item1;
                seed = tuple.Item2;

                two_dice_sum = dice_one + dice_two;

                //win in the first round
                if (two_dice_sum == 7 || two_dice_sum == 11)
                    is_player_win = true;
                //lose in the first round
                else if (two_dice_sum == 2 || two_dice_sum == 3 || two_dice_sum == 12)
                    is_player_win = false;
                //up to round 3,4,5....
                else
                {
                    Point = two_dice_sum;
                    do
                    {
                        tuple = Rand_Number(1, 7, seed);
                        dice_one = tuple.Item1;
                        seed = tuple.Item2;

                        tuple = Rand_Number(1, 7, seed);
                        dice_two = tuple.Item1;
                        seed = tuple.Item2;

                        two_dice_sum = dice_one + dice_two;
                        if (two_dice_sum == 7)
                        {
                            is_player_win = false;
                            break;
                        }
                        else if (two_dice_sum == Point)
                        {
                            is_player_win = true;
                            break;
                        }
                    } while (true);
                }

                if (is_player_win == true)
                {
                    Number_of_Player_wins++;
                }
            }
            GC_RichTextBox_Result.Text += "Probability = (" + Number_of_Player_wins + "/" + TextBox_Replications.Text + ") = ";
            GC_RichTextBox_Result.Text += (Round_up(Number_of_Player_wins / Convert.ToDouble(TextBox_Replications.Text), 4)).ToString() + "\n";
        }

        private void HG_Button_Simulate_Click(object sender, EventArgs e)
        {
            //customer array
            int Number_of_Customers = Convert.ToInt32(HG_TextBox_NumberOfCustomers.Text);
            int[] customer_seq = new int[Number_of_Customers];
            double Times_of_all_Hats_Wrong = 0;
            for (int i = 0; i < Number_of_Customers; i++)
            {
                customer_seq[i] = i;
            }
            Times_of_all_Hats_Wrong = Shuffle_and_Check(customer_seq, Number_of_Customers, Convert.ToInt32(TextBox_Replications.Text));
            HG_RichTextBox_Result.Text += "Probability = (" + Times_of_all_Hats_Wrong + "/" + TextBox_Replications.Text + ") = ";
            HG_RichTextBox_Result.Text += (Round_up(Times_of_all_Hats_Wrong / Convert.ToDouble(TextBox_Replications.Text), 4)).ToString() + "\n";
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            All_paths_Lengthes.Clear();
            All_paths.Clear();
            All_paths_time.Clear();



            SAN_Button_Simulate.Enabled = true;
            string[] tmp;
            char[] seps = { ' ', ',', '@' };//分割子
            //clean panel
            Graphics c = Panel_nodes.CreateGraphics();
            c.Clear(Panel_nodes.BackColor);

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Label_read_file.Text = "File name:\n" + Path.GetFileName(OpenFileDialog.FileName);
                RichTextBox_Benchmark.Text = "";

                StreamReader sr = new StreamReader(OpenFileDialog.FileName);
                number_of_nodes = Convert.ToInt32(sr.ReadLine());
                location_of_nodes = new double[number_of_nodes, 2];


                for (int i = 0; i < number_of_nodes; i++)
                {
                    tmp = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    location_of_nodes[i, 0] = Convert.ToDouble(tmp[0]);
                    location_of_nodes[i, 1] = Convert.ToDouble(tmp[1]);
                }

                number_of_pahts = Convert.ToInt32(sr.ReadLine());
                paths_from_to_length = new int[number_of_pahts, 3];
                for (int i = 0; i < number_of_pahts; i++)
                {
                    tmp = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    paths_from_to_length[i, 0] = Convert.ToInt32(tmp[0]);
                    paths_from_to_length[i, 1] = Convert.ToInt32(tmp[1]);
                    paths_from_to_length[i, 2] = Convert.ToInt32(tmp[2]);
                }
                sr.Close();

                //print out on RichBoxText
                RichTextBox_Benchmark.Text += number_of_nodes.ToString() + "\n";
                for (int i = 0; i < number_of_nodes; i++)
                {
                    RichTextBox_Benchmark.Text += location_of_nodes[i, 0].ToString() + " " + location_of_nodes[i, 1].ToString() + "\n";

                }
                RichTextBox_Benchmark.Text += number_of_pahts.ToString() + "\n";
                for (int i = 0; i < number_of_pahts; i++)
                {
                    RichTextBox_Benchmark.Text += paths_from_to_length[i, 0].ToString() + " " + paths_from_to_length[i, 1].ToString() + " " + paths_from_to_length[i, 2].ToString() + "\n";
                }

                //Draw on Panel
                for (int i = 0; i < number_of_pahts; i++)
                {
                    int From = paths_from_to_length[i, 0];
                    int To = paths_from_to_length[i, 1];
                    int Length = paths_from_to_length[i, 2];
                    Draw_line(From, To, Length);
                }
                for (int i = 0; i < number_of_nodes; i++)
                {
                    Draw_circle(location_of_nodes[i, 0], location_of_nodes[i, 1], i);
                }

            }

            // path finder
            List<int> l = new List<int>();
            List<int> L = new List<int>();
            Walk_to_next_node(l, 0, 0, L);
            //print out result
            RichTextBox_Benchmark.Text += "\nProssible Paths:\n";
            for (int i = 0; i < All_paths.Count; i++)//mulitple pathes
            {
                //RichTextBox_Benchmark.Text += "\n";
                for (int j = 0; j < All_paths[i].Count; j++)//single path
                {
                    if (j == All_paths[i].Count - 1)//at line end                   
                        RichTextBox_Benchmark.Text += (All_paths[i][j] + 1).ToString() + "\n    Length = " + All_paths_Lengthes[i].Sum().ToString() + "\n";
                    else//at line middle                   
                        RichTextBox_Benchmark.Text += (All_paths[i][j] + 1).ToString() + " -> ";
                }
            }
        }

        
        private void SAN_Button_Simulate_Click(object sender, EventArgs e)
        {
            int Number_of_path = All_paths.Count();

            int seed = Convert.ToInt32(ComboBox_Seed.Text);
            RichTextBox_result.Text = "";

            double[] Number_of_critical_path = new double[Number_of_path];
            double[] completion_time_array = new double[Convert.ToInt32(TextBox_Replications.Text)];
            for (int i = 0; i < Number_of_path; i++)
            {
                Number_of_critical_path[i] = 0;
            }
            for (int i = 0; i < Convert.ToInt32(TextBox_Replications.Text); i++)
            {
                for (int j = 0; j < Number_of_path; j++)
                {
                    var tuple = Rand_Number(0, 100, seed);
                    double ratio=1;
                    double time_temp = 0;

                    
                    for (int length_Count = 1; length_Count < All_paths_Lengthes[j].Count; length_Count++)
                    {
                        ratio = ratio*(Convert.ToDouble(tuple.Item1) / 100);
                        seed = tuple.Item2;
                        time_temp += All_paths_Lengthes[j][length_Count] * ratio;
                    }

                    All_paths_time.Add(time_temp);
                    completion_time_array[i] = All_paths_time.Max();
                }
                Number_of_critical_path[All_paths_time.IndexOf(All_paths_time.Max())]++;
                All_paths_time.Clear();
            }
            RichTextBox_result.Text += "Simulation Result :\n";
            RichTextBox_result.Text += "Mean Completion Time :\n";
            RichTextBox_result.Text += completion_time_array.Average() + "\n";
            RichTextBox_result.Text += "Probability of Critical Path :\n";

            for (int i = 0; i < Number_of_critical_path.Count(); i++)
            {
                //RichTextBox_result.Text += "\n";
                for (int j = 0; j < All_paths[i].Count; j++)//single path
                {
                    if (j == All_paths[i].Count)//at line end                   
                        RichTextBox_result.Text += (All_paths[i][j] + 1).ToString();
                    else//at line middle                   
                        RichTextBox_result.Text += (All_paths[i][j] + 1).ToString() + " -> ";
                }

                RichTextBox_result.Text += "Prob = ";
                RichTextBox_result.Text += (Number_of_critical_path[i] / Convert.ToDouble(TextBox_Replications.Text)).ToString() + "\n";
            }
        }

        private void Button_Clear_Data_Click(object sender, EventArgs e)
        {
            //clean panel
            Graphics c = Panel_nodes.CreateGraphics();
            c.Clear(Panel_nodes.BackColor);

            //Pen pn = new Pen(Color.Transparent, 5);
            //Graphics g = Panel_nodes.CreateGraphics();

            //clear variable
            number_of_nodes_new = 0;
            number_of_pahts_new = 0;
            X_location_of_nodes_new.Clear();
            Y_location_of_nodes_new.Clear();
            nearest_X_End_index = 0;
            nearest_Y_End_index = 0;
            nearest_X_start_index = 0;
            nearest_Y_start_index = 0;

            paths_from_to_length_new.Clear();
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
            if (SaveFileDialog.FileName != "")
            {
                StreamWriter sw = new StreamWriter(SaveFileDialog.FileName + ".txt");

                sw.WriteLine(number_of_nodes_new);
                for (int i = 0; i < X_location_of_nodes_new.Count(); i++)
                {
                    sw.WriteLine(X_location_of_nodes_new[i].ToString() + " " + Y_location_of_nodes_new[i].ToString());

                }
                sw.WriteLine(number_of_pahts_new);

                for (int i = 0; i < paths_from_to_length_new.Count(); i++)
                {
                    sw.WriteLine(paths_from_to_length_new[i][0].ToString() + " " + paths_from_to_length_new[i][1].ToString() + " " + 10);
                }

                sw.Close();
                MessageBox.Show("Data saved!");
            }
        }
        private void ToolStrip_creat_nodes_Click(object sender, EventArgs e)
        {
            Panel_nodes.Cursor = NodeCursor;
        }

        private void ToolStrip_creat_normal_cursor_Click(object sender, EventArgs e)
        {
            Panel_nodes.Cursor = Cursors.Default;
        }

        private void ToolStrip_creat_paths_Click(object sender, EventArgs e)
        {
            Panel_nodes.Cursor = PathCrusor;
        }



        private void Panel_nodes_MouseDown(object sender, MouseEventArgs e)
        {

            if (Panel_nodes.Cursor == NodeCursor)
            {
                number_of_nodes_new++;

                Point New_node = Point.Empty;
                New_node.X = Convert.ToInt32((float)e.X / Panel_nodes.Width);
                New_node.Y = Convert.ToInt32((float)e.Y / Panel_nodes.Height);

                List<double> location = new List<double>();
                X_location_of_nodes_new.Add((float)e.X / Panel_nodes.Width);
                Y_location_of_nodes_new.Add((float)e.Y / Panel_nodes.Height);
                Draw_circle(X_location_of_nodes_new.Last(), Y_location_of_nodes_new.Last(), number_of_nodes_new - 1);
                //Panel_nodes.Refresh();
            }

            if (Panel_nodes.Cursor == PathCrusor)
            {
                whether_draw_TempLine = true;
                nearest_X_start_index = Convert.ToInt32( Nearest_neibhior(X_location_of_nodes_new, (float)e.X / Panel_nodes.Width)[0]);
                nearest_Y_start_index = Convert.ToInt32( Nearest_neibhior(Y_location_of_nodes_new, (float)e.Y / Panel_nodes.Height)[0]);
                if (nearest_X_start_index != nearest_Y_start_index)
                {
                    double dis_X = Math.Abs(((float)e.X / Panel_nodes.Width) - X_location_of_nodes_new[nearest_X_start_index]);
                    double dis_Y = Math.Abs(((float)e.Y / Panel_nodes.Height) - Y_location_of_nodes_new[nearest_Y_start_index]);

                    double dis_p1_X = Math.Abs(((float)e.X / Panel_nodes.Width) - X_location_of_nodes_new[nearest_X_start_index])
                        + Math.Abs(((float)e.Y / Panel_nodes.Height) - Y_location_of_nodes_new[nearest_X_start_index]);
                    double dis_p2_X = Math.Abs(((float)e.X / Panel_nodes.Width) - X_location_of_nodes_new[nearest_Y_start_index])
                        + Math.Abs(((float)e.Y / Panel_nodes.Height) - Y_location_of_nodes_new[nearest_Y_start_index]);

                    if (dis_p1_X > dis_p2_X)
                    {
                        nearest_X_start_index = nearest_Y_start_index;
                    }
                    else
                    {
                        nearest_Y_start_index = nearest_X_start_index;
                    }
                }
                //Draw_circle((float)e.X / Panel_nodes.Width, (float)e.Y / Panel_nodes.Height, number_of_nodes_new - 1);
                //Panel_nodes.Refresh();
            }
        }

        private void Panel_nodes_MouseMove(object sender, MouseEventArgs e)
        {
            Panel_nodes.Refresh();
            //draw temp line
            if (Panel_nodes.Cursor == PathCrusor && whether_draw_TempLine == true)
            {
                nearest_X_End_index = Convert.ToInt32( Nearest_neibhior(X_location_of_nodes_new, (float)e.X / Panel_nodes.Width)[0]);
                nearest_Y_End_index = Convert.ToInt32(Nearest_neibhior(Y_location_of_nodes_new, (float)e.Y / Panel_nodes.Height)[0]);
                int[] From_XY = new int[2];
                int[] To_XY = new int[2];

                From_XY[0] = nearest_X_start_index;
                From_XY[1] = nearest_Y_start_index;

                To_XY[0] = e.X;
                To_XY[1] = e.Y;


                Draw_temp_line(From_XY, To_XY, 10);

            }
        }

        private void Panel_nodes_MouseUp(object sender, MouseEventArgs e)
        {
            if (Panel_nodes.Cursor == PathCrusor)
            {
                whether_draw_TempLine = false;
                number_of_pahts_new++;

                nearest_X_End_index = Convert.ToInt32( Nearest_neibhior(X_location_of_nodes_new, (float)e.X / Panel_nodes.Width)[0]);
                nearest_Y_End_index = Convert.ToInt32(Nearest_neibhior(Y_location_of_nodes_new, (float)e.Y / Panel_nodes.Height)[0]);
                if (nearest_X_End_index != nearest_Y_End_index)
                {
                    double dis_X = Math.Abs(((float)e.X / Panel_nodes.Width) - X_location_of_nodes_new[nearest_X_start_index]);
                    double dis_Y = Math.Abs(((float)e.Y / Panel_nodes.Height) - Y_location_of_nodes_new[nearest_Y_start_index]);

                    double dis_p1_X = Math.Abs(((float)e.X / Panel_nodes.Width) - X_location_of_nodes_new[nearest_X_End_index])
                        + Math.Abs(((float)e.Y / Panel_nodes.Height) - Y_location_of_nodes_new[nearest_X_End_index]);
                    double dis_p2_X = Math.Abs(((float)e.X / Panel_nodes.Width) - X_location_of_nodes_new[nearest_Y_End_index])
                        + Math.Abs(((float)e.Y / Panel_nodes.Height) - Y_location_of_nodes_new[nearest_Y_End_index]);

                    if (dis_p1_X > dis_p2_X)
                    {
                        nearest_X_End_index = nearest_Y_End_index;
                    }
                    else
                    {
                        nearest_Y_End_index = nearest_X_End_index;
                    }
                }
                int[] From_XY = new int[2];
                int[] To_XY = new int[2];

                From_XY[0] = nearest_X_start_index;
                From_XY[1] = nearest_Y_start_index;

                To_XY[0] = nearest_X_End_index;
                To_XY[1] = nearest_Y_End_index;

                List<int> l = new List<int>();
                l.Add(nearest_X_start_index);
                l.Add(nearest_X_End_index);
                paths_from_to_length_new.Add(l);
                Draw_New_line(From_XY, To_XY, 10);
                //if (nearest_X_start_index != nearest_Y_start_index  )
                //{

                //    List<int> l = new List<int>();
                //    double x_dis = Nearest_neibhior(X_location_of_nodes_new, (float)e.X / Panel_nodes.Width)[1];
                //    double y_dis = Nearest_neibhior(Y_location_of_nodes_new, (float)e.Y / Panel_nodes.Height)[1];
                //    if (x_dis < y_dis)
                //    {
                //        To_XY[1] = Convert.ToInt32( Nearest_neibhior(X_location_of_nodes_new, (float)e.X / Panel_nodes.Width)[0]);
                //        l.Add(nearest_X_start_index);
                //        //l.Add(nearest_X_End_index);
                //        paths_from_to_length_new.Add(l);
                //        //Draw_New_line(From_XY, To_XY, 10);
                //    }
                //    else
                //    {
                //        To_XY[0] = Convert.ToInt32(Nearest_neibhior(Y_location_of_nodes_new, (float)e.Y / Panel_nodes.Width)[0]);
                //        l.Add(nearest_X_start_index);
                //        //l.Add(nearest_Y_End_index);
                //        paths_from_to_length_new.Add(l);
                //        //Draw_New_line(From_XY, To_XY, 10);
                //    }

                //}
                //else if(nearest_X_End_index != nearest_Y_End_index)
                //{
                //    List<int> l = new List<int>();
                //    double x_dis = Nearest_neibhior(X_location_of_nodes_new, (float)e.X / Panel_nodes.Width)[1];
                //    double y_dis = Nearest_neibhior(Y_location_of_nodes_new, (float)e.Y / Panel_nodes.Height)[1];
                //    if (x_dis < y_dis)
                //    {
                //        To_XY[1] = Convert.ToInt32(Nearest_neibhior(X_location_of_nodes_new, (float)e.X / Panel_nodes.Width)[0]);
                //        //l.Add(nearest_X_start_index);
                //        l.Add(nearest_X_End_index);
                //        paths_from_to_length_new.Add(l);
                //        Draw_New_line(From_XY, To_XY, 10);
                //    }
                //    else
                //    {
                //        To_XY[0] = Convert.ToInt32(Nearest_neibhior(Y_location_of_nodes_new, (float)e.Y / Panel_nodes.Width)[0]);
                //        //l.Add(nearest_X_start_index);
                //        l.Add(nearest_Y_End_index);
                //        paths_from_to_length_new.Add(l);
                //        Draw_New_line(From_XY, To_XY, 10);
                //    }
                //}
                //else
                //{
                //    List<int> l = new List<int>();
                //    l.Add(nearest_X_start_index);
                //    l.Add(nearest_X_End_index);
                //    paths_from_to_length_new.Add(l);
                //    Draw_New_line(From_XY, To_XY, 10);
                //}



                for (int i = 0; i < number_of_nodes_new; i++)
                {
                    Draw_circle(X_location_of_nodes_new[i], Y_location_of_nodes_new[i], i);
                }
            }
        }

        
    }

}
