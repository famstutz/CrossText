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
            TValue value = default(TValue); // TODO: Initialize to an appropriate value
            CacheItem<TValue> target = new CacheItem<TValue>(value);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
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
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void CacheItemConstructorTest1()
        {
            CacheItemConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CacheTime
        ///</summary>
        public void CacheTimeTestHelper<TValue>()
        {
            CacheItem<TValue> target = new CacheItem<TValue>(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.CacheTime = expected;
            actual = target.CacheTime;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void CacheTimeTest()
        {
            CacheTimeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        public void ValueTestHelper<TValue>()
        {
            CacheItem<TValue> target = new CacheItem<TValue>(); // TODO: Initialize to an appropriate value
            TValue expected = default(TValue); // TODO: Initialize to an appropriate value
            TValue actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void ValueTest()
        {
            ValueTestHelper<GenericParameterHelper>();
        }
    }
}
