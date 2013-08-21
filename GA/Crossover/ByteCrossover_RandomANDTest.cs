using Strategies.GA.Crossover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for ByteCrossover_RandomANDTest and is intended
    ///to contain all ByteCrossover_RandomANDTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ByteCrossover_RandomANDTest
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
        ///A test for ByteCrossover_RandomAND Constructor
        ///</summary>
        [TestMethod()]
        public void ByteCrossover_RandomANDConstructorTest()
        {
            ByteCrossover_RandomAND target = new ByteCrossover_RandomAND();
            Assert.AreEqual(target.Type, OperatorType.Byte);
        }

        /// <summary>
        ///A test for Cross
        ///</summary>
        [TestMethod()]
        public void CrossTest()
        {
            ByteCrossover_RandomAND target = new ByteCrossover_RandomAND();
            Point point1 = new BytePoint(new byte[] { 0, 2, 3 });
            Point point2 = new BytePoint(new byte[] { 0, 2, 3 });
            Point expected = new BytePoint(new byte[] { 0, 2, 3 });
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
            ByteCrossover_RandomAND target = new ByteCrossover_RandomAND();
            Point point1 = new BytePoint(new byte[] { 0, 4, 5 });
            Point point2 = new BytePoint(new byte[] { 0, 2, 3 });
            Point point3 = new BytePoint(new byte[] { 6, 2, 7 });


            PointSet expected = new PointSet(new HashSet<Point>() { point1, point2, point3 });

            PointSet pointSet = new PointSet(new HashSet<Point>() { point1, point2 });
            PointSet actual;
            actual = target.Operate(pointSet);
            Assert.AreEqual(expected.Set.Count, actual.Set.Count);
        }
    }
}
