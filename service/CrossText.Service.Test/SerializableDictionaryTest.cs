using CrossText.Service.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Xml.Schema;
using System.Xml;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for SerializableDictionaryTest and is intended
    ///to contain all SerializableDictionaryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SerializableDictionaryTest
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
        ///A test for SerializableDictionary`2 Constructor
        ///</summary>
        public void SerializableDictionaryConstructorTestHelper<TKey, TValue>()
        {
            SerializableDictionary<TKey, TValue> target = new SerializableDictionary<TKey, TValue>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void SerializableDictionaryConstructorTest()
        {
            SerializableDictionaryConstructorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetSchema
        ///</summary>
        public void GetSchemaTestHelper<TKey, TValue>()
        {
            SerializableDictionary<TKey, TValue> target = new SerializableDictionary<TKey, TValue>(); // TODO: Initialize to an appropriate value
            XmlSchema expected = null; // TODO: Initialize to an appropriate value
            XmlSchema actual;
            actual = target.GetSchema();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetSchemaTest()
        {
            GetSchemaTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ReadXml
        ///</summary>
        public void ReadXmlTestHelper<TKey, TValue>()
        {
            SerializableDictionary<TKey, TValue> target = new SerializableDictionary<TKey, TValue>(); // TODO: Initialize to an appropriate value
            XmlReader reader = null; // TODO: Initialize to an appropriate value
            target.ReadXml(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ReadXmlTest()
        {
            ReadXmlTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for WriteXml
        ///</summary>
        public void WriteXmlTestHelper<TKey, TValue>()
        {
            SerializableDictionary<TKey, TValue> target = new SerializableDictionary<TKey, TValue>(); // TODO: Initialize to an appropriate value
            XmlWriter writer = null; // TODO: Initialize to an appropriate value
            target.WriteXml(writer);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void WriteXmlTest()
        {
            WriteXmlTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
