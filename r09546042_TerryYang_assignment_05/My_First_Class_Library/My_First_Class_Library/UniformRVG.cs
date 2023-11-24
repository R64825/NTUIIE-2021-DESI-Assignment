using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Class_Library
{
    public class UniformRVG : ContinuousRandomVariateGenerator
    {
        double lowerbound, upperbound;
        /// <summary>
        /// setting upper bound & lowerbound
        /// </summary>
        /// <param name="L"></param>
        /// <param name="U"></param>
        public UniformRVG(double L, double U)
        {
            this.lowerbound = L;
            this.upperbound = U;
        }
        public override double GenerateARealRandomNumber()
        {
            double u = randomizer.NextDouble();
            double range = upperbound - lowerbound;
            return lowerbound+u*range;
        }

    }
}
