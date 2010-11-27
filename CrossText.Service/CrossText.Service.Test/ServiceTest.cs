using CrossText.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CrossText.Service.DataContract;
using System.Configuration;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for ServiceTest and is intended
    ///to contain all ServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ServiceTest
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
        ///A test for Service Constructor
        ///</summary>
        [TestMethod()]
        public void ServiceConstructorTest()
        {
            Service target = new Service();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for GetMenuStructure
        ///</summary>
        [TestMethod()]
        public void GetMenuStructureTest()
        {
            Service target = new Service();
            MenuStructureList expected = new MenuStructureList() {
                new MenuStructure() { SiteNumber = 101, Title = "News" },
                new MenuStructure() { SiteNumber = 200, Title = "Sport" },
                new MenuStructure() { SiteNumber = 300, Title = "TV/Radio" },
                new MenuStructure() { SiteNumber = 400, Title = "Reisen" },
                new MenuStructure() { SiteNumber = 500, Title = "Konsum" },
                new MenuStructure() { SiteNumber = 600, Title = "Finanzen" },
                new MenuStructure() { SiteNumber = 700, Title = "Entertainment" },
                new MenuStructure() { SiteNumber = 800, Title = "Freizeit" }
            }; 
            MenuStructureList actual;
            actual = target.GetMenuStructure();
            Assert.IsTrue(expected.Equals(actual));
        }

        /// <summary>
        ///A test for GetTeletextSite
        ///</summary>
        [TestMethod()]
        public void GetTeletextSiteTest()
        {
            Service target = new Service();
            int number = 101;
            byte[] expected = Helper.GetImageFromURL(string.Format("http://www.teletext.ch/pics/SF1/{0}-{1}.gif", number, "00"));
            byte[] actual;
            actual = target.GetTeletextSite(number);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTeletextStructure
        ///</summary>
        [TestMethod()]
        public void GetTeletextStructureTest()
        {
            Service target = new Service(); // TODO: Initialize to an appropriate value
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
        [TestMethod()]
        public void GetTeletextSubSiteTest()
        {
            Service target = new Service(); // TODO: Initialize to an appropriate value
            int SiteNumber = 0; // TODO: Initialize to an appropriate value
            int subSiteNumber = 0; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = target.GetTeletextSubSite(SiteNumber, subSiteNumber);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
