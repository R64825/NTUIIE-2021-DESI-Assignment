using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_First_Class_Library
{
    public class RandomVariateGenerator
    {

        public virtual double TheoreticMean { set; get; }
        public virtual double TheoreticStandardDeviation { set; get; }

        protected Random randomizer;//給家人使用

        protected int seed;//給家人使用

        public void SetSeed(int Set_seed)
        {
            if (Set_seed == -1)
            {
                randomizer = new Random();
            }
            else
            {
                randomizer = new Random(Set_seed);
            }          
        }

        /// <summary>
        /// Generate a random variable.
        /// </summary>
        public virtual double GenerateARealRandomNumber()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="epoch"></param>
        /// <returns></returns>
        public double ReplicationVerficationForMean(int epoch)
        {
            double sum = 0;
            for (int i = 0; i < epoch; i++)
            {
                sum += GenerateARealRandomNumber();
            }
            return sum / epoch;
        }

    }
}