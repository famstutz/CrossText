using CrossText.Service.SiteCaching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for CacheItemTest and is intended
    ///to contain all CacheItemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CacheItemTest
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
        ///A test for CacheItem`1 Constructor
        ///</summary>
        public void CacheItemConstructorTestHelper<TValue>()
        {
            String value = "Test-Value";
            CacheItem<String> target = new CacheItem<String>(value);
            Assert.AreEqual(value, target.Value);
        }

        [TestMethod()]
        public void CacheItemConstructorTest()
        {
            CacheItemConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CacheItem`1 Constructor
        ///</summary>
        public void CacheItemConstructorTest1Helper<TValue>()
        {
            CacheItem<TValue> target = new CacheItem<TValue>();
            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void CacheItemConstructorTest1()
        {
            CacheItemConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CacheTime
        ///</summary>
        public void CacheTimeTestHelper<TValue>()
        {
            CacheItem<String> target = new CacheItem<String>("Test-Value"); 
            DateTime expected = new DateTime(); 
            DateTime actual;
            target.CacheTime = expected;
            actual = target.CacheTime;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CacheTimeTest()
        {
            CacheTimeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        public void ValueTestHelper<TValue>()
        {
            CacheItem<String> target = new CacheItem<String>("Test-Value");
            String expected = "Test-Value";
            String actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValueTest()
        {
            ValueTestHelper<GenericParameterHelper>();
        }
    }
}
