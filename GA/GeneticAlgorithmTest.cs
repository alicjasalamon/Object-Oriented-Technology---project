using Strategies.GA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.GA.Evaluation;
using Strategies.GA.Selection;
using Strategies.GA.Mutation;
using Strategies.GA.Crossover;
using System.Collections.Generic;
using Strategies.GA.Initialization;
using Strategies.DataModel;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for GeneticAlgorithmTest and is intended
    ///to contain all GeneticAlgorithmTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GeneticAlgorithmTest
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
        ///A test for Operations
        ///</summary>
        [TestMethod()]
        public void OperationsTest()
        {
            EvaluationIF e = new DoubleEvaluation_Logarithmic();
            GeneticAlgorithm target = new GeneticAlgorithm(e);
            IList<Operator> expected = new List<Operator>();
            SelectionIF S = new Selection_PercentAboveAverage(50);
            CrossoverIF C2 = new DoubleCrossover_Random();
            MutationIF M = new DoubleMutation_ValuePercent(5.0);

            expected.Add(S);
            expected.Add(C2);
            expected.Add(M);
            IList<Operator> actual;
            target.Operations = expected;
            actual = target.Operations;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Initialization
        ///</summary>
        [TestMethod()]
        public void InitializationTest()
        {
            EvaluationIF e = new ByteEvaluation_Ones();
            GeneticAlgorithm target = new GeneticAlgorithm(e);
            InitializationIF expected = new ByteInitialization_Regular(10, 5);
            InitializationIF actual;
            target.Initialization = expected;
            actual = target.Initialization;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Evaluation
        ///</summary>
        [TestMethod()]
        public void EvaluationTest()
        {
            EvaluationIF e = new ByteEvaluation_Zeros();
            GeneticAlgorithm target = new GeneticAlgorithm(e);
            EvaluationIF expected = e;
            EvaluationIF actual;
            target.Evaluation = expected;
            actual = target.Evaluation;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///A test for GeneticAlgorithm Constructor
        ///</summary>
        [TestMethod()]
        public void GeneticAlgorithmConstructorTest()
        {
            List<Operator> operators = new List<Operator>();
            SelectionIF S = new Selection_PercentAboveAverage(50);
            CrossoverIF C2 = new DoubleCrossover_Random();
            MutationIF M = new DoubleMutation_ValuePercent(5.0);

            operators.Add(S);
            operators.Add(C2);
            operators.Add(M);

            double[] p1 = { 0.0, 0.0 };
            double[] p2 = { 5.0, 5.0 };

            InitializationIF initialization = new DoubleInitialization_RandomBetweenTwoPoints(
                new DoublePoint(p1), new DoublePoint(p2), 10);

            EvaluationIF evaluation = new DoubleEvaluation_Trigonometric();
            GeneticAlgorithm target = new GeneticAlgorithm(operators, initialization, evaluation);

            Assert.IsNotNull(target.Operations);
            Assert.IsNotNull(target.Initialization);
            Assert.IsNotNull(target.Evaluation);
        }

        /// <summary>
        ///A test for GeneticAlgorithm Constructor
        ///</summary>
        [TestMethod()]
        public void GeneticAlgorithmConstructorTest1()
        {
            EvaluationIF e = new DoubleEvaluation_Trigonometric();
            GeneticAlgorithm target = new GeneticAlgorithm(e);

            Assert.IsNotNull(target.Operations);
            Assert.IsNotNull(target.Initialization);
            Assert.IsNotNull(target.Evaluation);
        }
    }
}
