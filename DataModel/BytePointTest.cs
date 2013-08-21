using Strategies.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGeneticAlgorithmAndDataModel
{
    
    
    /// <summary>
    ///This is a test class for BytePointTest and is intended
    ///to contain all BytePointTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BytePointTest
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
            byte[] tab = new byte[] { 1, 2, 3, 4, 5 };
            BytePoint target = new BytePoint(tab);
            byte[] expected = new byte[] { 1, 2, 3, 4, 5 };
            byte[] actual;
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
            byte[] tab = new byte[] { 1, 2, 3, 4, 5 };
            BytePoint target = new BytePoint(tab);
            string expected = "[1\t2\t3\t4\t5]";
            string actual;
            actual = target.StringRepresent();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for BytePoint Constructor
        ///</summary>
        [TestMethod()]
        public void BytePointConstructorTest()
        {
            BytePoint target = new BytePoint();
            Assert.AreEqual(target.Size, 0);
            Assert.IsNull(target.PointValues);
        }

        /// <summary>
        ///A test for BytePoint Constructor
        ///</summary>
        [TestMethod()]
        public void BytePointConstructorTest1()
        {
            byte value = 0;
            BytePoint target = new BytePoint(value);
            Assert.AreEqual(target.Size, 1);
            Assert.IsNotNull(target.PointValues);
        }

        /// <summary>
        ///A test for BytePoint Constructor
        ///</summary>
        [TestMethod()]
        public void BytePointConstructorTest2()
        {
            byte[] values = new byte[] { 3, 4, 5 };
            BytePoint target = new BytePoint(values);
            Assert.AreEqual(target.Size, 3);
            Assert.AreEqual(target.PointValues, values);
        }
    }
}
