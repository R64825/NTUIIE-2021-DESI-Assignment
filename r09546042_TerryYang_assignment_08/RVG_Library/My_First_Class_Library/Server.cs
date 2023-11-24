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
        static int insatnces_Count = 0;
        static Dictionary<Server_State, Color> gannt_Color; 

         static Server() 
        {
            gannt_Color = new Dictionary<Server_State, Color>();
            gannt_Color.Add(Server_State.Free, Color.Lime);
            gannt_Color.Add(Server_State.Busy, Color.Red);
            gannt_Color.Add(Server_State.Down, Color.Olive);
        }

        Clients client_Under_Service;
        List<Clients> client_In_Queue = new List<Clients>();

        List<TimedQueue> queues;
        int clients_Served_Count = 0;
        int sequence_ID;
        Series gantt_States;
        Series pie_States;
        Service_Node parent_Node;
        Server_State last_State;
        double last_Event_Time;
        RandomVariateGenerator serviece_Time_Genrator;
        Continuous_RVG_Type service_Time_Type = Continuous_RVG_Type.Uniform;

        public String Name { get; set; }
        public RandomVariateGenerator Serviece_Time_Genrator { get => serviece_Time_Genrator; set => serviece_Time_Genrator = value; }
        public Continuous_RVG_Type Service_Time_Type
        {
            get => service_Time_Type;
            set
            {
                if (service_Time_Type != value)
                {
                    service_Time_Type = value;
                    switch (service_Time_Type)
                    {
                        case Continuous_RVG_Type.Exponential:
                            serviece_Time_Genrator = new ExponenitalRVG(1,0,1);
                            break;
                        case Continuous_RVG_Type.Uniform:
                            serviece_Time_Genrator = new UniformRVG(0.5, 1.5);
                            break;
                        default:
                            break;
                    }
                }            
            }
        }

        public Service_Node Parent_Node { get => parent_Node; set => parent_Node = value; }
        public Series Pie_States { get => pie_States; set => pie_States = value; }
        public Series Gantt_States { get => gantt_States; set => gantt_States = value; }

        public void Reset()
        {
            client_Under_Service = null;
            clients_Served_Count = 0;
            gantt_States.Points.Clear();
            //DataPoint dp = new DataPoint();
            //dp.XValue = sequence_ID;
            //dp.YValues= new double[2] {0.0,0.0 };
            //gantt_States.Points.Add(dp);
            pie_States.Points[0].YValues[0] = 0.0;
            pie_States.Points[1].YValues[0] = 0.0;

            last_State = Server_State.Free; 
            last_Event_Time = 0.0;

        }
        public Server( Service_Node node= null)
        {
            parent_Node = node;
            sequence_ID = insatnces_Count;
            Name = $"Server{++insatnces_Count }";
            queues = new List<TimedQueue>();
            gantt_States = new Series();
            gantt_States.ChartType = SeriesChartType.RangeBar;
            //gantt_States.LegendText = Name;

            pie_States = new Series();
            pie_States.ChartType = SeriesChartType.Pie;
            // By default only 2 data points for free and busy states
            pie_States.Points.AddXY("Free",0.0);// points[0] --> free
            pie_States.Points[0].Color = Color.FromArgb(160,Color.Green);
            pie_States.Points.AddXY("Busy",0.0);// points[1] --> busy
            pie_States.Points[1].Color = Color.FromArgb(160, Color.Red);
            //pie_States.LegendText = Name;

            serviece_Time_Genrator = new UniformRVG(0.5, 1.5);
            Reset();
        }

        public void Connect_A_Queue(TimedQueue queue)
        {
            queues.Add(queue);
        }

        #region Public Of Interface Function
        public  void Start_Serving_A_Clent(double time,Clients client)
        {
            // adding gantt block
            DataPoint dp = new DataPoint();
            dp.XValue = 1;
            dp.YValues = new double[] { last_Event_Time,time };
            dp.Color = gannt_Color[last_State];
            gantt_States.Points.Add(dp);

            //if (client_In_Queue.Count == 0 )
            // add free time to pie series
            pie_States.Points[0].YValues[0] += (time - last_Event_Time);

            // changing state to busy
            last_Event_Time = time;
            last_State = Server_State.Busy;

            // set client 
            if (client_Under_Service == null)
                client_Under_Service = client;
            else
                client_In_Queue.Add(client);
            double service_Time = serviece_Time_Genrator.GenerateARealRandomNumber();

            // create service complete event
            Discrete_Event de = new Service_Complete_Event(this, time + service_Time);
            de.description = "complete";
            de.Add_To_Simulation_Engine();
            
        }

        public void Complete_Current_Service(double time) 
        {
            // add a gantt block
            DataPoint dp = new DataPoint();
            dp.XValue = 1;
            dp.YValues = new double[] { last_Event_Time, time };
            dp.Color = gannt_Color[last_State];
            gantt_States.Points.Add(dp);

            // add busy time to pie series
            pie_States.Points[1].YValues[0] += (time - last_Event_Time);

            // ask service node exit the client
            bool is_OK = parent_Node.Exit_A_Client(time, client_Under_Service);

            // we will add blocked state here later
            if (!is_OK)
            {
                last_Event_Time = time;
                last_State = Server_State.Blocked;
                return;
            }

            //ok
            // change state to free
            last_Event_Time = time;
            last_State = Server_State.Free;
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
            

            // check the longest queue
            TimedQueue target = null;
            int longest = -1;
            foreach (TimedQueue tq in queues)
            {
                if (tq.Current_Length>longest)
                {
                    longest = tq.Current_Length;
                    target = tq;
                }
            }
            if (target == null) return;
            Clients head =  target.Escort_A_Client(time);
            if (head == null) return;

            Start_Serving_A_Clent(time, head);
        }
        #endregion
    }
}