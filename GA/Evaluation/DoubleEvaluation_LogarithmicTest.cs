using Strategies.GA.Evaluation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for DoubleEvaluation_LogarithmicTest and is intended
    ///to contain all DoubleEvaluation_LogarithmicTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoubleEvaluation_LogarithmicTest
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
        ///A test for DoubleEvaluation_Logarithmic Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleEvaluation_LogarithmicConstructorTest()
        {
            DoubleEvaluation_Logarithmic target = new DoubleEvaluation_Logarithmic();
            Assert.AreEqual(target.Type, OperatorType.Double);
        }

        /// <summary>
        ///A test for SetPointValue
        ///</summary>
        [TestMethod()]
        public void SetPointValueTest()
        {
            DoubleEvaluation_Logarithmic target = new DoubleEvaluation_Logarithmic();
            Point point = new DoublePoint(5);
            Point actual;
            actual = target.SetPointValue(point);
            double x = actual.Value - 3.2104019955684011;
            Assert.IsTrue(Math.Abs(x) < 0.0001);
        }
    }
}
