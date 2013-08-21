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
    class DoubleCrossover_Random : CrossoverIF
    {
        /// <summary>
        /// DoubleCrossover_Random constructor
        /// </summary>
        public DoubleCrossover_Random()
        {
            Type = OperatorType.Double;
        }

        /// <summary>
        /// Changes pointset by adding new points
        /// made by crossing random point pairs
        /// </summary>
        /// <param name="pointSet">pointset to be changed</param>
        override public PointSet Operate(PointSet ps)
        {

            Console.WriteLine("DoubleCrossover_Random");
            List<Point> newPointList = new List<Point>();
            HashSet<Point> newPointSet = new HashSet<Point>();

            foreach (Point p in ps.Set)
            {
                newPointList.Add(p);
                newPointSet.Add(p);
            }

            Point p1, p2;
            Random r = new Random();

            while (newPointList.Count > 1)
            {
                p1 = newPointList[r.Next(newPointList.Count)];
                newPointList.Remove(p1);
                p2 = (DoublePoint)newPointList[r.Next(newPointList.Count)];
                newPointList.Remove(p2);

                newPointSet.Add(Cross(p1, p2));
            }

            ps.Set = newPointSet;
            return ps;
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