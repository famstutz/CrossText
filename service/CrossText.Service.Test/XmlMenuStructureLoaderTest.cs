using CrossText.Service.MenuStructureLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CrossText.Service.DataContract;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for XmlMenuStructureLoaderTest and is intended
    ///to contain all XmlMenuStructureLoaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class XmlMenuStructureLoaderTest
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
        ///A test for XmlMenuStructureLoader Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void XmlMenuStructureLoaderConstructorTest()
        {
            string teletextStructureXml = string.Empty; // TODO: Initialize to an appropriate value
            string teletextStructureSchema = string.Empty; // TODO: Initialize to an appropriate value
            string teletextStructureSchemaNamespace = string.Empty; // TODO: Initialize to an appropriate value
            XmlMenuStructureLoader target = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for LoadMenuStructures
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void LoadMenuStructuresTest()
        {
            string teletextStructureXml = string.Empty; // TODO: Initialize to an appropriate value
            string teletextStructureSchema = string.Empty; // TODO: Initialize to an appropriate value
            string teletextStructureSchemaNamespace = string.Empty; // TODO: Initialize to an appropriate value
            XmlMenuStructureLoader target = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace); // TODO: Initialize to an appropriate value
            MenuStructureList expected = null; // TODO: Initialize to an appropriate value
            MenuStructureList actual;
            actual = target.LoadMenuStructures();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetTeletextStructureXml
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void SetTeletextStructureXmlTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0); // TODO: Initialize to an appropriate value
            string teletextStructureXml = string.Empty; // TODO: Initialize to an appropriate value
            string teletextStructureSchema = string.Empty; // TODO: Initialize to an appropriate value
            string teletextStructureSchemaNamespace = string.Empty; // TODO: Initialize to an appropriate value
            target.SetTeletextStructureXml(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TeletextStructureSchema
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void TeletextStructureSchemaTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TeletextStructureSchema = expected;
            actual = target.TeletextStructureSchema;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TeletextStructureSchemaNamespace
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void TeletextStructureSchemaNamespaceTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TeletextStructureSchemaNamespace = expected;
            actual = target.TeletextStructureSchemaNamespace;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TeletextStructureXml
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void TeletextStructureXmlTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TeletextStructureXml = expected;
            actual = target.TeletextStructureXml;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
