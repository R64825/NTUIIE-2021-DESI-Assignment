using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using My_First_Class_Library;
using Random_Variate_Generator_Library;

namespace Random_Variate_Generator_Library
{
    public class Client_Arrival_Event : Discrete_Event
    {

        public override string ToString()
        {
            return $"Client {the_Client} Arrival Event at {event_Time}";
        }
        Clients the_Client;
        //Client_Generator the_Client_Generator;

        //public Client_Generator The_Client_Generator { get => the_Client_Generator;}

        public Client_Arrival_Event(Clients a_Client, double time)
        {          
            the_Client = a_Client;
            event_Time = time;
            //the_Client_Generator = a_Client_Generator;
        }

        public override void Process_Event()
        {
            the_Client.Enter_A_Service_Node(event_Time);
            the_Client_Generator.Generate_A_Client_Arrival(event_Time);// need fix 
        }
    }
}