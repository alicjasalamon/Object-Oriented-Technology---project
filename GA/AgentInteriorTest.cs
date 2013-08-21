using Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.GA;
using Strategies.Action;
using Strategies.DataModel;
using Strategies.GA.Evaluation;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for AgentInteriorTest and is intended
    ///to contain all AgentInteriorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AgentInteriorTest
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
        ///A test for AgentInterior Constructor
        ///</summary>
        [TestMethod()]
        public void AgentInteriorConstructorTest()
        {
            GeneticAlgorithm ga = new GeneticAlgorithm(new ByteEvaluation_Zeros());
            AgentInterior target = new AgentInterior(ga);
            Assert.IsNotNull(target.PS);
            Assert.IsNotNull(target.GA);
        }

        /// <summary>
        ///A test for AgentInterior Constructor
        ///</summary>
        [TestMethod()]
        public void AgentInteriorConstructorTest1()
        {
            AgentInterior target = new AgentInterior();
            Assert.IsNotNull(target.PS);
            Assert.IsNotNull(target.GA);
        }


        /// <summary>
        ///A test for Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            AgentInterior target = new AgentInterior();
            PointSet actual;
            actual = target.Initialize();
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for Solve
        ///</summary>
        [TestMethod()]
        public void SolveTest()
        {
 
            AgentInterior target = new AgentInterior();
            int cycles = 3;
            PointSet actual;
            actual = target.Solve(cycles);
            Assert.IsNotNull(actual.GetTheBest());
        }

        /// <summary>
        ///A test for Step
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Strategies.exe")]
        public void StepTest()
        {
            AgentInterior_Accessor target = new AgentInterior_Accessor();
            int cycles = 3;
            target.Initialize();
            target.Step(cycles);
            Assert.IsNotNull(target.PS.GetTheBest());
        }

        /// <summary>
        ///A test for Step
        ///</summary>
        [TestMethod()]
        public void StepTest1()
        {
            AgentInterior target = new AgentInterior();
            target.Initialize();
            target.Step();
            Assert.IsNotNull(target.PS.GetTheBest());
        }

        /// <summary>
        ///A test for GA
        ///</summary>
        [TestMethod()]
        public void GATest()
        {
            AgentInterior target = new AgentInterior();
            GeneticAlgorithm expected = new GeneticAlgorithm(new ByteEvaluation_Ones());
            GeneticAlgorithm actual;
            target.GA = expected;
            actual = target.GA;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PS
        ///</summary>
        [TestMethod()]
        public void PSTest()
        {
            AgentInterior target = new AgentInterior();
            PointSet expected = target.Initialize();
            PointSet actual;
            target.PS = expected;
            actual = target.PS;
            Assert.AreEqual(expected, actual);

        }
    }
}
