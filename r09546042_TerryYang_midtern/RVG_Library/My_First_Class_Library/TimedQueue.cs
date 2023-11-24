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
        public int index=0;
        //static int instance_Count = 0;
        string name;

        public Queue<Clients> the_Queue = new Queue<Clients>();
        // int index = 0;
        int capacity = int.MaxValue;
        public Series series_Queue = new Series();
        public Service_Node parent_Node;
        int maximum_Clients_in_Queue = 0;
        int current_Clients_in_Queue = 0;
        int client_Queued = 0;
        int clien_Exit = 0;

        public TimedQueue(Service_Node node, int index)
        {
            if (node != null)
                this.parent_Node = node;

            this.index = index;
            Name = $"Queue_0{index}";
            series_Queue.ChartType = SeriesChartType.StepLine;
            series_Queue.Color = Color.Green;
            series_Queue.BorderWidth = 2;
            series_Queue.ChartArea = "ChartArea2";
            //series_Queue.LegendText = Name;
        }


        public void Reset()
        {
            the_Queue.Clear();
            series_Queue.Points.Clear();
            maximum_Clients_in_Queue = 0;
            client_Queued = 0;
            clien_Exit = 0;

            series_Queue.Points.AddXY(0, 0);
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

        public int Max_Count { get => maximum_Clients_in_Queue; }

        [Browsable(false)]
        public Series Series_Clients { get => series_Queue;}
        public string Name { get; set; }
        public int Current_Clients_in_Queue { get => current_Clients_in_Queue; set => current_Clients_in_Queue = value; }
        public int Client_Queued { get => client_Queued; set => client_Queued = value; }

        public bool Add_A_Client(double time, Clients the_Client)
        {
            //client_Pass++;
            if (the_Queue.Count >= capacity) return false;

            the_Queue.Enqueue(the_Client);
            current_Clients_in_Queue++;
            client_Queued++;
            return true;
        }

        public string Get__Description()
        {            
            return $"Queue_0{index }: have maximum {maximum_Clients_in_Queue} clients in this queue, and have queued {client_Queued} clients";
        }

        public virtual Clients Escort_A_Client(double time)
        {
            if (the_Queue.Count == 0) return null;

            clien_Exit++;
            Clients target = the_Queue.Dequeue();
            current_Clients_in_Queue--;
            //client_Pass++;
            return target;
        }

        public void Step_Line_Plotting(int queue_Index, double Time, double last_Event_Time)
        {
            int count = current_Clients_in_Queue;
            series_Queue.Points.AddXY(Time, count);
            if (maximum_Clients_in_Queue < count)
                maximum_Clients_in_Queue = count;
        }
    }
}