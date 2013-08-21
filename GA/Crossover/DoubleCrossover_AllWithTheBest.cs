
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Crossover
{
    /// <summary>
    /// Represents double crossover
    /// crossing type - averaged value
    /// </summary>
    /// <author>Alicja Salamon</author>
    class DoubleCrossover_AllWithTheBest : CrossoverIF
    {
        /// <summary>
        /// DoubleCrossover_AllWithTheBest constructor
        /// </summary>
        public DoubleCrossover_AllWithTheBest()
        {
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Changes pointset by adding new points
        /// made by crossing all points with the best one
        /// </summary>
        /// <param name="pointSet">pointset to be changed</param>
        override public PointSet Operate(PointSet ps)
        {
            Point best = ps.GetTheBest();
            PointSet newPointSet = new PointSet();

            foreach (Point p in ps.Set)
            {
                newPointSet.Add(p);
            }

            Console.WriteLine("DoubleCrossover_AllWithTheBest");

            foreach (Point p in ps.Set)
            {
                newPointSet.Add(Cross(best, p));
            }
            return newPointSet;
        }

        /// <summary>
        /// Creates new point by crossing two points
        /// by seting averaged value
        /// </summary>
        /// <param name="point1">first point to be crossed</param>
        /// <param name="point2">second point to be crossed</param>
        override public Point Cross(Point point1, Point point2)
        {
            DoublePoint xP = (DoublePoint)point1;
            DoublePoint yP = (DoublePoint)point2;

            double[] values = new double[point1.Size];

            for (int i = 0; i < point1.Size; i++)
            {
                values[i] = (xP.PointValues[i] + yP.PointValues[i]) / 2;
            }

            return new DoublePoint(values);

        }

    }
}