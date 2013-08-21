using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.DataModel
{
    ///<summary>
    ///Represents one point containing bytes
    ///</summary>
    ///<author> Alicja Salamon</author>
    class BytePoint : Point
    {
        private byte[] _pointValues;

        /// <summary>
        /// BytePoint constructor - no values;
        /// </summary>
        public BytePoint()
        {
            Size = 0;
            PointValues = null;
        }

        /// <summary>
        /// BytePoint constructor - one byte value;
        /// </summary>
        /// <param name="value">one byte value</param>
        public BytePoint(byte value)
        {
            Size = 1;
            PointValues = new byte[1];
            PointValues[0] = value;
        }

        /// <summary>
        /// BytePoint constructor - byte values;
        /// </summary>
        /// <param name="values">byte values table</param>
        public BytePoint(byte[] values)
        {
            Size = values.Length;
            PointValues = values;
        }

        public byte[] PointValues
        {
            get { return _pointValues; }
            set { _pointValues = value; }
        }

        /// <summary>
        /// Creates a string representation for byte-point
        /// </summary>
        override public String StringRepresent()
        {
            String result = "[";
            for (int i = 0; i < PointValues.Length - 1; i++)
                result += (PointValues[i] + "\t");
            result += (PointValues[PointValues.Length - 1] + "]");

            return result;
        }
    }
}
