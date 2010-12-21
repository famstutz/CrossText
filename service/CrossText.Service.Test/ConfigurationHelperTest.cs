using CrossText.Service.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Configuration;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for ConfigurationHelperTest and is intended
    ///to contain all ConfigurationHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConfigurationHelperTest
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
        ///A test for GetSetting
        ///</summary>
        public void GetSettingTestHelper<T>()
        {
            string settingKey = "ImageMimeType";
            string expected = ConfigurationManager.AppSettings["ImageMimeType"];
            T actual = ConfigurationHelper_Accessor.GetSetting<T>(settingKey);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetSettingTest()
        {
            GetSettingTestHelper<string>();
        }

        /// <summary>
        ///A test for ImageMimeType
        ///</summary>
        [TestMethod()]
        public void ImageMimeTypeTest()
        {
            string expected = ConfigurationManager.AppSettings["ImageMimeType"];
            string actual = ConfigurationHelper.ImageMimeType;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TeletextBaseUrl
        ///</summary>
        [TestMethod()]
        public void TeletextBaseUrlTest()
        {
            string expected = ConfigurationManager.AppSettings["TeletextBaseUrl"];
            string actual = ConfigurationHelper.TeletextBaseUrl;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TeletextTeletextStructureDefinition
        ///</summary>
        [TestMethod()]
        public void TeletextTeletextStructureDefinitionTest()
        {
            string expected = ConfigurationManager.AppSettings["TeletextStructureDefinition"];
            string actual = ConfigurationHelper.TeletextStructureDefinition;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TeletextTeletextStructureSchema
        ///</summary>
        [TestMethod()]
        public void TeletextTeletextStructureSchemaTest()
        {
            string expected = ConfigurationManager.AppSettings["TeletextStructureSchema"];
            string actual = ConfigurationHelper.TeletextStructureSchema;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TeletextTeletextStructureSchemaNamespace
        ///</summary>
        [TestMethod()]
        public void TeletextTeletextStructureSchemaNamespaceTest()
        {
            string expected = ConfigurationManager.AppSettings["TeletextStructureSchemaNamespace"];
            string actual = ConfigurationHelper.TeletextStructureSchemaNamespace;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetSetting
        ///</summary>
        public void GetSettingTest1Helper<T>()
        {
            string settingKey = string.Empty; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = ConfigurationHelper_Accessor.GetSetting<T>(settingKey);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void GetSettingTest1()
        {
            GetSettingTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ImageMimeType
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void ImageMimeTypeTest1()
        {
            string actual;
            actual = ConfigurationHelper.ImageMimeType;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TeletextBaseUrl
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void TeletextBaseUrlTest1()
        {
            string actual;
            actual = ConfigurationHelper.TeletextBaseUrl;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TeletextStructureDefinition
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void TeletextStructureDefinitionTest()
        {
            string actual;
            actual = ConfigurationHelper.TeletextStructureDefinition;
            Assert.Inconclusive("Verify the correctness of this test method.");
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
        public void TeletextStructureSchemaTest()
        {
            string actual;
            actual = ConfigurationHelper.TeletextStructureSchema;
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
        public void TeletextStructureSchemaNamespaceTest()
        {
            string actual;
            actual = ConfigurationHelper.TeletextStructureSchemaNamespace;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
