using Strategies.GA.Mutation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for DoubleMutation_ValuePercentTest and is intended
    ///to contain all DoubleMutation_ValuePercentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoubleMutation_ValuePercentTest
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
        ///A test for DoubleMutation_ValuePercent Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMutation_ValuePercentConstructorTest()
        {
            double percent = 2.0;
            DoubleMutation_ValuePercent target = new DoubleMutation_ValuePercent(percent);
            Assert.AreEqual(target.Type, OperatorType.Double);
        }

        /// <summary>
        ///A test for Mutate
        ///</summary>
        [TestMethod()]
        public void MutateTest()
        {
            double percent = 20.0;
            DoubleMutation_ValuePercent target = new DoubleMutation_ValuePercent(percent);
            Point point = new DoublePoint(10);
            Point actual;
            actual = target.Mutate(point);
            Assert.IsTrue(actual.StringRepresent().Equals("(12)") || actual.StringRepresent().Equals("(8)"));
        }

        /// <summary>
        ///A test for Operate
        ///</summary>
        [TestMethod()]
        public void OperateTest()
        {
            double percent = 2.0;
            DoubleMutation_ValuePercent target = new DoubleMutation_ValuePercent(percent);
            DoublePoint p1 = new DoublePoint(10);
            DoublePoint p2 = new DoublePoint(1);
            DoublePoint p3 = new DoublePoint(15);
            DoublePoint p4 = new DoublePoint(17);
            DoublePoint p5 = new DoublePoint(12);
            PointSet ps = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5 });
            PointSet expected = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5 });
            PointSet actual;
            actual = target.Operate(ps);
            Assert.AreEqual(expected.Set.Count, actual.Set.Count);
        }
    }
}
