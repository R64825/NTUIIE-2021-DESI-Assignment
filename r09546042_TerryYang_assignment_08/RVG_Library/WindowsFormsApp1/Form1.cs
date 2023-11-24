
using System;
using System.Linq;
using System.Windows.Forms;
using My_First_Class_Library;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RandomVariateGenerator RVG;
        ExponenitalRVG arrivalGenerate;
        UniformRVG UGenerate;
        GeometricDRVGenerator GeoGenerate;
        EquilikelyDRVGenerator EquGenerate;
        public Form1()
        {
            InitializeComponent();
            arrivalGenerate = new ExponenitalRVG(5);
            arrivalGenerate.SetSeed(5);

            UGenerate = new UniformRVG(0, 1);
            UGenerate.SetSeed(5);

            GeoGenerate = new GeometricDRVGenerator(0.5);
            GeoGenerate.SetSeed(5);

            EquGenerate = new EquilikelyDRVGenerator(1,6);
            EquGenerate.SetSeed(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double m = Convert.ToDouble( textBox1.Text);
            arrivalGenerate.SetSeed(50);

            arrivalGenerate = new ExponenitalRVG(m);
            //propertyGrid1.SelectedObject = arrivalGenerate.TheoreticMean;

            double[] v = new double[200];

            for (int i = 0; i < 200; i++)
            {
                v[i] = arrivalGenerate.GenerateARealRandomNumber();
                richTextBox1.AppendText( 
                    $"{i}={v[i]}\r\n");
            }
            richTextBox1.AppendText($"{ v.Average() }");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            arrivalGenerate = new ExponenitalRVG(m);
            richTextBox1.AppendText($"after {10000} replication, \nthe mean = {arrivalGenerate.ReplicationVerficationForMean(10000)}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            UGenerate = new UniformRVG(0, 1);
            //propertyGrid1.SelectedObject = UGenerate.TheoreticMean;

            double[] v = new double[200];

            for (int i = 0; i < 200; i++)
            {
                v[i] = UGenerate.GenerateARealRandomNumber();
                richTextBox1.AppendText(
                    $"{i}={v[i]}\r\n");
            }
            richTextBox1.AppendText($"{ v.Average() }");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += Convert.ToString(UGenerate.GenerateARealRandomNumber())+"\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GeoGenerate = new GeometricDRVGenerator(0.9);
            GeoGenerate.SetSeed(5);
            double[] v = new double[200];

            for (int i = 0; i < 200; i++)
            {
                v[i] = GeoGenerate.GenerateARealRandomNumber();
                richTextBox1.AppendText(
                    $"{v[i]}\r\n");
            }
            richTextBox1.AppendText($"{ v.Average() }");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EquGenerate = new EquilikelyDRVGenerator(1,6);
            EquGenerate.SetSeed(5);
            double[] v = new double[200];

            for (int i = 0; i < 200; i++)
            {
                v[i] = EquGenerate.GenerateARealRandomNumber();
                richTextBox1.AppendText(
                    $"{v[i]}\r\n");
            }
            richTextBox1.AppendText($"{ v.Average() }");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            arrivalGenerate = new ExponenitalRVG(5); ;
            UGenerate = new UniformRVG(0, 1);
            GeoGenerate = new GeometricDRVGenerator(0.9);
            EquGenerate = new EquilikelyDRVGenerator(1, 6);
            propertyGrid1.SelectedObject = UGenerate;


        }
    }
}
