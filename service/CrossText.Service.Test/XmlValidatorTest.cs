using CrossText.Service.Helpers.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Xml.Schema;
using CrossText.Service.Helpers;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for XmlValidatorTest and is intended
    ///to contain all XmlValidatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class XmlValidatorTest
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
        ///A test for XmlValidator Constructor
        ///</summary>
        [TestMethod()]
        public void XmlValidatorConstructorTest()
        {
            string xmlFile = XmlFile;
            string schemaFile = XmlSchemaFile;
            XmlValidator target = new XmlValidator(xmlFile, schemaFile);
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for CustomValidationEventHandler
        ///</summary>
        [TestMethod()]
        public void CustomValidationEventHandlerTest()
        {
            string xmlFile = XmlFile;
            string schemaFile = XmlSchemaFile;
            XmlValidator target = new XmlValidator(xmlFile, schemaFile);
            object sender = this;
            target.CustomValidationEventHandler(sender, null);
            Assert.IsTrue(target.IsValid());
        }

        /// <summary>
        ///A test for IsValid
        ///</summary>
        [TestMethod()]
        public void IsValidTest()
        {
            string xmlFile = XmlFile;
            string schemaFile = XmlSchemaFile;
            XmlValidator target = new XmlValidator(xmlFile, schemaFile); 
            bool expected = true;
            bool actual;
            actual = target.IsValid();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsValidFlag
        ///</summary>
        [TestMethod()]
        public void IsValidFlagTest()
        {
            string xmlFile = XmlFile;
            string schemaFile = XmlSchemaFile;
            XmlValidator_Accessor target = new XmlValidator_Accessor(xmlFile, schemaFile);
            bool expected = true; 
            bool actual;
            target.IsValidFlag = expected;
            actual = target.IsValidFlag;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SchemaFile
        ///</summary>
        [TestMethod()]
        public void SchemaFileTest()
        {
            string xmlFile = XmlFile;
            string schemaFile = XmlSchemaFile;
            XmlValidator_Accessor target = new XmlValidator_Accessor(xmlFile, schemaFile);
            string expected = schemaFile;
            string actual;
            target.SchemaFile = expected;
            actual = target.SchemaFile;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for XmlFile
        ///</summary>
        [TestMethod()]
        public void XmlFileTest()
        {
            string xmlFile = XmlFile;
            string schemaFile = XmlSchemaFile;
            XmlValidator_Accessor target = new XmlValidator_Accessor(xmlFile, schemaFile);
            string expected = xmlFile;
            string actual;
            target.XmlFile = expected;
            actual = target.XmlFile;
            Assert.AreEqual(expected, actual);
        }
    }
}
