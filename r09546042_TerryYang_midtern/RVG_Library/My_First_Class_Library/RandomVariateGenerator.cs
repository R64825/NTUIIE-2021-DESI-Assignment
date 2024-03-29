﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace My_First_Class_Library
{
    [TypeConverter(typeof( ExpandableObjectConverter))]
    public class RandomVariateGenerator
    {
        
        //public virtual double TheoreticMean { set; get; }
        //public virtual double TheoreticStandardDeviation { set; get; }

        protected Random randomizer=  new Random();//給家人使用

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
        /// 
        //public Histogram<T> GenerateRandomVariatesGetHistogramAndSampleStatistics<T>(int numberOfInstances, out double sampleMean, out double sampleSTD)
        //{
        //    Histogram<T> histogram = new Histogram<T>();
        //    sampleMean = 0.0;
        //    sampleSTD = 0.0;

        //}
        public virtual int GetRandomVariate(bool returnInt = true)//discrete
        {
            throw new System.NotImplementedException();
        }
        public virtual int GetRandomVariate()//continue
        {
            throw new System.NotImplementedException();
        }

        public virtual double GetDensityFunction(double x)//graphing
        {
            throw new System.NotImplementedException();
        }
        public virtual Series GetDendityFunctionSeries(/*double start, double end, */double resolution)
        {

            //Series s = new Series();
            //s.Points.Clear();
            //s.ChartType = SeriesChartType.Line;

            //double delta = ((end - start) / resolution);
            //for (double i = start; i < end; i += delta)
            //{
            //    s.Points.AddXY(i, GetDensityFunction(i));
            //}
            //return s;
            throw new System.NotImplementedException();
        }

        
        public virtual double GetParameters(char C)//discrete
        {
            throw new System.NotImplementedException();
        }

        public virtual double GetMean(double[] arr)
        {
            throw new System.NotImplementedException();
        }
        public virtual double GetSTD(double[] arr)
        {
            throw new System.NotImplementedException();
        }
        public virtual double GetTheoreticMean()
        {
            throw new System.NotImplementedException();
        }
        public virtual double GetTheoreticSTD()
        {
            throw new System.NotImplementedException();
        }
        //public double ReplicationVerficationForMean(int epoch)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < epoch; i++)
        //    {
        //        sum += GenerateARealRandomNumber();
        //    }
        //    return sum / epoch;
        //}

    }
}