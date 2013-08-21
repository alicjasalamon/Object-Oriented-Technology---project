using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategies.DataModel
{
    /// <summary>
    /// Abstract class representing point
    /// </summary>
    /// <author>Alicja Salamon</author>
    abstract class Point
    {
        private int _size;
        private double _value;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Creates a string representation for point
        /// </summary>
        abstract public String StringRepresent();
    }
}
