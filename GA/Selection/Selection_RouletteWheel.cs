using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Selection
{
    /// <summary>
    /// Represents selection 
    /// with random element
    /// </summary>
    /// <author>Alicja Salamon</author>
    class Selection_RouletteWheel : SelectionIF
    {
        Random r = new Random();

        /// <summary>
        /// Selection_RouletteWheel constructor
        /// </summary>
        public Selection_RouletteWheel()
        {
            Type = OperatorType.Both;
        }

        /// <summary>
        /// Selects percent of points
        /// with random element
        /// </summary>
        /// <param name="pointSet">pointSet to select from</param>
        override public PointSet Operate(PointSet pointSet)
        {
            Console.WriteLine("Selection_RouletteWheel: ");

            double best = pointSet.GetTheBest().Value;

            HashSet<Point> newSet = new HashSet<Point>();

            foreach (Point p in pointSet.Set)
            {
                if (r.NextDouble() < p.Value / best)
                {
                    newSet.Add(p);
                }
            }

            pointSet.Set = newSet;
            return pointSet;
        }
    }
}
