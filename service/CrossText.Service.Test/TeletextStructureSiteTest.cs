using CrossText.Service.DataContract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Collections.Generic;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for TeletextStructureSiteTest and is intended
    ///to contain all TeletextStructureSiteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TeletextStructureSiteTest
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
        ///A test for TeletextStructureSite Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void TeletextStructureSiteConstructorTest()
        {
            int siteNumber = 0; // TODO: Initialize to an appropriate value
            TeletextStructureSite target = new TeletextStructureSite(siteNumber);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SiteNumber
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void SiteNumberTest()
        {
            int siteNumber = 0; // TODO: Initialize to an appropriate value
            TeletextStructureSite target = new TeletextStructureSite(siteNumber); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.SiteNumber = expected;
            actual = target.SiteNumber;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SubSites
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void SubSitesTest()
        {
            int siteNumber = 0; // TODO: Initialize to an appropriate value
            TeletextStructureSite target = new TeletextStructureSite(siteNumber); // TODO: Initialize to an appropriate value
            List<int> expected = null; // TODO: Initialize to an appropriate value
            List<int> actual;
            target.SubSites = expected;
            actual = target.SubSites;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TeletextStructureSite Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void TeletextStructureSiteConstructorTest1()
        {
            int siteNumber = 0; // TODO: Initialize to an appropriate value
            TeletextStructureSite target = new TeletextStructureSite(siteNumber);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SiteNumber
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void SiteNumberTest1()
        {
            int siteNumber = 0; // TODO: Initialize to an appropriate value
            TeletextStructureSite target = new TeletextStructureSite(siteNumber); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.SiteNumber = expected;
            actual = target.SiteNumber;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SubSites
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void SubSitesTest1()
        {
            int siteNumber = 0; // TODO: Initialize to an appropriate value
            TeletextStructureSite target = new TeletextStructureSite(siteNumber); // TODO: Initialize to an appropriate value
            List<int> expected = null; // TODO: Initialize to an appropriate value
            List<int> actual;
            target.SubSites = expected;
            actual = target.SubSites;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
