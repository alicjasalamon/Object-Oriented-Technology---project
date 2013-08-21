using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;


namespace Strategies.GA.Evaluation
{
    /// <summary>
    /// Represents byte evaluation
    /// evaluation type - preferes ones in bytes
    /// </summary>
    /// <author>Alicja Salamon</author>
    class ByteEvaluation_Ones : EvaluationIF
    {
        private int _zeros;
        private int _ones;

        private void Count(Byte b)
        {
            int b1 = (int)b;
            _zeros = 0;
            _ones = 0;

            while (b1 > 0)
            {
                if (b1 % 2 == 0) _zeros++;
                else _ones++;
                b1 = b1 / 2;
            }
        }

        /// <summary>
        /// ByteEvaluation_Ones constructor
        /// </summary>
        public ByteEvaluation_Ones()
        {
            Type = OperatorType.Byte;
        }

        /// <summary>
        /// Set given point value
        /// p1 - how many ones in bytes
        /// p0 - how many zeros in bytes
        /// (p1 * p0) / (p0 + p1 * 0.7)
        /// </summary>
        /// <param name="point">point to be evaluated</param>
        override public Point SetPointValue(Point point)
        {

            BytePoint byteP = (BytePoint)point;

            int p0 = 0, p1 = 0;

            for (int i = 0; i < point.Size; i++)
            {
                Count(byteP.PointValues[i]);
                p0 += _zeros;
                p1 += _ones;
            }

            point.Value = ((double)(p1 * p0) / (p0 + p1 * 0.7));

            return point;
        }

    }
}
