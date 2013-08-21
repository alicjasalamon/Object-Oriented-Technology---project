using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Selection
{
    /// <summary>
    /// Represents selection
    /// selects the percent of points with the best values
    /// </summary>
    /// <author>Alicja Salamon</author>
    class Selection_PercentOfBests : SelectionIF
    {
        private double _percent;

        /// <summary>
        /// Selection_PercentOfBests constructor
        /// </summary>
        /// <param name="percent">percent of points to be selected</param>
        public Selection_PercentOfBests(double percent)
        {
            _percent = percent;
            Type = OperatorType.Both;
        }

        /// <summary>
        /// Selects percent of points
        /// which have the best values
        /// </summary>
        /// <param name="pointSet">pointSet to select from</param>
        override public PointSet Operate(PointSet ps)
        {
            Console.WriteLine("Selection_PercentOfBests: " + _percent);
            HashSet<Point> newPointSet = new HashSet<Point>();

            double howMany = ps.Set.Count * (_percent / 100);

            Point p;
            while(howMany>0)
            {
                p = ps.GetTheBest();
                newPointSet.Add(p);
                ps.Set.Remove(p);
                howMany--;
            }

            ps.Set = newPointSet;
            return ps;
        }
    }
}
