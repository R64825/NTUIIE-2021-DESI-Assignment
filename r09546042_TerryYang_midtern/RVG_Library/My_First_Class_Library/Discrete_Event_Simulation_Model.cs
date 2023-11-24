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
        #region Class-Scope items
        public static Discrete_Event_Simulation_Model Creat_A_SSQ_Model( string scenario)
        {
            if (scenario == "scenario_01")
            {
                list_Of_Queue = new List<TimedQueue>();

                //series
                list_Of_Server = new List<Server>();
                Server Server_01 = new Server("Exp", 3, 3, null,1); Server_01.index = 1;
                Server Server_02 = new Server("Exp", 1, 1, null,2); Server_02.index = 2;
                Server Server_03 = new Server("Exp", 2, 2, null,3); Server_03.index = 3;
                list_Of_Server.Add(Server_01);
                list_Of_Server.Add(Server_02);
                list_Of_Server.Add(Server_03);

                Service_Node sn = new Service_Node(list_Of_Server, list_Of_Queue);
                List<Service_Node> nodes = new List<Service_Node>();
                nodes.Add(sn);

                List<Service_Node>[] itineraries = new List<Service_Node>[] { new List<Service_Node>() };
                itineraries[0].Add(sn);
                double[] p = new double[] { 100 };

                TimedQueue a_Queue = new TimedQueue(sn, 1);
                list_Of_Queue.Add(a_Queue);

                a_Queue.parent_Node = sn;
                Server_01.Parent_Node = sn;
                Server_01.Connect_A_Queue(a_Queue);
                Server_02.Parent_Node = sn;
                Server_02.Connect_A_Queue(a_Queue);
                Server_03.Parent_Node = sn;
                Server_03.Connect_A_Queue(a_Queue);
                


                return new Discrete_Event_Simulation_Model(nodes, itineraries, p);
            }
            else
            {
                list_Of_Queue = new List<TimedQueue>();

                //series
                list_Of_Server = new List<Server>();
                Server Server_01 = new Server("Uni", 4, 1, null,1); Server_01.index = 1;
                Server Server_02 = new Server("Uni", 5, 2, null,2); Server_02.index = 2;
                //Server Server_03 = new Server(10, 9, null); Server_02.index = 2;
                list_Of_Server.Add(Server_01);
                list_Of_Server.Add(Server_02);
                //list_Of_Server.Add(Server_03);

                Service_Node sn = new Service_Node(list_Of_Server, list_Of_Queue);
                List<Service_Node> nodes = new List<Service_Node>();
                nodes.Add(sn);

                List<Service_Node>[] itineraries = new List<Service_Node>[] { new List<Service_Node>() };
                itineraries[0].Add(sn);
                double[] p = new double[] { 100 };

                TimedQueue Queue_01 = new TimedQueue(sn, 1);
                list_Of_Queue.Add(Queue_01);
                TimedQueue Queue_02 = new TimedQueue(sn, 2);
                list_Of_Queue.Add(Queue_02);

                Server_01.Parent_Node = sn;
                Server_01.Connect_A_Queue(Queue_01);

                Server_02.Parent_Node = sn;
                Server_02.Connect_A_Queue(Queue_02);
                Queue_02.parent_Node = sn;
                return new Discrete_Event_Simulation_Model(nodes, itineraries, p);
            }
            
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
        List<Service_Node> nodes = new List<Service_Node>();
        List<Service_Node>[] itineraries;

        Client_Generator client_Generator;
        Server server;
        TimedQueue queue;

        Discrete_Event_Simulation_Engine simulation_Engine;


        #region Properties
        public double Simulation_Clock { get => simulation_Engine.Simulation_Clock; }
        public Client_Generator Client_Generator { get => client_Generator;}
        public Discrete_Event_Simulation_Engine Simulation_Engine { get => simulation_Engine;}


        #endregion
        public Discrete_Event_Simulation_Model(List<Service_Node> nodes,  List<Service_Node>[] itineraries, double[] probabilities)
        {
            this.nodes = nodes;
            this.itineraries = itineraries;
            client_Generator = new Client_Generator(itineraries, probabilities);
            //client_Generator.number_Of_Clients = number_Of_Clients;

            server = new Server("",1,0,null,0);
            queue = new TimedQueue(null, 0);
            simulation_Engine = new Discrete_Event_Simulation_Engine(list_Of_Server, list_Of_Queue);
        }

        public string Get_Description()
        {
            string str = "";
            str += "***** Processing Result *****\n";
            str += simulation_Engine.Get_Description();
            str += "***** End Result *****\n";
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