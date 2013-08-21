using Strategies.GA.Crossover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for DoubleCrossover_AllWithTheBestTest and is intended
    ///to contain all DoubleCrossover_AllWithTheBestTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoubleCrossover_AllWithTheBestTest
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
        ///A test for DoubleCrossover_AllWithTheBest Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleCrossover_AllWithTheBestConstructorTest()
        {
            DoubleCrossover_AllWithTheBest target = new DoubleCrossover_AllWithTheBest();
            Assert.AreEqual(target.Type, OperatorType.Double);
        }

        /// <summary>
        ///A test for Cross
        ///</summary>
        [TestMethod()]
        public void CrossTest()
        {
            DoubleCrossover_AllWithTheBest target = new DoubleCrossover_AllWithTheBest();
            Point point1 = new DoublePoint(5);
            Point point2 = new DoublePoint(3);
            Point expected = new DoublePoint(4);
            Point actual;
            actual = target.Cross(point1, point2);
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        /// <summary>
        ///A test for Operate
        ///</summary>
        [TestMethod()]
        public void OperateTest()
        {
            DoubleCrossover_AllWithTheBest target = new DoubleCrossover_AllWithTheBest();
            DoublePoint p1 = new DoublePoint(5);
            DoublePoint p2 = new DoublePoint(6);
            DoublePoint p3 = new DoublePoint(7);

            DoublePoint p4 = new DoublePoint(5);
            DoublePoint p5 = new DoublePoint(6);
            DoublePoint p6 = new DoublePoint(7);

            PointSet ps = new PointSet(new HashSet<Point>() {p1,p2,p3 });
            PointSet expected = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5, p6 }); 
            PointSet actual;
            actual = target.Operate(ps);
            Assert.AreEqual(expected.Set.Count, actual.Set.Count);
        }
    }
}
