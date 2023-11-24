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
        Series client_Count_Series;
        
        int current_Clients_Count;
        int exited_Clients_Count;

        public void Reset()
        {
            client_Count_Series.Points.Clear();
            client_Count_Series.Points.AddXY(0, 0);
            foreach (Server s in servers) s.Reset();
            foreach (TimedQueue tq in queues) tq.Reset();

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
            TimedQueue my_Queue = null;
            //...
            free_Server = servers[0];//need fix
            my_Queue = queues[0];
            if (free_Server!=null)
            {
                free_Server.Start_Serving_A_Clent(time, client);
                my_Queue.Add_A_Client(time, client);

                current_Clients_Count++;
                client_Count_Series.Points.AddXY(time, current_Clients_Count);
                return true;//if no free server, queue up
            }

            // find a shortest queue to queue the client
            TimedQueue shortest_Queue = null;
            //...?
            shortest_Queue = queues[0];// need fix
            bool is_Ok = shortest_Queue.Add_A_Client(time, client);
            if (is_Ok)
            {
                current_Clients_Count++;
                client_Count_Series.Points.AddXY(time, current_Clients_Count);
                return true;
            }
            //shortest_Queue.Add_A_Client(time, client);

            return false;//?
        }
        public bool Exit_A_Client(double time, Clients client)
        {
            // check whether the client has next service node to visit
            bool is_Client_Exit = client.Exit_A_Service_Node(time);
            if (!is_Client_Exit) return false;
            // teturn false;

            // exit the client
            current_Clients_Count--;
            client_Count_Series.Points.AddXY(0, current_Clients_Count);

            exited_Clients_Count++;

            return true;
            // let the client continue its itinerary
            //client.Exit_A_Service_Node(time);
        }
    }
}