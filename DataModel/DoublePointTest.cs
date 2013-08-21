using Strategies.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for DoublePointTest and is intended
    ///to contain all DoublePointTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoublePointTest
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
        ///A test for PointValues
        ///</summary>
        [TestMethod()]
        public void PointValuesTest()
        {
            DoublePoint target = new DoublePoint(new double[] { 1.0, 5, 7 });
            double[] expected = new double[] { 1.0, 5, 7 };
            double[] actual;
            target.PointValues = expected;
            actual = target.PointValues;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for StringRepresent
        ///</summary>
        [TestMethod()]
        public void StringRepresentTest()
        {
            DoublePoint target = new DoublePoint(5);
            string expected = "(5)";
            string actual;
            actual = target.StringRepresent();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DoublePoint Constructor
        ///</summary>
        [TestMethod()]
        public void DoublePointConstructorTest()
        {
            DoublePoint target = new DoublePoint();
            Assert.AreEqual(target.Size, 0);
            Assert.IsNull(target.PointValues);
        }

        /// <summary>
        ///A test for DoublePoint Constructor
        ///</summary>
        [TestMethod()]
        public void DoublePointConstructorTest1()
        {
            double value = 8.888;
            DoublePoint target = new DoublePoint(value);
            Assert.AreEqual(target.Size, 1);
            Assert.IsNotNull(target.PointValues);
        }

        /// <summary>
        ///A test for DoublePoint Constructor
        ///</summary>
        [TestMethod()]
        public void DoublePointConstructorTest2()
        {
            double[] values = new double[] { 6.7, 6.0, 8.3 };
            DoublePoint target = new DoublePoint(values);
            Assert.AreEqual(target.PointValues, values);
        }
    }
}
