using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Mutation
{
    /// <summary>
    /// Represents double mutation
    /// mutation type - adds/subtract given value
    /// </summary>
    /// <author>Alicja Salamon</author>
    class DoubleMutation_ValueAdded : MutationIF
    {
        private double _added;

        /// <summary>
        /// DoubleMutation_ValueAdded constructor
        /// </summary>
        /// <param name="added">numer to be added or subtracted</param>
        public DoubleMutation_ValueAdded(double added)
        {
            _added=added;
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Mutates each point
        /// </summary>
        /// <param name="pointSet">pointSet to be mutated</param>
        override public PointSet Operate(PointSet ps)
        {
            Console.WriteLine("DoubleMutation_ValueAdded: " + _added);

            HashSet<Point> newPs = new HashSet<Point>();
            foreach (Point p in ps.Set)
            {
                newPs.Add(Mutate(p));
            }
            ps.Set = newPs;

            return ps;
        }

        /// <summary>
        /// changes point randomly
        /// adds or subtract given vauled
        /// </summary>
        /// <param name="point">point to be mutated</param>
        override public Point Mutate(Point point)
        {
            DoublePoint newP = (DoublePoint)point;

            Random r = new Random();
            double k;
            for (int i = 0; i < point.Size; i++) 
            {
                k = r.NextDouble();
                if (k > 0.5)
                    newP.PointValues[i] -= _added;
                else
                    newP.PointValues[i] += _added;
            }

            return newP;
        }
    }
}
