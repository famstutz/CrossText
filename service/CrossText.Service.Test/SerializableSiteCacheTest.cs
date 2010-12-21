using CrossText.Service.SiteCaching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Xml;
using CrossText.Service.Serialization;
using System.Collections.Generic;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for SerializableSiteCacheTest and is intended
    ///to contain all SerializableSiteCacheTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SerializableSiteCacheTest
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
        ///A test for SerializableSiteCache`2 Constructor
        ///</summary>
        public void SerializableSiteCacheConstructorTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void SerializableSiteCacheConstructorTest()
        {
            SerializableSiteCacheConstructorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        public void ClearTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
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
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
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
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
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
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
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
        ///A test for ReadXml
        ///</summary>
        public void ReadXmlTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
            XmlReader reader = null; // TODO: Initialize to an appropriate value
            target.ReadXml(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void ReadXmlTest()
        {
            ReadXmlTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        public void RemoveTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
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
        ///A test for WriteXml
        ///</summary>
        public void WriteXmlTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
            XmlWriter writer = null; // TODO: Initialize to an appropriate value
            target.WriteXml(writer);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void WriteXmlTest()
        {
            WriteXmlTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
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
        ///A test for Dictionary
        ///</summary>
        public void DictionaryTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
            SerializableDictionary<TKey, TValue> expected = null; // TODO: Initialize to an appropriate value
            SerializableDictionary<TKey, TValue> actual;
            target.Dictionary = expected;
            actual = target.Dictionary;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void DictionaryTest()
        {
            DictionaryTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Instance
        ///</summary>
        public void InstanceTestHelper<TKey, TValue>()
        {
            SerializableSiteCache<TKey, TValue> actual;
            actual = SerializableSiteCache<TKey, TValue>.Instance;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void InstanceTest()
        {
            InstanceTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        public void KeysTestHelper<TKey, TValue>()
        {
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(); // TODO: Initialize to an appropriate value
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
