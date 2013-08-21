using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Selection
{
    /// <summary>
    /// Represents selection 
    /// half of point set in tournament
    /// </summary>
    /// <author>Alicja Salamon</author>
    class Selection_Tournament : SelectionIF
    {
        /// <summary>
        /// Selection_Tournament constructor
        /// </summary>
        public Selection_Tournament()
        {
            Type = OperatorType.Both;
        }

        /// <summary>
        /// Selects better ones from ramdomly chosen pairs
        /// </summary>
        /// <param name="pointSet">pointSet to select from</param>
        override public PointSet Operate(PointSet ps)
        {
            Console.WriteLine("Selection_Tournament: ");

            List<Point> newPointList = new List<Point>();
            HashSet<Point> newPointSet = new HashSet<Point>();

            foreach (Point p in ps.Set)
            {
                newPointList.Add(p);
            }

            Point p1, p2;
            Random r = new Random();

            while (newPointList.Count > 1)
            {
                p1 = newPointList[r.Next(newPointList.Count)];
                newPointList.Remove(p1);
                p2 = newPointList[r.Next(newPointList.Count)];
                newPointList.Remove(p2);

                if (p1.Value > p2.Value)
                    newPointSet.Add(p1);
                else newPointSet.Add(p2);
            }

            ps.Set = newPointSet;
            return ps;

        }
    }
}
