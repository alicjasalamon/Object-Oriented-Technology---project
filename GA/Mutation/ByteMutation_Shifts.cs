using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Mutation
{
    /// <summary>
    /// Represents byte mutation
    /// mutation type - byte shifts (>>)
    /// </summary>
    /// <author>Alicja Salamon</author>
    class ByteMutation_Shifts : MutationIF
    {
        private int _shift;

        /// <summary>
        /// ByteCrossover_RandomOR constructor
        /// </summary>
        /// <param name="shift">number of bytes point would be shifted</param>
        public ByteMutation_Shifts(int shift)
        {
            _shift = shift;
            Type = OperatorType.Byte;
        }

        /// <summary>
        /// Mutates each point
        /// </summary>
        /// <param name="pointSet">pointSet to be mutated</param>
        override public PointSet Operate(PointSet pointSet)
        {
            Console.WriteLine("ByteMutation_Shifts: ");

            HashSet<Point> newPs = new HashSet<Point>();
            foreach (Point p in pointSet.Set)
            {
                newPs.Add(Mutate(p));
            }
            pointSet.Set = newPs;

            return pointSet;
        }

        /// <summary>
        /// Shifts point randomly
        /// left or right
        /// </summary>
        /// <param name="point">point to be mutated</param>
        override public Point Mutate(Point point)
        {
            BytePoint newP = (BytePoint)point;

            Random r = new Random();
            double k;
            for (int i = 0; i < point.Size; i++) 
            {
                k = r.NextDouble();
                if (k > 0.5)
                    newP.PointValues[i] >>= _shift; 
                else
                    newP.PointValues[i] <<= _shift;
            }

            return newP;
        }
    }
}
