using CrossText.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CrossText.Service.DataContract;

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

        private MenuStructureList MenuStructureList
        {
            get
            {
                return new MenuStructureList() {
                    new MenuStructure() { SiteNumber = 101, Title = "News" },
                    new MenuStructure() { SiteNumber = 200, Title = "Sport" },
                    new MenuStructure() { SiteNumber = 300, Title = "TV/Radio" },
                    new MenuStructure() { SiteNumber = 400, Title = "Reisen" },
                    new MenuStructure() { SiteNumber = 500, Title = "Konsum" },
                    new MenuStructure() { SiteNumber = 600, Title = "Finanzen" },
                    new MenuStructure() { SiteNumber = 700, Title = "Entertainment" },
                    new MenuStructure() { SiteNumber = 800, Title = "Freizeit" }
                };
            }
        }

        /// <summary>
        ///A test for Service Constructor
        ///</summary>
        [TestMethod()]
        public void ServiceConstructorTest()
        {
            Service target = new Service();
            bool expected = true;
            Assert.AreEqual(expected, target != null);
        }

        /// <summary>
        ///A test for GetMenuStructure
        ///</summary>
        [TestMethod()]
        public void GetMenuStructureTest()
        {
            Service target = new Service(); 
            MenuStructureList expected = MenuStructureList;
            MenuStructureList actual;
            actual = target.GetMenuStructure();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTeletextSite
        ///</summary>
        [TestMethod()]
        public void GetTeletextSiteTest()
        {
            Service target = new Service();
            int number = 241;
            string expected = "data:image/gif;base64,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";

            string actual = target.GetTeletextSite(number);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTeletextStructure
        ///</summary>
        [TestMethod()]
        public void GetTeletextStructureTest()
        {
            Service target = new Service();
            int SiteNumber = 100;
            TeletextStructureSite expected = new TeletextStructureSite(100);
            TeletextStructureSite actual;
            actual = target.GetTeletextStructure(SiteNumber);
            Assert.AreEqual(expected.SiteNumber, actual.SiteNumber);
        }

        /// <summary>
        ///A test for GetTeletextSubSite
        ///</summary>
        [TestMethod()]
        public void GetTeletextSubSiteTest()
        {
            Service target = new Service();
            int SiteNumber = 256;
            int subSiteNumber = 2;
            string expected = "data:image/gif;base64,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";
            string actual;
            actual = target.GetTeletextSubSite(SiteNumber, subSiteNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
