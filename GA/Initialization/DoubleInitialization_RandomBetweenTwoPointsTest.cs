using Strategies.GA.Initialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for DoubleInitialization_RandomBetweenTwoPointsTest and is intended
    ///to contain all DoubleInitialization_RandomBetweenTwoPointsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoubleInitialization_RandomBetweenTwoPointsTest
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
        ///A test for DoubleInitialization_RandomBetweenTwoPoints Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleInitialization_RandomBetweenTwoPointsConstructorTest()
        {
            DoublePoint leftPoint = new DoublePoint(0);
            DoublePoint rightPoint = new DoublePoint(4);
            int howMany = 3;
            DoubleInitialization_RandomBetweenTwoPoints target = new DoubleInitialization_RandomBetweenTwoPoints(leftPoint, rightPoint, howMany);
            Assert.AreEqual(target.Type, OperatorType.Double);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest()
        {
            DoublePoint leftPoint = new DoublePoint(0);
            DoublePoint rightPoint = new DoublePoint(4);
            int howMany = 3;
            DoubleInitialization_RandomBetweenTwoPoints target = new DoubleInitialization_RandomBetweenTwoPoints(leftPoint, rightPoint, howMany);
            PointSet expected = new PointSet(new HashSet<Point>(){new DoublePoint(0), new DoublePoint(2), new DoublePoint(4)});
            PointSet actual;
            actual = target.Create();

            Assert.AreEqual(expected.Set.Count, actual.Set.Count);
           // Assert.AreEqual(expected.Set.);
        }
    }
}
