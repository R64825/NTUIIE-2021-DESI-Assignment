using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using My_First_Class_Library;

namespace Random_Variate_Generator_Library
{
    public class Discrete_Event_Simulation_Engine
    {
        // event time sorted in increasing order
        List<Discrete_Event> future_Event_List = new List<Discrete_Event>();
        double simulation_Clock;
        public int current_Client_In_Node=0;
        public int previous_Client_In_Node = 0;
        public double last_Event_Time;

        static public gannt gannt_Chart = new gannt();
        static public pie pie_Chart = new pie();
        static public step_line step_line_Chart = new step_line();

        public double Simulation_Clock { get => simulation_Clock;}

        public Discrete_Event_Simulation_Engine()
        {
            Discrete_Event.Set_Engine(this);
            current_Client_In_Node = 0;
            previous_Client_In_Node = 0;
        }

        internal void Insert_An_Event(Discrete_Event an_Event)
        {
            int position = 0;
            for (int i = 0; i < future_Event_List.Count; i++)
            {
                // sort by incoming time
                if (an_Event.Event_Time <= future_Event_List[i].Event_Time)
                {
                    position = i;
                    future_Event_List.Insert(i, an_Event);
                    return;
                } 
            }

            // calculate current clients
            switch (an_Event.description)
            {
                case "arrival":
                    //current_Client_In_Node++;
                    future_Event_List.Add(an_Event);
                    break;
                case "complete":
                    if (current_Client_In_Node>0)
                    {
                        // urrent_Client_In_Node--;
                        future_Event_List.Add(an_Event);
                    }                   
                    break;
            }        
        }

        public void Reset()
        {
            future_Event_List.Clear();
            simulation_Clock = 0;

            //gannt_Chart.Reset();
            //pie_Chart.Reset();
        }

        public bool Run_Next_Event()
        {
            if (future_Event_List.Count == 0) return false;
            Discrete_Event head_Event = future_Event_List[0];
            future_Event_List.RemoveAt(0);
            simulation_Clock = head_Event.Event_Time;
            head_Event.Process_Event();

            //counting clients
            previous_Client_In_Node = current_Client_In_Node;
            if (head_Event.description == "arrival") current_Client_In_Node++;
            else if (current_Client_In_Node != 0) current_Client_In_Node--;
            //Plotting
            gannt_Chart.plot(current_Client_In_Node, previous_Client_In_Node, head_Event, last_Event_Time);
            pie_Chart.plot(current_Client_In_Node, previous_Client_In_Node, head_Event, last_Event_Time);
            step_line_Chart.plot(current_Client_In_Node, previous_Client_In_Node, head_Event, last_Event_Time);

            last_Event_Time = head_Event.Event_Time;
            return true;
        }

        public void Run_To_End()
        {
            do
            {
                Run_Next_Event();
            } while (future_Event_List.Count!=0);
        }

        public string Get_Description()
        {
            if (future_Event_List.Count == 0)
                return null;
            //future_Event_List[0];
            Discrete_Event de;
            de = future_Event_List[0];
            string str = "";
            switch (de.description)
            {
                case "arrival":
                    str = "Client Arrival" ;
                    break;
                case "complete":
                    str = "Service Complete";
                    break;
            }
            return (str + $" at clock {Simulation_Clock:0:00}");
        }

        public Series Get_Gantt()
        {
            return gannt_Chart.creat_series();
        }
        public Series Get_Pie()
        {
            return pie_Chart.creat_series();
        }
        public Series Get_Step_Line()
        {
            return step_line_Chart.creat_series();
        }
    }
}