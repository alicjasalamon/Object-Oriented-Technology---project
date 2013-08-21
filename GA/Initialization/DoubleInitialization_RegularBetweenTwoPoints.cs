using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Initialization
{
    /// <summary>
    /// Represents double initialization
    /// initialization type - regular
    /// </summary>
    /// <author>Alicja Salamon</author>
    class DoubleInitialization_RegularBetweenTwoPoints : InitializationIF
    {

        private DoublePoint _left, _right;
        private int _howMany;

        /// <summary>
        /// DoubleInitialization_RegularBetweenTwoPoints constructor
        /// </summary>
        /// <param name="leftPoint">the left edge of the interval</param>
        /// <param name="rightPoint">the right edge of the intervalt</param>
        /// <param name="howMany">number of points to be creates</param>
        public DoubleInitialization_RegularBetweenTwoPoints(DoublePoint l, DoublePoint r, int c)
        {
            _left = l;
            _right = r;
            _howMany = c;
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Creates new pointSet
        /// equal intervals in point
        /// </summary>
        override public PointSet Create()
        {
            Console.Write("DoubleInitialization_RegularBetweenToPoints: ");
            Console.WriteLine(_left.StringRepresent() + "-" + _right.StringRepresent() );
            PointSet ps = new PointSet();

            for (int i = 0; i < _howMany; i++)
            {
                double[] values = new double[_left.Size];
                for (int j = 0; j < _left.Size; j++)
                {
                    values[j] = _left.PointValues[j] + (_right.PointValues[j] - _left.PointValues[j]) / (_howMany-1) * i;
                }
                ps.Add(new DoublePoint(values));
            }

            return ps;
        }
    }
}
