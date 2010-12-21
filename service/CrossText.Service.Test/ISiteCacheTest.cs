using CrossText.Service.SiteCaching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Collections.Generic;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for ISiteCacheTest and is intended
    ///to contain all ISiteCacheTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ISiteCacheTest
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
        ///A test for Clear
        ///</summary>
        public void ClearTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        internal virtual ISiteCache<TKey, TValue> CreateISiteCache<TKey, TValue>()
        {
            // TODO: Instantiate an appropriate concrete class.
            ISiteCache<TKey, TValue> target = null;
            return target;
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void ClearTest()
        {
            ClearTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContainsKey
        ///</summary>
        public void ContainsKeyTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ContainsKey(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void ContainsKeyTest()
        {
            ContainsKeyTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        public void GetTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            TValue expected = default(TValue); // TODO: Initialize to an appropriate value
            TValue actual;
            actual = target.Get(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void GetTest()
        {
            GetTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            TValue value = default(TValue); // TODO: Initialize to an appropriate value
            target.Insert(key, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void InsertTest()
        {
            InsertTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsExpired
        ///</summary>
        public void IsExpiredTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsExpired(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void IsExpiredTest()
        {
            IsExpiredTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        public void RemoveTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            target.Remove(key);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void RemoveTest()
        {
            RemoveTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void CountTest()
        {
            CountTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExpirySpan
        ///</summary>
        public void ExpirySpanTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            TimeSpan expected = new TimeSpan(); // TODO: Initialize to an appropriate value
            TimeSpan actual;
            target.ExpirySpan = expected;
            actual = target.ExpirySpan;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void ExpirySpanTest()
        {
            ExpirySpanTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        public void KeysTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); // TODO: Initialize to an appropriate value
            List<TKey> actual;
            actual = target.Keys;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void KeysTest()
        {
            KeysTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
