using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Evaluation
{
    class DoubleEvaluation_Trigonometric : EvaluationIF
    {
        /// <summary>
        /// Represents double evaluation
        /// evaluation type - uses trigonometric funtion
        /// recommended use - one-dimensional points
        /// </summary>
        /// <author>Alicja Salamon</author>
        public DoubleEvaluation_Trigonometric()
        {
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Set given point value
        /// sin(x) + x * (x + 2)) / (x + 1) * cos(x)
        /// </summary>
        /// <param name="point">point to be evaluated</param>
        override public Point SetPointValue(Point p)
        {
            DoublePoint doubleP = (DoublePoint)p;
            double x = doubleP.PointValues[0];

            p.Value = (Math.Sin(x) + x * (x + 2)) / (x + 1) * Math.Cos(x);

            return p;
        }
    }
}
