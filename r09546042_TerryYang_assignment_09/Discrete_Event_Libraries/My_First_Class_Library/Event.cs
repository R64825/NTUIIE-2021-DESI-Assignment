﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Variate_Generator_Library
{
    public class SIS_Event
    {
        public double event_Time;
        public double order_Quantities;

        public virtual string Get_Type()
        {
            return "";
        }
        public virtual double Get_Quantities()
        {
            return 0;
        }
    }
}