using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

/// <summary>
/// Abstract class representing mutation operator
/// </summary>
/// <author>Alicja Salamon</author>
namespace Strategies.GA.Mutation
{
    abstract class MutationIF : Operator
    {
        /// <summary>
        /// Changes single point
        /// </summary>
        /// <param name="point">point to be mutated</param>
        abstract public Point Mutate(Point point);
    }
}
