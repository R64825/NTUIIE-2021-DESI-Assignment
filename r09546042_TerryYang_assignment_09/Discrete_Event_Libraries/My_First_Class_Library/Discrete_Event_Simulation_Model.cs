using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Variate_Generator_Library
{
    public class Discrete_Event_Simulation_Model
    {
        static List<Server> list_Of_Server;
        static List<TimedQueue> list_Of_Queue;

        List<Service_Node> nodes = new List<Service_Node>();
        List<Service_Node>[] itineraries;

        static Client_Generator client_Generator;
        static Service_Node service_Node ;
        Server server;
        TimedQueue queue;

        Discrete_Event_Simulation_Engine simulation_Engine;

        double cease_Time;
        #region Class-Scope items
        public static Discrete_Event_Simulation_Model Creat_A_SSQ_Model( int Number_Of_Servers, double Cease_Time, bool Multiple_Queue)
        {
            list_Of_Queue = new List<TimedQueue>();
            //creating severs
            list_Of_Server = new List<Server>();

            service_Node = new Service_Node(list_Of_Server, list_Of_Queue);

            for (int i = 0; i < Number_Of_Servers; i++)
            {
                Server s = new Server("Exp", 3, 3, null, 1);               
                s.Name = $"Server_{ i +1}";
                s.index = i + 1;

                //list_Of_Server[i].parent_Node = sn

                list_Of_Server.Add(s);
            }

            //Service_Node sn = new Service_Node(list_Of_Server, list_Of_Queue);
            //service_Node = sn;
            List<Service_Node> nodes = new List<Service_Node>();
            nodes.Add(service_Node);

            List<Service_Node>[] itineraries = new List<Service_Node>[] { new List<Service_Node>() };
            itineraries[0].Add(service_Node);
            double[] p = new double[] { 100 };

            

            //adding severs into service node
            if (Multiple_Queue == true)
            {
                for (int i = 0; i < Number_Of_Servers; i++)
                {
                    TimedQueue q = new TimedQueue(service_Node, i+1);
                    q.Name = $"Queue_{ i + 1}";
                    q.index = i + 1;
                    q.parent_Node = service_Node;

                    list_Of_Queue.Add(q);

                    list_Of_Server[i].parent_Node = service_Node;
                    list_Of_Server[i].Connect_A_Queue(list_Of_Queue[i]);
                }
            }
            else
            {
                TimedQueue a_Queue = new TimedQueue(service_Node, 1);
                list_Of_Queue.Add(a_Queue);
                a_Queue.parent_Node = service_Node;

                for (int i = 0; i < Number_Of_Servers; i++)
                {                   
                    list_Of_Server[i].parent_Node = service_Node;
                    list_Of_Server[i].Connect_A_Queue(a_Queue);
                }
            }
                
                
            return new Discrete_Event_Simulation_Model(nodes, itineraries, p, Cease_Time);
            
        }

        public List<Server> Get_All_Servers()
        {
            return list_Of_Server;
        }

        public List<TimedQueue> Get_All_Queue()
        {
            return list_Of_Queue;
        }
        #endregion
        


        #region Properties
        public double Simulation_Clock { get => simulation_Engine.Simulation_Clock; }
        public Client_Generator Client_Generator { get => client_Generator;}
        public Discrete_Event_Simulation_Engine Simulation_Engine { get => simulation_Engine;}


        #endregion
        public Discrete_Event_Simulation_Model(List<Service_Node> nodes,  List<Service_Node>[] itineraries, double[] probabilities, double cease_Time)
        {
            this.cease_Time = cease_Time;
            this.nodes = nodes;
            this.itineraries = itineraries;
            client_Generator = new Client_Generator(itineraries, probabilities, cease_Time);
            
            //client_Generator.number_Of_Clients = number_Of_Clients;

            server = new Server("",1,0,null,0);
            queue = new TimedQueue(null, 0);
            simulation_Engine = new Discrete_Event_Simulation_Engine(list_Of_Server, list_Of_Queue, Client_Generator,service_Node);
        }

        public string Get_Description()
        {
            string str = "";
            str += "*** Processing Result ***\n";
            //str+="simulation ended in {}"
            str += simulation_Engine.Get_Description();
            str += "*** End Result ***\n";
            return str;
        }

        public void Reset_Simulation()
        {
            foreach (Service_Node sn in nodes) sn.Reset(); 
            simulation_Engine.Reset();
            client_Generator.Generate_A_Client_Arrival(simulation_Engine.Simulation_Clock);
        }

        public void Run_One_Event()
        {
            simulation_Engine.Run_Next_Event();
        }

        public void Run_All_Events()
        {
            simulation_Engine.Run_To_End();
        }

    }
}