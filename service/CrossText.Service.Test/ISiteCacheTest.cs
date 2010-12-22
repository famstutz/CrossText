using CrossText.Service.SiteCaching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Collections.Generic;
using System.IO;

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
        private string XmlFile
        {
            get
            {
                return BaseDirectory + "Cache.xml";
            }
        }

        private string BaseDirectory
        {
            get
            {
                String baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                baseDirectory = !baseDirectory.EndsWith("\\") ? baseDirectory + "\\" : baseDirectory;
                return baseDirectory;
            }
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        public void ClearTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); 
            target.Clear();
            Assert.IsTrue(target.Keys.Count == 0 && target.Count == 0);
        }

        internal virtual ISiteCache<TKey, TValue> CreateISiteCache<TKey, TValue>()
        {
            CreateXmlSampleFile(XmlFile);
            ISiteCache<TKey, TValue> target = new SerializableSiteCache<TKey, TValue>(XmlFile);
            return target;
        }

        private void CreateXmlSampleFile(string xmlFile)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            File.WriteAllText(xmlFile, enc.GetString(GetXmlSampleData()));
        }
        private byte[] GetXmlSampleData()
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            return enc.GetBytes("<?xml version=\"1.0\" encoding=\"utf-8\"?><DictionaryItems><Item><Key><string>http://www.teletext.ch/pics/SF1/100-01.gif</string></Key><Value><CacheItemOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Value>data:image/gif;base64,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</Value><CacheTime>2010-12-21T19:46:10.4039608+01:00</CacheTime></CacheItemOfString></Value></Item></DictionaryItems>");
        }

        [TestMethod()]
        public void ClearTest()
        {
            ClearTestHelper<string, string>();
        }

        /// <summary>
        ///A test for ContainsKey
        ///</summary>
        public void ContainsKeyTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); 
            TKey key = default(TKey);
            bool expected = false; 
            bool actual;
            actual = target.ContainsKey(key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ContainsKeyTest()
        {
            //ContainsKeyTestHelper<int, String>();
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        public void GetTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); 
            TKey key = default(TKey); 
            TValue expected = default(TValue);
            TValue actual;
            actual = target.Get(key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTest()
        {
            GetTestHelper<string, string>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); 
            TKey key = default(TKey); 
            TValue value = default(TValue);
            target.Insert(key, value);
        }

        [TestMethod()]
        public void InsertTest()
        {
            InsertTestHelper<string, string>();
        }

        /// <summary>
        ///A test for IsExpired
        ///</summary>
        public void IsExpiredTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); 
            TKey key = default(TKey); 
            bool expected = false; 
            bool actual;
            actual = target.IsExpired(key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsExpiredTest()
        {
            IsExpiredTestHelper<string, string>();
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        public void RemoveTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>();
            TKey key = default(TKey); 
            target.Remove(key);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            RemoveTestHelper<string, string>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>();
            int actual;
            actual = target.Count;
        }

        [TestMethod()]
        public void CountTest()
        {
            CountTestHelper<string, string>();
        }

        /// <summary>
        ///A test for ExpirySpan
        ///</summary>
        public void ExpirySpanTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); 
            TimeSpan expected = new TimeSpan(1, 0, 0); 
            TimeSpan actual;
            target.ExpirySpan = expected;
            actual = target.ExpirySpan;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ExpirySpanTest()
        {
            ExpirySpanTestHelper<string, string>();
        }

        /// <summary>
        ///A test for Keys
        ///</summary>
        public void KeysTestHelper<TKey, TValue>()
        {
            ISiteCache<TKey, TValue> target = CreateISiteCache<TKey, TValue>(); 
            List<TKey> actual;
            actual = target.Keys;
            Assert.IsInstanceOfType(actual, typeof(List<TKey>));
        }

        [TestMethod()]
        public void KeysTest()
        {
            KeysTestHelper<string, string>();
        }
    }
}
