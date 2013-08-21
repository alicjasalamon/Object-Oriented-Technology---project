using Strategies.GA.Initialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Strategies.DataModel;
using System.Collections.Generic;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for ByteInitialization_RandomTest and is intended
    ///to contain all ByteInitialization_RandomTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ByteInitialization_RandomTest
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
        ///A test for ByteInitialization_Random Constructor
        ///</summary>
        [TestMethod()]
        public void ByteInitialization_RandomConstructorTest()
        {
            int howMany = 4;
            int size = 5;
            ByteInitialization_Random target = new ByteInitialization_Random(howMany, size);
            Assert.AreEqual(target.Type, OperatorType.Byte);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest()
        {
            int howMany = 5;
            int size = 4;
            ByteInitialization_Random target = new ByteInitialization_Random(howMany, size); 
            BytePoint p1 = new BytePoint(new byte[]{1,2,3,4});
            BytePoint p2 = new BytePoint(new byte[]{17,2,3,46});
            BytePoint p3 = new BytePoint(new byte[]{4,2,36,4});
            BytePoint p4 = new BytePoint(new byte[]{7,26,3,4});
            BytePoint p5 = new BytePoint(new byte[]{35,2,33,4});

            PointSet expected = new PointSet(new HashSet<Point>() { p1, p2, p3, p4, p5 });
            PointSet actual;
            actual = target.Create();
            Assert.AreEqual(expected.Set.Count, actual.Set.Count);
            //tu sprawdzic rozmiary
            //Assert.AreEqual(expected.Set.g, actual.Set.Count);
        }
    }
}
