using CrossText.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CrossText.Service.DataContract;

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

        internal virtual ICrossTextService CreateICrossTextService()
        {
            ICrossTextService target = new Service();
            return target;
        }

        /// <summary>
        ///A test for GetMenuStructure
        ///</summary>
        [TestMethod()]
        public void GetMenuStructureTest()
        {
            ICrossTextService target = CreateICrossTextService();
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
            ICrossTextService target = CreateICrossTextService();
            int number = 241;
            string expected = "data:image/gif;base64,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";
            string actual;
            actual = target.GetTeletextSite(number);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTeletextStructure
        ///</summary>
        [TestMethod()]
        public void GetTeletextStructureTest()
        {
            ICrossTextService target = CreateICrossTextService();
            int SiteNumber = 241;
            TeletextStructureSite expected = target.GetTeletextStructure(SiteNumber);
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
            int SiteNumber = 256;
            int subSiteNumber = 2;
            string expected = target.GetTeletextSubSite(SiteNumber, subSiteNumber);
            string actual;
            actual = target.GetTeletextSubSite(SiteNumber, subSiteNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
