using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Evaluation
{
    /// <summary>
    /// Abstract class representing evaluation
    /// </summary>
    /// <author>Alicja Salamon</author>
    abstract class EvaluationIF
    {
        private OperatorType _type;
        public OperatorType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Sets given point value
        /// </summary>
        /// <param name="point">point to be evaluated</param>
        abstract public Point SetPointValue(Point point);

        /// <summary>
        /// Set value for each point
        /// </summary>
        /// <param name="pointSet">pointSet to be evaluated</param>
        public PointSet Evaluate(PointSet pointSet)
        {
            foreach (Point point in pointSet.Set)
            {
                SetPointValue(point);
            }
            return pointSet;
        }
    }
}
