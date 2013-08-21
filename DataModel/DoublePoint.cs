using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategies.DataModel
{
    ///<summary>
    ///Represents one point containing doubles
    ///</summary>
    ///<author> Alicja Salamon</author>
    class DoublePoint : Point
    {
        private double[] _pointValues;

        /// <summary>
        /// DoublePoint constructor - no values;
        /// </summary>
        public DoublePoint()
        {
            Size = 0;
            PointValues = null;
        }

        /// <summary>
        /// DoublePoint constructor - one double value;
        /// </summary>
        /// <param name="value">one byte value</param>
        public DoublePoint(double value)
        {
            Size = 1;
            PointValues = new double[1];
            PointValues[0] = value;
        }

        /// <summary>
        /// DoublePoint constructor - double values;
        /// </summary>
        /// <param name="values">double values table</param>
        public DoublePoint(double[] values)
        {
            Size = values.Length;
            PointValues = values;
        }

        public double[] PointValues
        {
            get { return _pointValues; }
            set { _pointValues = value; }
        }

        /// <summary>
        /// Creates a string representation for double-point
        /// </summary>
        override public String StringRepresent()
        {
            String result = "(";
            for (int i = 0; i < PointValues.Length - 1; i++)
                result += (PointValues[i] + ", ");
            result += (PointValues[PointValues.Length - 1] + ")");

            return result;
        }
    }
}
