using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Initialization
{
    /// <summary>
    /// Represents double initialization
    /// initialization type - random
    /// </summary>
    /// <author>Alicja Salamon</author>
    class DoubleInitialization_RandomBetweenTwoPoints : InitializationIF
    {
        private DoublePoint _left, _right;
        private int _howMany;

        /// <summary>
        /// DoubleInitialization_RandomBetweenTwoPoints constructor
        /// </summary>
        /// <param name="leftPoint">the left edge of the interval</param>
        /// <param name="rightPoint">the right edge of the intervalt</param>
        /// <param name="howMany">number of points to be creates</param>
        public DoubleInitialization_RandomBetweenTwoPoints(DoublePoint leftPoint, DoublePoint rightPoint, int howMany)
        {
            _left = leftPoint;
            _right = rightPoint;
            _howMany = howMany;
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Creates new pointSet
        /// random points in given intrerval
        /// </summary>
        override public PointSet Create()
        {
            Console.Write("DoubleInitialization_RandomBetweenToPoints: ");
            Console.WriteLine(_left.StringRepresent() + "-" + _right.StringRepresent() );
            PointSet ps = new PointSet();
            Random r = new Random();

            for (int i = 0; i < _howMany; i++)
            {
                double[] values = new double[_left.Size];
                for (int j = 0; j < _left.Size; j++)
                {
                    values[j] = r.NextDouble()*(_right.PointValues[j]-_left.PointValues[j]) + _left.PointValues[j];
                }
                ps.Add(new DoublePoint(values));
            }

            return ps;
        }
    }
}
