using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;
using Strategies.GA.Evaluation;

namespace Strategies.GA
{
    /// <summary>
    /// Abstract class representing operator
    /// Could be selection, crossover or mutation
    /// </summary>
    /// <author>Alicja Salamon</author>
    abstract class Operator
    {
        private OperatorType _type;

        public OperatorType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Changes given pointset
        /// </summary>
        /// <param name="pointSet">pointset to be changed</param>
        abstract public PointSet Operate(PointSet pointSet);
    }
}
