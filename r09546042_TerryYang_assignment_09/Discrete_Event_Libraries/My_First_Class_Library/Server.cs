using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using My_First_Class_Library;

namespace Random_Variate_Generator_Library
{
    public class Server
    {
        //series
        public Series gantt_States;
        public Series pie_States;
        public int index;
        public double busy_Time=0;
        private int clents_severed = 0;

        double Service_Time_Sum=0;

        //static int insatnces_Count = 0;
        static Dictionary<Server_State, Color> gannt_Color;
        public bool busy_Or_Not = false;

        static Server()
        {
            gannt_Color = new Dictionary<Server_State, Color>();
            gannt_Color.Add(Server_State.Free, Color.Lime);
            gannt_Color.Add(Server_State.Busy, Color.Red);
            gannt_Color.Add(Server_State.Down, Color.Olive);
        }

        Clients client_Under_Service;
        List<Clients> client_In_Queue = new List<Clients>();
        TimedQueue my_queue;
        public List<TimedQueue> queues;
        //int clients_Served_Count = 0;
        //int sequence_ID;
        
        public Service_Node parent_Node;
        //Server_State last_State;
        double last_Event_Time;
        RandomVariateGenerator serviece_Time_Genrator;
        public String Name { get; set; }
        public RandomVariateGenerator Serviece_Time_Genrator { get => serviece_Time_Genrator; set => serviece_Time_Genrator = value; }
        private Continuous_RVG_Type service_Time_Type;       

        public int Clents_severed { get => clents_severed; set => clents_severed = value; }

        public Service_Node Parent_Node { get => parent_Node; set => parent_Node = value; }
        public Continuous_RVG_Type Service_Time_Type{ get => service_Time_Type; set => service_Time_Type = value; }

        public void Reset()
        {
            client_Under_Service = null;
            //clients_Served_Count = 0;
            gantt_States.Points.Clear();
            pie_States.Points[0].YValues[0] = 0.0;
            pie_States.Points[1].YValues[0] = 0.0;

            busy_Time = 0;
            //last_State = Server_State.Free; 
            last_Event_Time = 0.0;

        }
        public Server(string distribution,  double U, double L,Service_Node node, int index)
        {
            if (node != null)
            {
                parent_Node = node;
                my_queue = parent_Node.my_Queue;
            }//test

            this.index = index;
            Name = $"Server_0{index }";
            queues = new List<TimedQueue>();

            if (distribution == "Exp")
            {
                serviece_Time_Genrator = new ExponenitalRVG((L + U) / 2, L, U);
                Service_Time_Type = Continuous_RVG_Type.Exponential;
            }
            else if (distribution == "Uni")
            {
                serviece_Time_Genrator = new UniformRVG(L, U);
                Service_Time_Type = Continuous_RVG_Type.Uniform;
            }

                       
            //series
            gantt_States = new Series();
            gantt_States.ChartType = SeriesChartType.RangeBar;

            pie_States = new Series();
            pie_States.ChartType = SeriesChartType.Pie;
            pie_States.Points.AddXY("Free", 0.0);// points[0] --> free
            pie_States.Points[0].Color = Color.FromArgb(160, Color.Green);
            pie_States.Points.AddXY("Busy", 0.0);// points[1] --> busy
            pie_States.Points[1].Color = Color.FromArgb(160, Color.Red);

            Reset();
        }

        public void Connect_A_Queue(TimedQueue queue)
        {
            queues.Add(queue);
        }

        #region Public Of Interface Function
        public  void Start_Serving_A_Clent(int server_Index, double time,Clients client)
        {
            last_Event_Time = time;
            //last_State = Server_State.Busy;

            // set client 
            if (client_Under_Service == null)
                client_Under_Service = client;
            else
                client_In_Queue.Add(client);
            double service_Time = serviece_Time_Genrator.GenerateARealRandomNumber();

            // create service complete event
            Discrete_Event de = new Service_Complete_Event(this, time + service_Time);
            Service_Time_Sum += service_Time;
            de.description = "complete";
            de.Add_To_Simulation_Engine();

            this.Gantt_Plotting( time, last_Event_Time);
            this.Pie_Plotting(time, last_Event_Time);
            busy_Or_Not = true;

            clents_severed++;
        }

        public void Complete_Current_Service(int server_Index, double time) 
        {    
            //last_State = Server_State.Free;
            if (client_In_Queue.Count == 0)
                client_Under_Service = null;
            else
            {
                client_Under_Service = client_In_Queue[0];
                for (int i = 0; i < client_In_Queue.Count - 1; i++)
                {
                    client_In_Queue[i] = client_In_Queue[i + 1];
                }
                client_In_Queue.RemoveAt(client_In_Queue.Count-1);
            }
                      
            this.Gantt_Plotting( time, last_Event_Time);
            this.Pie_Plotting( time, last_Event_Time);
            busy_Time += (time - last_Event_Time);
            busy_Or_Not = false;


            if (queues[0].the_Queue.Count == 0)
            {
                return;
            }
            else
            {
                this.Start_Serving_A_Clent(this.index, time, queues[0].Escort_A_Client(time));
            } 

            last_Event_Time = time;
        }
        #endregion

        public string Get__Description()
        {
            double all_Time = pie_States.Points[0].YValues[0] +pie_States.Points[1].YValues[0];
            double busy_Time = pie_States.Points[1].YValues[0];

            double busy_Percentage = busy_Time / all_Time;
            Math.Round(busy_Percentage, 4);
            return $"Server_0{index } ->\n   serverd {clents_severed} clients,\n   busy ratio: {Math.Round( busy_Percentage, 1)},\n    average service time: {Math.Round(Service_Time_Sum/Convert.ToDouble( clents_severed),2)}\n";
        }
        public void Gantt_Plotting( double Time, double last_Event_Time)
        {
            DataPoint dp = new DataPoint();
            dp.AxisLabel = Name;
            dp.XValue = index;//server_Index-1;
            dp.YValues = new double[] { last_Event_Time, Time };
            if (busy_Or_Not == false)
            {
                dp.Color = Color.Green;
            }
            else
            {
                dp.Color = Color.Red;
            }
            gantt_States.Points.Add(dp);
        }
        public void Pie_Plotting(double Time, double last_Event_Time)
        {
            if (busy_Or_Not == false)
                // add free time to pie series
                pie_States.Points[0].YValues[0] += (Time - last_Event_Time);
            else
                // add busy time to pie series
                pie_States.Points[1].YValues[0] += (Time - last_Event_Time);
        }
    }
}