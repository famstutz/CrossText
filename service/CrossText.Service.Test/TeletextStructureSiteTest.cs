using CrossText.Service.DataContract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Collections.Generic;
using System.Configuration;

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
        [TestMethod()]
        public void TeletextStructureSiteConstructorTest()
        {
            int siteNumber = 241;
            TeletextStructureSite target = new TeletextStructureSite(siteNumber);

            Assert.AreEqual(target.SiteNumber, 241);
        }

        /// <summary>
        ///A test for SiteNumber
        ///</summary>
        [TestMethod()]
        public void SiteNumberTest()
        {
            string Url = string.Format("http://www.teletext.ch/pics/SF1/{0}-{1}.gif", 100, "01");

            // get the Byte Array first and convert it to Base64Data Object
            Byte[] image1 = Helper.GetImageFromURL(Url);
            string site1 = Helper.GetBase64DataURI("image/gif", image1);

            Byte[] image2 = Helper.GetImageFromURL(Url);
            string site2 = Helper.GetBase64DataURI("image/gif", image2);

            Assert.AreEqual(site1, site2);
        }

        /// <summary>
        ///A test for SubSites
        ///</summary>
        [TestMethod()]
        public void SubSitesTest()
        {
          string Url = string.Format("http://www.teletext.ch/pics/SF1/{0}-{1}.gif", 256, "02");

          // get the Byte Array first and convert it to Base64Data Object
          Byte[] image1 = Helper.GetImageFromURL(Url);
          string site1 = Helper.GetBase64DataURI("image/gif", image1);

          Byte[] image2 = Helper.GetImageFromURL(Url);
          string site2 = Helper.GetBase64DataURI("image/gif", image2);
        }
    }
}
