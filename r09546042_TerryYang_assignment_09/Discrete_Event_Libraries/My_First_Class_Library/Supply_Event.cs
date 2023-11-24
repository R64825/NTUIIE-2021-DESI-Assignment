using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Variate_Generator_Library
{
    public class Supply_Event : SIS_Event
    {
        public double order_Quantities;
        public Supply_Event( double event_Time, double order_Quantities)
        {
            this.event_Time = event_Time;
            this.order_Quantities = order_Quantities;
        }
        public override double Get_Quantities()
        {
            return order_Quantities;
        }
        public override string Get_Type()
        {
            return "s";
        }
    }
}