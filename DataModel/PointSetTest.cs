using Strategies.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for PointSetTest and is intended
    ///to contain all PointSetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PointSetTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Set
        ///</summary>
        [TestMethod()]
        public void SetTest()
        {
            PointSet target = new PointSet();
            HashSet<Point> expected = new HashSet<Point>();
            HashSet<Point> actual;
            target.Set = expected;
            actual = target.Set;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTheBest
        ///</summary>
        [TestMethod()]
        public void GetTheBestTest()
        {
            DoublePoint p1 = new DoublePoint(new double[]{2,4});
            p1.Value=4;
            DoublePoint p2 = new DoublePoint(new double[]{6,3});
            p2.Value=6;
            HashSet<Point> hs = new HashSet<Point> { p1, p2 };
            PointSet target = new PointSet(hs); 
            Point expected = p2; 
            Point actual;
            actual = target.GetTheBest();
            Assert.AreEqual(expected, actual);
        }

        
        /// <summary>
        ///A test for GetSortedList
        ///</summary>
        [TestMethod()]
        public void GetSortedListTest()
        {
            DoublePoint p1 = new DoublePoint(new double[] { 2, 4 });
            p1.Value = 4;
            DoublePoint p2 = new DoublePoint(new double[] { 6, 3 });
            p2.Value = 6;
            DoublePoint p3 = new DoublePoint(new double[] { 22, 4 });
            p3.Value = 10;
            HashSet<Point> hs = new HashSet<Point> { p1, p2, p3 };
            PointSet target = new PointSet(hs);

            List<Point> expected = new List<Point> { p3, p2, p1 };
            List<Point> actual;
            actual = target.GetSortedList();
            Assert.AreEqual(actual[0].Value, 4);
            Assert.AreEqual(actual[1].Value, 6);
            Assert.AreEqual(actual[2].Value, 10);
        }


        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            PointSet target = new PointSet();
            Point point = new DoublePoint(5);
            target.Add(point);
            Assert.AreEqual(target.Set.Count, 1);
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest1()
        {
            PointSet target = new PointSet();
            PointSet pointSet = new PointSet();
            DoublePoint p = new DoublePoint(5);
            pointSet.Add(p);
            target.Add(pointSet);
            Assert.AreEqual(target.Set.Count, 1);
        }


        /// <summary>
        ///A test for PointSet Constructor
        ///</summary>
        [TestMethod()]
        public void PointSetConstructorTest()
        {
            HashSet<Point> pSet = new HashSet<Point>() { new DoublePoint(5) };
            PointSet target = new PointSet(pSet);
            Assert.AreEqual(target.Set.Count, 1);
        }

        /// <summary>
        ///A test for PointSet Constructor
        ///</summary>
        [TestMethod()]
        public void PointSetConstructorTest1()
        {
            PointSet target = new PointSet();
            Assert.AreEqual(target.Set.Count, 0);
        }

        /// <summary>
        ///A test for PointSet Constructor
        ///</summary>
        [TestMethod()]
        public void PointSetConstructorTest2()
        {
            PointSet pSet = new PointSet(new HashSet<Point>() { new DoublePoint(5) });
            PointSet target = new PointSet(pSet);
            Assert.AreEqual(target.Set.Count, 1);
        }
    }
}
