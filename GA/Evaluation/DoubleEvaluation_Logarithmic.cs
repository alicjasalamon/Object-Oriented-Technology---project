using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Evaluation
{
    class DoubleEvaluation_Logarithmic : EvaluationIF
    {
        /// <summary>
        /// Represents double evaluation
        /// evaluation type - uses logarithmic funtion
        /// recommended use - two-dimensional points
        /// </summary>
        /// <author>Alicja Salamon</author>
        public DoubleEvaluation_Logarithmic()
        {
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Set given point value
        /// Log(|x| + 1) * Log(|x| + 1) * y
        /// </summary>
        /// <param name="point">point to be evaluated</param>
        override public Point SetPointValue(Point point)
        {

            DoublePoint doubleP = (DoublePoint)point;
            double x = doubleP.PointValues[0];
            double y;

            if (doubleP.Size>1) y = doubleP.PointValues[1];
            else y = 1;

            point.Value = Math.Log(Math.Abs(x) + 1) * Math.Log(Math.Abs(x) + 1)*y;

            return point;
        }

    }
}
