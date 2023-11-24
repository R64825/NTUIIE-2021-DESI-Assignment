using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Random_Variate_Generator_Library
{
    public class Clients
    {
        double birth_Time;
        public double start_serve_Time;
        public double start_queue_Time;
        Series step_Line;
        TimedQueue my_Queue = new TimedQueue(null,0);

        Client_State current_State = Client_State.None;

        List<Service_Node> itinerary;
        int current_Itinerary = -1;


        public Clients(double birth_Time, List<Service_Node> itinerary)
        {
            this.itinerary = itinerary;
            this.birth_Time = birth_Time;
            step_Line = new Series();
            step_Line.ChartType = SeriesChartType.StepLine;
            //DataPoint dp = new DataPoint();
            
        }

        public Clients(double birth_Time)
        {
            this.birth_Time = birth_Time;
            step_Line = new Series();
            step_Line.ChartType = SeriesChartType.StepLine;
            //DataPoint dp = new DataPoint();

        }
        public void Enter_A_Service_Node(double event_time)
        {
            // update gantt
            current_Itinerary++;
            if (itinerary.Count <= current_Itinerary) return ;
            bool is_Ok = itinerary[current_Itinerary].Receive_A_Client(event_time, this);

            my_Queue.Add_A_Client(event_time, this);

        }
        public bool Exit_A_Service_Node(double time)
        {
            // checking whether there is a next node to visit
            // if this is the last node, update statistic and return ok

            //update gantt
            my_Queue.Escort_A_Client(time);
            return true;
            //throw new NotImplementedException();
        }

        public double Get_Queued_Time(double time)
        {                  
            return (start_queue_Time-time);          
        }

        public double Get_Served_Time(double time)
        {
            return (start_serve_Time - time);
        }
    }
}