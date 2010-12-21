using CrossText.Service.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Xml;
using System.Xml.Serialization;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for IXmlSerializableTest and is intended
    ///to contain all IXmlSerializableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IXmlSerializableTest
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


        internal virtual IXmlSerializable CreateIXmlSerializable()
        {
            // TODO: Instantiate an appropriate concrete class.
            IXmlSerializable target = null;
            return target;
        }

        /// <summary>
        ///A test for ReadXml
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void ReadXmlTest()
        {
            IXmlSerializable target = CreateIXmlSerializable(); // TODO: Initialize to an appropriate value
            XmlReader reader = null; // TODO: Initialize to an appropriate value
            target.ReadXml(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WriteXml
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void WriteXmlTest()
        {
            IXmlSerializable target = CreateIXmlSerializable(); // TODO: Initialize to an appropriate value
            XmlWriter writer = null; // TODO: Initialize to an appropriate value
            target.WriteXml(writer);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
