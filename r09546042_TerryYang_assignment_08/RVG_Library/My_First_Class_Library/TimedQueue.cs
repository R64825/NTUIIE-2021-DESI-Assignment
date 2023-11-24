using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Random_Variate_Generator_Library
{
    public class TimedQueue
    {
        static int instance_Count = 0;
        string name;

        Queue<Clients> the_Queue = new Queue<Clients>();
        int capacity = int.MaxValue;
        Series series_Clients = new Series();
        int max_Count = 0;
        int client_Pass = 0;
        int clien_Exit = 0;

        double run_Time_Mean = 0;
        double run_Time_Square = 0;
        double run_Time_Count_Mean = 0;
        double run_Time_Count_Square = 0;

        public TimedQueue()
        {
            Name = $"Queue{++instance_Count}";
            series_Clients.ChartType = SeriesChartType.StepLine;
            series_Clients.Color = Color.Red;
            series_Clients.LegendText = Name;
        }


        public void Reset()
        {
            the_Queue.Clear();
            series_Clients.Points.Clear();
            max_Count = 0;
            client_Pass = 0;
            clien_Exit = 0;

            double run_Time_Mean = 0;
            double run_Time_Square = 0;
            double run_Time_Count_Mean = 0;
            double run_Time_Count_Square = 0;

            series_Clients.Points.AddXY(0, 0);
        }
        public int Capacity 
        { 
            get => capacity;
            set 
            {
                if (value != capacity && value >0)
                    capacity = value;
            }  
        }

        public double Time_Average_Length
        {
            get
                { return 0; }
        }

        public int Max_Count { get => max_Count;}

        [Browsable(false)]
        public Series Series_Clients { get => series_Clients;}
        public string Name { get; set; }

        public int Current_Length
        { get => the_Queue.Count; }


        public bool Add_A_Client(double time, Clients the_Client)
        {
            //client_Pass++;
            if (the_Queue.Count >= capacity) return false;

            the_Queue.Enqueue(the_Client);
            if (the_Queue.Count > max_Count) max_Count = the_Queue.Count;
            series_Clients.Points.AddXY(time, the_Queue.Count);

            return true;
        }

        public virtual Clients Escort_A_Client(double time)
        {
            if (the_Queue.Count == 0) return null;

            clien_Exit++;
            Clients target = the_Queue.Dequeue();
            series_Clients.Points.AddXY(time, the_Queue.Count);
            return target;
        }
    }
}