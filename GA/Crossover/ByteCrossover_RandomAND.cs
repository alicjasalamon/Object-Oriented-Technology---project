using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Crossover
{
    /// <summary>
    /// Represents byte crossover
    /// crossing type - 'and' (&) byte operation 
    /// </summary>
    /// <author>Alicja Salamon</author>
    class ByteCrossover_RandomAND : CrossoverIF
    {
        /// <summary>
        /// ByteCrossover_RandomAND constructor
        /// </summary>
        public ByteCrossover_RandomAND()
        {
            Type = OperatorType.Byte;
        }

        /// <summary>
        /// Changes pointset by adding new points
        /// made by crossing random point pairs
        /// </summary>
        /// <param name="pointSet">pointset to be changed</param>
        override public PointSet Operate(PointSet pointSet)
        {
            Console.WriteLine("ByteCrossover_RandomAND");
            List<Point> newPointList = new List<Point>();
            HashSet<Point> newPointSet = new HashSet<Point>();

            foreach (Point p in pointSet.Set)
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
                p2 = newPointList[r.Next(newPointList.Count)];
                newPointList.Remove(p2);

                newPointSet.Add(Cross(p1, p2));
            }

            pointSet.Set = newPointSet;
            return pointSet;

        }

        /// <summary>
        /// Creates new point by crossing two points
        /// using byte operation 'and'
        /// </summary>
        /// <param name="point1">first point to be crossed</param>
        /// <param name="point2">second point to be crossed</param>
        override public Point Cross(Point point1, Point point2)
        {
            BytePoint xP = (BytePoint)point1;
            BytePoint yP = (BytePoint)point2;

            byte[] values = new byte[point1.Size];

            for (int i = 0; i < point1.Size; i++)
            {
                values[i] = (byte)(xP.PointValues[i] & yP.PointValues[i]);
            }

            return new BytePoint(values);
        }
    }

}