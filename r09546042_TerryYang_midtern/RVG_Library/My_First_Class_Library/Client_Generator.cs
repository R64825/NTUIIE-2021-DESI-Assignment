using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using My_First_Class_Library;
using Random_Variate_Generator_Library;

namespace Random_Variate_Generator_Library
{
    public class Client_Generator
    {
        Random randomizer = new Random();
        List<Service_Node>[] itineraries;
        double[] relative_Probabilities;
        double total_Probabilitire;
        public int number_Of_Clients = 480;
        int generated_Clients = 0;

        Continuous_RVG_Type inter_Arrival_Type = Continuous_RVG_Type.Exponential;
        RandomVariateGenerator inter_Arrival_Time_Generator;
        
        #region Properties
        public Continuous_RVG_Type Inter_Arrival_Type
        {
            get => inter_Arrival_Type;
            set
            {
                if (value != Inter_Arrival_Type)
                {
                    inter_Arrival_Type = value;
                    update_Generator();
                }

            }
        }

        public RandomVariateGenerator Inter_Arrival_Time_Generator 
        { get => inter_Arrival_Time_Generator; }
        public int Number_Of_Clients
        {
            get => number_Of_Clients;
            set
            {
                if (value >= 0)
                    number_Of_Clients = value;
            }
        }
        #endregion

        #region Public Interfacing Function
        public Client_Generator(List<Service_Node>[] itineraries, double[] relative_Probabilities)
        {
            this.itineraries = itineraries;
            this.relative_Probabilities = relative_Probabilities;
            foreach (double p in relative_Probabilities)
            {
                total_Probabilitire += p;
            }
            update_Generator();
            Discrete_Event.Set_Client_Generator(this);
        }

        public Discrete_Event Generate_A_Client_Arrival(double current_Time)
        {

            double inter_Arrival_Time = inter_Arrival_Time_Generator.GenerateARealRandomNumber();

            // choose an itinerary for the client
            int itinerary_Index = 0;
            double target=  randomizer.NextDouble() * total_Probabilitire;
            for ( itinerary_Index = 0; itinerary_Index < itineraries.Length; itinerary_Index++)
            {
                if (target < relative_Probabilities[itinerary_Index]) break;
            }

            Clients a_Client = new Clients(current_Time+inter_Arrival_Time,itineraries[itinerary_Index]);

            Discrete_Event de = new Client_Arrival_Event(a_Client, current_Time + inter_Arrival_Time);
            //

            generated_Clients++;
            if (generated_Clients >= number_Of_Clients+1)
            {
                return null;
            }
            else
            {
                de.description = "arrival";
                de.Add_To_Simulation_Engine();
                return de;
            }
            
        }
        #endregion

        

        #region Helping Function
        private void update_Generator()
            {
                switch (inter_Arrival_Type)
                {
                    case Continuous_RVG_Type.Exponential:
                    inter_Arrival_Time_Generator = new ExponenitalRVG(1,0,1);
                        break;
                    case Continuous_RVG_Type.Uniform:
                    inter_Arrival_Time_Generator = new UniformRVG(0, 1);
                        break;
                    default:
                        break;
                }
            }
        #endregion
    }
}