using Strategies.GA.Mutation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for ByteMutation_ValueAddedTest and is intended
    ///to contain all ByteMutation_ValueAddedTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ByteMutation_ValueAddedTest
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
        ///A test for ByteMutation_ValueAdded Constructor
        ///</summary>
        [TestMethod()]
        public void ByteMutation_ValueAddedConstructorTest()
        {
            int added = 2;
            ByteMutation_ValueAdded target = new ByteMutation_ValueAdded(added);
            Assert.AreEqual(target.Type, OperatorType.Byte);
        }

        /// <summary>
        ///A test for Mutate
        ///</summary>
        [TestMethod()]
        public void MutateTest()
        {
            int added = 2;
            ByteMutation_ValueAdded target = new ByteMutation_ValueAdded(added); 
            Point point = new BytePoint(10);
            Point actual;
            actual = target.Mutate(point);
            Assert.IsTrue(actual.StringRepresent().Equals("[12]") || actual.StringRepresent().Equals("[8]"));
        }

        /// <summary>
        ///A test for Operate
        ///</summary>
        [TestMethod()]
        public void OperateTest()
        {
            int added = 2;
            ByteMutation_ValueAdded target = new ByteMutation_ValueAdded(added);
            BytePoint p1 = new BytePoint(new byte[] { 1, 2, 3, 4 });
            BytePoint p2 = new BytePoint(new byte[] { 17, 2, 3, 46 });
            BytePoint p3 = new BytePoint(new byte[] { 4, 2, 36, 4 });
            BytePoint p4 = new BytePoint(new byte[] { 7, 26, 3, 4 });
            BytePoint p5 = new BytePoint(new byte[] { 35, 2, 33, 4 });

            PointSet expected = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5 });

            PointSet pointSet = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5 });
            PointSet actual;
            actual = target.Operate(pointSet);
            Assert.AreEqual(expected.Set.Count, actual.Set.Count);
        }
    }
}
