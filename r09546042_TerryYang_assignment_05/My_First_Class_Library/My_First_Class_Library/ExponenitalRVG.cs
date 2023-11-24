using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_First_Class_Library
{
    /// <summary>
    /// The class generate random variates that follow exponential distribution.
    /// </summary>
    public class ExponenitalRVG : ContinuousRandomVariateGenerator
    {
        //public override double TheoreticMean;

        //data field
        double mean;

        public ExponenitalRVG(double mean)
        {
            this.mean = mean;
        }


        public override double GenerateARealRandomNumber()
        {
            return -mean * Math.Log(1.0 - randomizer.NextDouble());
        }
    }
}