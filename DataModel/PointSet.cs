using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategies.DataModel
{
    /// <summary>
    /// Represent set of points of single type
    /// </summary>
    /// <author>Alicja Salamon, Dawid Aksamit</author>
    class PointSet
    {
        private double _averageValue;
        private HashSet<Point> _set;

        private double lastBestValue;
        private int maxNoChangeCounter = 10; // how many steps without the change of leader are needed for a query and action to take place 

        public int noChangeCounter
        {
            get;
            set;
        }

        private static int ComparePointsByValue(Point x, Point y)
        {
            if (x.Value == y.Value) return 0;
            else if (x.Value > y.Value) return 1;
            else return -1;
        }
        /// <summary>
        /// PointSet constructor, empty set
        /// </summary>
        public PointSet()
        {
            Set = new HashSet<Point>();
            noChangeCounter = 0;
            lastBestValue = 0;
        }

        /// <summary>
        /// BytePoint constructor
        /// </summary>
        /// <param name="pointSet">set of points</param>
        public PointSet(HashSet<Point> pSet)
        {
            Set = pSet;
        }

        /// <summary>
        /// BytePoint constructor
        /// </summary>
        /// <param name="pointSet">PointSet to be added</param>
        public PointSet(PointSet pSet)
        {
            Set = new HashSet<Point>(pSet.Set);
        }

        public double AverageValue
        {
            get { return _averageValue; }
            set { _averageValue = value; }
            
        }

        /// <summary>
        /// Method checking if the Best value found has been changed in the last steps
        /// </summary>
        /// <returns></returns>
        public Boolean CheckForChange()
        {
            if (lastBestValue < GetTheBest().Value)
            {
                noChangeCounter = 0;
                lastBestValue = GetTheBest().Value;
                return false;
            }
            else
            {
                noChangeCounter += 1;
                if (noChangeCounter >= maxNoChangeCounter)
                {
                    noChangeCounter = 0;
                    return true;
                }
                else return false;
            }
                
        }
        public HashSet<Point> Set
        {
            get { return _set; }
            set { _set = value; }
        }

        /// <summary>
        /// Adds one point
        /// </summary>
        /// <param name="point">point to be added</param>
        public void Add(Point point)
        {
            Set.Add(point);
        }

        /// <summary>
        /// Adds every point from pointSet
        /// </summary>
        /// <param name="pointSet">points in pointSet to be added</param>
        public void Add(PointSet pointSet)
        {
            foreach (Point point in pointSet.Set)
            {
                Set.Add(point);
            }
        }

        /// <summary>
        /// Prints each point in pointet with its value
        /// </summary>
        public void Print()
        {
            int i = 0;
            Console.WriteLine("Actual pointset is:");
            foreach (Point p in Set)
            {
                i++;
                Console.Write(i + ")\t" + p.StringRepresent() + "\t");
                Console.Write("\t" + p.Value + "\n");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Returns a percantage of Best points from the pointset
        /// </summary>
        public List<Point> GetPercentageOfBestPoints(int percentage)
        {
            List<Point> copyList = new List<Point>(GetSortedList());
            List<Point> listToSend = new List<Point>();
            listToSend.AddRange(copyList.Take((int)percentage * copyList.Count() / 100));
            return listToSend;
        }

        /// <summary>
        /// Returns a percantage of Worst points from the pointset
        /// </summary>
        public List<Point> GetPercentageOfWorstPoints(int percentage)
        {
            List<Point> copyList = new List<Point>(GetSortedList());
            List<Point> listToSend = new List<Point>();
            copyList.Reverse();
            listToSend.AddRange(copyList.Take((int)percentage * copyList.Count() / 100));
            return listToSend;
        }

        /// <summary>
        /// Actualizes average value 
        /// </summary>
        public void Actualize()
        {
            int number = Set.Count();   //Number of points
            double sum = 0;             //Sum of values of the points

            foreach (Point p in Set)
            {
                sum += p.Value;
            }

            AverageValue = sum / number;
            
        }

        /// <summary>
        /// Creates list of points in pointset, ordered by value
        /// </summary>
        public List<Point> GetSortedList()
        {
            List<Point> sortedList = new List<Point>();

            foreach (Point p in Set)
            {
                sortedList.Add(p);
            }

            sortedList.Sort(ComparePointsByValue);

            return sortedList;
        }

        /// <summary>
        /// Selects the best point in pointSet
        /// </summary>
        public Point GetTheBest()
        {
            List<Point> sorted = GetSortedList();
            return sorted[sorted.Count - 1];
        }

    }
}
