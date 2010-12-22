using CrossText.Service.MenuStructureLoader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CrossText.Service.DataContract;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for IMenuStructureLoaderTest and is intended
    ///to contain all IMenuStructureLoaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IMenuStructureLoaderTest
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

        private string XmlNamespace
        {
            get
            {
                return "http://tempuri.org/TeletextStructure.xsd";
            }
        }

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

        internal virtual IMenuStructureLoader CreateIMenuStructureLoader()
        {
            IMenuStructureLoader target = new XmlMenuStructureLoader(XmlFile, XmlSchemaFile, XmlNamespace);
            return target;
        }

        /// <summary>
        ///A test for LoadMenuStructures
        ///</summary>
        [TestMethod()]
        public void LoadMenuStructuresTest()
        {
            IMenuStructureLoader target = CreateIMenuStructureLoader();
            MenuStructureList expected = MenuStructureList;
            MenuStructureList actual;
            actual = target.LoadMenuStructures();
            Assert.AreEqual(expected, actual);
        }
    }
}
