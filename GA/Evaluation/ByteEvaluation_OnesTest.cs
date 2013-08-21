using Strategies.GA.Evaluation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for ByteEvaluation_OnesTest and is intended
    ///to contain all ByteEvaluation_OnesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ByteEvaluation_OnesTest
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
        ///A test for ByteEvaluation_Ones Constructor
        ///</summary>
        [TestMethod()]
        public void ByteEvaluation_OnesConstructorTest()
        {
            ByteEvaluation_Ones target = new ByteEvaluation_Ones();
            Assert.AreEqual(target.Type, OperatorType.Byte);
        }

        /// <summary>
        ///A test for SetPointValue
        ///</summary>
        [TestMethod()]
        public void SetPointValueTest()
        {
            ByteEvaluation_Ones target = new ByteEvaluation_Ones();
            Point point = new BytePoint(5);
            Point actual;
            actual = target.SetPointValue(point);
            double x = actual.Value - 0.83333333333333337;
            Assert.IsTrue(Math.Abs(x) < 0.0001);
        }
    }
}
