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

        /// <summary>
        ///A test for XmlMenuStructureLoader Constructor
        ///</summary>
        [TestMethod()]
        public void XmlMenuStructureLoaderConstructorTest()
        {
            string teletextStructureXml = XmlFile;
            string teletextStructureSchema = XmlSchemaFile;
            string teletextStructureSchemaNamespace = XmlNamespace;
            XmlMenuStructureLoader target = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for LoadMenuStructures
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void LoadMenuStructuresTest()
        {
            string teletextStructureXml = XmlFile;
            string teletextStructureSchema = XmlSchemaFile;
            string teletextStructureSchemaNamespace = XmlNamespace;
            XmlMenuStructureLoader target = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            MenuStructureList expected = MenuStructureList;
            MenuStructureList actual;
            actual = target.LoadMenuStructures();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SetTeletextStructureXml
        ///</summary>
        [TestMethod()]
        public void SetTeletextStructureXmlTest()
        {
            string teletextStructureXml = XmlFile;
            string teletextStructureSchema = XmlSchemaFile;
            string teletextStructureSchemaNamespace = XmlNamespace;
            XmlMenuStructureLoader xmsl = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            PrivateObject param0 = new PrivateObject(xmsl);
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0);
            target.SetTeletextStructureXml(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            Assert.AreEqual(teletextStructureXml, target.TeletextStructureXml);
        }

        /// <summary>
        ///A test for TeletextStructureSchema
        ///</summary>
        [TestMethod()]
        public void TeletextStructureSchemaTest()
        {
            string teletextStructureXml = XmlFile;
            string teletextStructureSchema = XmlSchemaFile;
            string teletextStructureSchemaNamespace = XmlNamespace;
            XmlMenuStructureLoader xmsl = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            PrivateObject param0 = new PrivateObject(xmsl);
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0);
            string expected = XmlSchemaFile;
            string actual;
            target.TeletextStructureSchema = expected;
            actual = target.TeletextStructureSchema;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TeletextStructureSchemaNamespace
        ///</summary>
        [TestMethod()]
        public void TeletextStructureSchemaNamespaceTest()
        {
            string teletextStructureXml = XmlFile;
            string teletextStructureSchema = XmlSchemaFile;
            string teletextStructureSchemaNamespace = XmlNamespace;
            XmlMenuStructureLoader xmsl = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            PrivateObject param0 = new PrivateObject(xmsl);
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0);
            string expected = XmlNamespace;
            string actual;
            target.TeletextStructureSchemaNamespace = expected;
            actual = target.TeletextStructureSchemaNamespace;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TeletextStructureXml
        ///</summary>
        [TestMethod()]
        public void TeletextStructureXmlTest()
        {
            string teletextStructureXml = XmlFile;
            string teletextStructureSchema = XmlSchemaFile;
            string teletextStructureSchemaNamespace = XmlNamespace;
            XmlMenuStructureLoader xmsl = new XmlMenuStructureLoader(teletextStructureXml, teletextStructureSchema, teletextStructureSchemaNamespace);
            PrivateObject param0 = new PrivateObject(xmsl);
            XmlMenuStructureLoader_Accessor target = new XmlMenuStructureLoader_Accessor(param0);
            string expected = XmlFile;
            string actual;
            target.TeletextStructureXml = expected;
            actual = target.TeletextStructureXml;
            Assert.AreEqual(expected, actual);
        }
    }
}
