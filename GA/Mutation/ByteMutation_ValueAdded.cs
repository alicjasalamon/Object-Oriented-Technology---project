using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Mutation
{
    /// <summary>
    /// Represents byte mutation
    /// mutation type - adding value
    /// </summary>
    /// <author>Alicja Salamon</author>
    class ByteMutation_ValueAdded : MutationIF
    {
        private int _added;
        private Random _r = new Random();

        /// <summary>
        /// ByteCrossover_RandomOR constructor
        /// </summary>
        /// <param name="added">numer to be added or subtracted</param>
        public ByteMutation_ValueAdded(int added)
        {
            _added=added;
            Type = OperatorType.Byte;
        }

        /// <summary>
        /// Mutates each point
        /// </summary>
        /// <param name="pointSet">pointSet to be mutated</param>
        override public PointSet Operate(PointSet ps)
        {
            Console.WriteLine("ByteMutation_ValueAdded: " + _added);

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
            BytePoint newP = (BytePoint)point;

            double k;
            for (int i = 0; i < point.Size; i++) 
            {
                k = _r.NextDouble();
                if (k > 0.5)
                    newP.PointValues[i] -= (byte) _added;
                else
                    newP.PointValues[i] += (byte) _added;
            }

            return newP;
        }
    }
}
