using CrossText.Service.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for UrlFormatterTest and is intended
    ///to contain all UrlFormatterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UrlFormatterTest
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
        ///A test for FormatTeletextUrl
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void FormatTeletextUrlTest()
        {
            string baseUrl = "http://www.teletext.ch/pics/SF1/{0}-{1}.gif";
            int siteNumber = 500;
            int subSiteNumber = 5;
            string expected = "http://www.teletext.ch/pics/SF1/500-05.gif";
            string actual;
            actual = UrlFormatter.FormatTeletextUrl(baseUrl, siteNumber, subSiteNumber);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FormatTeletextUrl
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void FormatTeletextUrlTest1()
        {
            int siteNumber = 500;
            int subSiteNumber = 5;
            string expected = "http://www.teletext.ch/pics/SF1/500-05.gif";
            string actual;
            actual = UrlFormatter.FormatTeletextUrl(siteNumber, subSiteNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
