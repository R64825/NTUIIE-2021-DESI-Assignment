using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Random_Variate_Generator_Library
{
    
    public class Service_Node
    {
        List<Server> servers;
        List<TimedQueue> queues;
        public TimedQueue my_Queue = new TimedQueue(null,0);
        Series client_Count_Series;
        
        int current_Clients_Count=0;
        int exited_Clients_Count;

        double queued_Time_Sum = 0;
        double served_Time_Sum = 0;

        public void Reset()
        {
            client_Count_Series.Points.Clear();
            client_Count_Series.Points.AddXY(0, 0);

            if (servers!=null && queues!= null)
            {
                foreach (Server s in servers) s.Reset();
                foreach (TimedQueue tq in queues) tq.Reset();
            }
            

             current_Clients_Count=0;
             exited_Clients_Count=0;
        }
        public Service_Node()
        {
            servers = new List<Server>();
            queues = new List<TimedQueue>();

            Create_Client_Count_Series();
        }
        public Service_Node(List<Server> servers, List<TimedQueue> queues)
        {
            this.servers = servers;
            this.queues = queues;

            Create_Client_Count_Series();
        }

        void Create_Client_Count_Series()
        {
            client_Count_Series = new Series();
            client_Count_Series.ChartType = SeriesChartType.StepLine;
            client_Count_Series.Color = Color.Purple;

        }

        public bool Receive_A_Client(double time, Clients client)
        {
            // find a free server to serve the client
            Server free_Server = null;//need fix
            
            //...
            int free_Server_index = -1;
            for (int i = 0; i < servers.Count; i++)
            {
                if (servers[i].busy_Or_Not == false)// free server
                {
                    free_Server_index = i;                    
                    break;
                }               
            }

            if (free_Server_index == -1)// no free server
            {
                free_Server = null;
                TimedQueue shortest_Queue = Find_Shortest_Queue();
                shortest_Queue.Add_A_Client(time, client);
                client.start_queue_Time = time;
                //my_Queue.Add_A_Client(time, client);//test
            }
            else
            {
                free_Server = servers[free_Server_index];
            }
            
            //free_Server = servers[0];//need fix

            if (free_Server!=null)
            {
                client.start_serve_Time = time;
                // start serving
                if (servers[free_Server_index].queues[0].the_Queue.Count == 0)
                {                   
                    free_Server.Start_Serving_A_Clent(free_Server.index, time, client);
                }
                // queue up in line
                else
                {
                    free_Server.Start_Serving_A_Clent(free_Server.index, time, servers[free_Server_index].queues[0].Escort_A_Client(time));
                }
                queued_Time_Sum += client.Get_Queued_Time(time);

                current_Clients_Count++;
                client_Count_Series.Points.AddXY(time, current_Clients_Count);
                return true;//if no free server, queue up
            }

            return false;//?
            
        }

        public TimedQueue Find_Shortest_Queue()
        {
            //find a shortest queue to queue
            TimedQueue shortest_Queue = null;
            int shortest_Queue_Index = 0;
            List<int> tmp = new List<int>();
            for (int i = 0; i < queues.Count; i++)
            {
                tmp.Add(queues[i].Current_Clients_in_Queue);
            }
            shortest_Queue_Index = tmp.IndexOf(tmp.Min());
            shortest_Queue = queues[shortest_Queue_Index];
            return shortest_Queue;           
        }
        public bool Exit_A_Client(double time, Clients client)
        {
            // check whether the client has next service node to visit
            bool is_Client_Exit = client.Exit_A_Service_Node(time);
            if (!is_Client_Exit) return false;
            // teturn false;

            // exit the client
            served_Time_Sum+= client.Get_Served_Time(time);
            current_Clients_Count--;
            client_Count_Series.Points.AddXY(0, current_Clients_Count);
            exited_Clients_Count++;

            return true;
        }

        public string Get__Description()
        {
            return //$"Service Node{index } -> \n" +
                $"average queued time: {Math.Round(queued_Time_Sum / Convert.ToDouble(exited_Clients_Count), 2) } \n" +
                $"average served time: {Math.Round(served_Time_Sum / Convert.ToDouble(exited_Clients_Count), 2) } \n";
                //$"    average queue time: {}";
        }
    }
}