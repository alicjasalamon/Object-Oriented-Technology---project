using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

/// <summary>
/// Abstract class representing crossover operator
/// </summary>
/// <author>Alicja Salamon</author>
namespace Strategies.GA.Crossover
{
    abstract class CrossoverIF : Operator
    {
        /// <summary>
        /// Creates new point by crossing two points
        /// </summary>
        /// <param name="point1">first point to be crossed</param>
        /// <param name="point2">second point to be crossed</param>
        abstract public Point Cross(Point point1, Point point2);
    }
}