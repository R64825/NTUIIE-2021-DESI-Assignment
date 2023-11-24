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
        //static int number_Of_Clients=500;
        #region Class-Scope items
        public static Discrete_Event_Simulation_Model Creat_A_SSQ_Model()
        {
            list_Of_Server = new List<Server>();
            Server a_Server = new Server();
            list_Of_Server.Add(a_Server);

            list_Of_Queue = new List<TimedQueue>();
            TimedQueue a_Queue = new TimedQueue();
            list_Of_Queue.Add(a_Queue);


            Service_Node sn = new Service_Node(list_Of_Server, list_Of_Queue) ;
            a_Server.Parent_Node = sn;
            a_Server.Connect_A_Queue(a_Queue);

            List<Service_Node> nodes = new List<Service_Node>();
            nodes.Add(sn);

            List<Service_Node>[] itineraries = new List<Service_Node>[] { new List<Service_Node>()};
            itineraries[0].Add(sn);
            double[] p = new double[] { 100 }; 


            return new Discrete_Event_Simulation_Model(nodes, itineraries,p);
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
            server = new Server();
            queue = new TimedQueue();
            simulation_Engine = new Discrete_Event_Simulation_Engine();
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