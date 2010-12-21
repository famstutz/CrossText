using CrossText.Service.SiteCaching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
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
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void SerializableSiteCacheConstructorTest()
        {
            SerializableSiteCacheConstructorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        public void ClearTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ClearTest()
        {
            ClearTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ContainsKey
        ///</summary>
        public void ContainsKeyTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ContainsKey(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ContainsKeyTest()
        {
            ContainsKeyTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        public void DisposeTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void DisposeTest()
        {
            DisposeTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        public void GetTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            TValue expected = default(TValue); // TODO: Initialize to an appropriate value
            TValue actual;
            actual = target.Get(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetTest()
        {
            GetTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        public void GetItemTestHelper<TKey, TValue>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(param0); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            CacheItem<TValue> expected = null; // TODO: Initialize to an appropriate value
            CacheItem<TValue> actual;
            actual = target.GetItem(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetItemTest()
        {
            GetItemTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            TValue value = default(TValue); // TODO: Initialize to an appropriate value
            target.Insert(key, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void InsertTest()
        {
            InsertTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsExpired
        ///</summary>
        public void IsExpiredTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsExpired(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsExpiredTest()
        {
            IsExpiredTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ReadSerializedXml
        ///</summary>
        public void ReadSerializedXmlTestHelper<TKey, TValue>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(param0); // TODO: Initialize to an appropriate value
            target.ReadSerializedXml();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ReadSerializedXmlTest()
        {
            ReadSerializedXmlTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        public void RemoveTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            TKey key = default(TKey); // TODO: Initialize to an appropriate value
            target.Remove(key);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void RemoveTest()
        {
            RemoveTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for WriteSerializedXml
        ///</summary>
        public void WriteSerializedXmlTestHelper<TKey, TValue>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(param0); // TODO: Initialize to an appropriate value
            target.WriteSerializedXml();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void WriteSerializedXmlTest()
        {
            WriteSerializedXmlTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CountTest()
        {
            CountTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Dictionary
        ///</summary>
        public void DictionaryTestHelper<TKey, TValue>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            SerializableSiteCache_Accessor<TKey, TValue> target = new SerializableSiteCache_Accessor<TKey, TValue>(param0); // TODO: Initialize to an appropriate value
            SerializableDictionary<TKey, CacheItem<TValue>> expected = null; // TODO: Initialize to an appropriate value
            SerializableDictionary<TKey, CacheItem<TValue>> actual;
            target.Dictionary = expected;
            actual = target.Dictionary;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DictionaryTest()
        {
            DictionaryTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExpirySpan
        ///</summary>
        public void ExpirySpanTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            TimeSpan expected = new TimeSpan(); // TODO: Initialize to an appropriate value
            TimeSpan actual;
            target.ExpirySpan = expected;
            actual = target.ExpirySpan;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExpirySpanTest()
        {
            ExpirySpanTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        public void KeysTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            List<TKey> actual;
            actual = target.Keys;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void KeysTest()
        {
            KeysTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for XmlFilePath
        ///</summary>
        public void XmlFilePathTestHelper<TKey, TValue>()
        {
            string xmlFilePath = string.Empty; // TODO: Initialize to an appropriate value
            SerializableSiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(xmlFilePath); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.XmlFilePath = expected;
            actual = target.XmlFilePath;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void XmlFilePathTest()
        {
            XmlFilePathTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
