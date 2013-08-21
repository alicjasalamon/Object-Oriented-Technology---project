using Strategies.GA.Selection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for Selection_PercentAboveAverageTest and is intended
    ///to contain all Selection_PercentAboveAverageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Selection_PercentAboveAverageTest
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
        ///A test for Selection_PercentAboveAverage Constructor
        ///</summary>
        [TestMethod()]
        public void Selection_PercentAboveAverageConstructorTest()
        {
            double percent = 50.0;
            Selection_PercentAboveAverage target = new Selection_PercentAboveAverage(percent);
            Assert.AreEqual(target.Type, OperatorType.Both);

        }

        /// <summary>
        ///A test for Operate
        ///</summary>
        [TestMethod()]
        public void OperateTest()
        {
            double percent = 50.0;
            Selection_PercentAboveAverage target = new Selection_PercentAboveAverage(percent);
            DoublePoint p1 = new DoublePoint(10);
            DoublePoint p2 = new DoublePoint(1);
            DoublePoint p3 = new DoublePoint(15);
            DoublePoint p4 = new DoublePoint(17);
            DoublePoint p5 = new DoublePoint(12);
            p1.Value = 2;
            p2.Value = 5;
            p3.Value = 324;
            p4.Value = 4;
            p5.Value = 6;

            PointSet ps = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5 });
            PointSet ps1 = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5 });

            PointSet actual;
            actual = target.Operate(ps);
            Assert.IsTrue(actual.Set.Count <= ps1.Set.Count);
        }
    }
}
