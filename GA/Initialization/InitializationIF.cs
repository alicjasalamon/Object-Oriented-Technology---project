using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Initialization
{
    /// <summary>
    /// Abstract class representing initialization
    /// </summary>
    /// <author>Alicja Salamon</author>
    abstract class InitializationIF
    {
        private OperatorType _type;
        public OperatorType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Creates new pointSet
        /// </summary>
        abstract public PointSet Create();
    }
}
