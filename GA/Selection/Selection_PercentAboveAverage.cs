using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Selection
{
    /// <summary>
    /// Represents selection based on avegare
    /// </summary>
    /// <author>Alicja Salamon</author>
    class Selection_PercentAboveAverage : SelectionIF
    {
        private double _percent;

        /// <summary>
        /// Selection_PercentAboveAverage constructor
        /// </summary>
        /// <param name="percent">percent of average point value has to be to be selected</param>
        public Selection_PercentAboveAverage(double percent)
        {
            _percent = percent;
            Type = OperatorType.Both;
        }

        /// <summary>
        /// Selects point which value is above
        /// percent * average
        /// </summary>
        /// <param name="pointSet">pointSet to select from</param>
        override public PointSet Operate(PointSet pointSet)
        {
            Console.WriteLine("Selection_PercentAboveAverage: " + _percent);
            
            double[] values = new double[pointSet.Set.Count];
           
            int i = 0;
            foreach (Point p in pointSet.Set)
            {
                values[i] = p.Value;
                i++;
            }

           double avg = values.Average()*(_percent)/100;

           HashSet<Point> newSet = new HashSet<Point>();

            foreach (Point p in pointSet.Set)
            {
                if (p.Value >= avg)
                {
                    newSet.Add(p);
                }
            }

            pointSet.Set = newSet;
            return pointSet;
        }
    }
}
