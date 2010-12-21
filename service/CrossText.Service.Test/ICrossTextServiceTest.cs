using CrossText.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CrossText.Service.DataContract;
using System.Configuration;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for ICrossTextServiceTest and is intended
    ///to contain all ICrossTextServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ICrossTextServiceTest
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


        internal virtual ICrossTextService CreateICrossTextService()
        {
            ICrossTextService target = new Service();
            return target;
        }

        /// <summary>
        ///A test for GetMenuStructure
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TeletextStructure.xml")]
        [DeploymentItem("TeletextStructure.xsd")]
        public void GetMenuStructureTest()
        {
            ICrossTextService target = CreateICrossTextService();
            MenuStructureList expected = new MenuStructureList() { 
                                            new MenuStructure() { SiteNumber = 101, Title = "News" },
                                            new MenuStructure() { SiteNumber = 200, Title = "Sport" },
                                            new MenuStructure() { SiteNumber = 300, Title = "TV/Radio" },
                                            new MenuStructure() { SiteNumber = 400, Title = "Reisen" },
                                            new MenuStructure() { SiteNumber = 500, Title = "Konsum" },
                                            new MenuStructure() { SiteNumber = 600, Title = "Finanzen" },
                                            new MenuStructure() { SiteNumber = 700, Title = "Entertainment" },
                                            new MenuStructure() { SiteNumber = 800, Title = "Freizeit" },
                                         };
            MenuStructureList actual = target.GetMenuStructure();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTeletextSite
        ///</summary>
        [TestMethod()]
        public void GetTeletextSiteTest()
        {
            ICrossTextService target = CreateICrossTextService(); // TODO: Initialize to an appropriate value
            int number = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetTeletextSite(number);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTeletextStructure
        ///</summary>
        [TestMethod()]
        public void GetTeletextStructureTest()
        {
            ICrossTextService target = CreateICrossTextService(); 
            int SiteNumber = 101; 
            TeletextStructureSite expected = new TeletextStructureSite(101);
            expected.SubSites.Add(1);
            TeletextStructureSite actual = target.GetTeletextStructure(SiteNumber);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTeletextSubSite
        ///</summary>
        [TestMethod()]
        public void GetTeletextSubSiteTest()
        {
            ICrossTextService target = CreateICrossTextService();
            int SiteNumber = 101;
            int subSiteNumber = 1;
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual = target.GetTeletextSubSite(SiteNumber, subSiteNumber);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMenuStructure
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void GetMenuStructureTest1()
        {
            ICrossTextService target = CreateICrossTextService(); // TODO: Initialize to an appropriate value
            MenuStructureList expected = null; // TODO: Initialize to an appropriate value
            MenuStructureList actual;
            actual = target.GetMenuStructure();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTeletextSite
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void GetTeletextSiteTest1()
        {
            ICrossTextService target = CreateICrossTextService(); // TODO: Initialize to an appropriate value
            int number = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetTeletextSite(number);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTeletextStructure
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void GetTeletextStructureTest1()
        {
            ICrossTextService target = CreateICrossTextService(); // TODO: Initialize to an appropriate value
            int SiteNumber = 0; // TODO: Initialize to an appropriate value
            TeletextStructureSite expected = null; // TODO: Initialize to an appropriate value
            TeletextStructureSite actual;
            actual = target.GetTeletextStructure(SiteNumber);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTeletextSubSite
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void GetTeletextSubSiteTest1()
        {
            ICrossTextService target = CreateICrossTextService(); // TODO: Initialize to an appropriate value
            int SiteNumber = 0; // TODO: Initialize to an appropriate value
            int subSiteNumber = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetTeletextSubSite(SiteNumber, subSiteNumber);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
