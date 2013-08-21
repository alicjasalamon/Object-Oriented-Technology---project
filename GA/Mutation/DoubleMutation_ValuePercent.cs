using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Mutation
{
    /// <summary>
    /// Represents double mutation
    /// mutation type - changes given value by given percent
    /// </summary>
    /// <author>Alicja Salamon</author>
    class DoubleMutation_ValuePercent : MutationIF
    {
        private double _percent;

        /// <summary>
        /// DoubleMutation_ValuePercent constructor
        /// </summary>
        /// <param name="added">percentage of the double point</param>
        public DoubleMutation_ValuePercent(double percent)
        {
            _percent = percent;
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Mutates each point
        /// </summary>
        /// <param name="pointSet">pointSet to be mutated</param>
        override public PointSet Operate(PointSet pointSet)
        {
            Console.WriteLine("DoubleMutation_ValuePercent: " + _percent);

            HashSet<Point> newPs = new HashSet<Point>();
            foreach (Point p in pointSet.Set)
            {
                newPs.Add(Mutate(p));
            }
            pointSet.Set = newPs;

            return pointSet;
        }

        /// <summary>
        /// changes point randomly
        /// by given percent
        /// </summary>
        /// <param name="point">point to be mutated</param>
        override public Point Mutate(Point p)
        {
            DoublePoint newP = (DoublePoint)p;

            Random r = new Random();
            double k;
            for (int i = 0; i < p.Size; i++) 
            {
                k = r.NextDouble();
                if (k > 0.5)
                    newP.PointValues[i] *= (100-_percent)/100;
                else
                    newP.PointValues[i] *= (100+_percent)/100;
            }

            return newP;
        }
    }
}
