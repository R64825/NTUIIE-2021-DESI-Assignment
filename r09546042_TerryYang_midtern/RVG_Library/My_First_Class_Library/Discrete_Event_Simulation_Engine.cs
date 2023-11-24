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

        static public step_line step_line_Chart = new step_line();

        List<Server> list_Of_Server;
        List<TimedQueue> list_Of_Queue;
        public double Simulation_Clock { get => simulation_Clock;}

        public Discrete_Event_Simulation_Engine(List<Server> list_Of_Server, List<TimedQueue> list_Of_Queue)
        {
            Discrete_Event.Set_Engine(this);
            current_Client_In_Node = 0;
            previous_Client_In_Node = 0;

            this.list_Of_Server = list_Of_Server;
            this.list_Of_Queue = list_Of_Queue;
        }

        internal void Insert_An_Event(Discrete_Event an_Event)
        {
             future_Event_List.Add(an_Event);
            //sorting
            int position = 0;
            for (int i = 0; i < future_Event_List.Count; i++)
            {
                // sort by incoming time
                if (an_Event.Event_Time < future_Event_List[i].Event_Time)
                {
                    position = i;

                    future_Event_List.Insert(i, an_Event);
                    future_Event_List.RemoveAt(future_Event_List.Count-1);
                    return;
                }
            }
        }

        public void Reset()
        {
            //future_Event_List.Clear();
            simulation_Clock = 0;

            //gannt_Chart.Reset();
            //pie_Chart.Reset();
        }

        public bool Run_Next_Event()
        {           
            if (future_Event_List.Count == 0) return false;
            Discrete_Event head_Event = future_Event_List[0];

            // plotting gannt, pie
            for (int i = 0; i < list_Of_Server.Count; i++)
            {
                Server s;
                s = list_Of_Server[i];
                s.Gantt_Plotting(head_Event.Event_Time, last_Event_Time);
                s.Pie_Plotting(head_Event.Event_Time, last_Event_Time);
            }

            
            //counting clients, queue
            previous_Client_In_Node = current_Client_In_Node;
            if (head_Event.description == "arrival") current_Client_In_Node++;
            else if (current_Client_In_Node != 0) current_Client_In_Node--;
            step_line_Chart.plot(current_Client_In_Node, previous_Client_In_Node, head_Event, last_Event_Time);

            future_Event_List.RemoveAt(0);
            simulation_Clock = head_Event.Event_Time;
            head_Event.Process_Event();

            for (int i = 0; i < list_Of_Queue.Count; i++)
            {
                TimedQueue q;
                q = list_Of_Queue[i];
                q.Step_Line_Plotting(i, head_Event.Event_Time, last_Event_Time);
            }





            last_Event_Time = head_Event.Event_Time;
            return true;
        }

        public void Run_To_End()
        {
            do
            {
                Run_Next_Event();
            } while (future_Event_List.Count!=0 || simulation_Clock==0);
        }

        public string Get_Description()
        {
            string str = "";
            for (int i = 0; i < list_Of_Server.Count; i++)
            {
                str+=list_Of_Server[i].Get__Description();
                str += "\n";
            }
            str += "\n";
            for (int i = 0; i < list_Of_Queue.Count; i++)
            {
                str+=list_Of_Queue[i].Get__Description();
                str += "\n";
            }
            return str;
        }

        public Series Get_Step_Line()
        {
            return step_line_Chart.creat_series();
        }
    }
}