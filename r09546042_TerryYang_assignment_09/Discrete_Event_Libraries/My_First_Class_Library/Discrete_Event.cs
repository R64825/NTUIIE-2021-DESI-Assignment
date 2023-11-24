using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Variate_Generator_Library
{
    public class Discrete_Event
    {
        protected double event_Time;
        protected static Discrete_Event_Simulation_Engine the_Engine;
        protected static Client_Generator the_Client_Generator;
        public string description = "";
        public static void Set_Engine(Discrete_Event_Simulation_Engine engine)
        {
            the_Engine = engine;
        }

        public static void Set_Client_Generator(Client_Generator generator)
        {
            the_Client_Generator = generator;
        }

        public double Event_Time
        {
            get => event_Time;
        }



        public void Add_To_Simulation_Engine() 
        {
            
            the_Engine.Insert_An_Event(this);
        }
        public virtual void Process_Event()
        {
            throw new Exception("NO implement");
        }
    }
}