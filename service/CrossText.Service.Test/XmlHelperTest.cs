using CrossText.Service.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for XmlHelperTest and is intended
    ///to contain all XmlHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class XmlHelperTest
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
                return BaseDirectory + "TeletextStructure.xml";
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

        private string XmlSchemaFile
        {
            get
            {
                return BaseDirectory + "TeletextStructure.xsd";
            }
        }

        /// <summary>
        ///A test for IsValidXml
        ///</summary>
        [TestMethod()]
        public void IsValidXmlTest()
        {
            string xmlFile = XmlFile;
            string schemaFile = XmlSchemaFile;
            bool expected = true;
            bool actual;
            actual = XmlHelper.IsValidXml(xmlFile, schemaFile);
            Assert.AreEqual(expected, actual);
        }
    }
}
