using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrossText.Service.Helpers.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Xml.Schema;

namespace CrossText.Service.Test
{
    [TestClass]
    public class XmlValidatorTest
    {
        /// <summary>
        ///A test for XmlValidator Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
         public void XmlValidatorConstructorTest()
        {
            string xmlFile = string.Empty; // TODO: Initialize to an appropriate value
            string schemaFile = string.Empty; // TODO: Initialize to an appropriate value
            XmlValidator target = new XmlValidator(xmlFile, schemaFile);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CustomValidationEventHandler
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void CustomValidationEventHandlerTest()
        {
            string xmlFile = string.Empty; // TODO: Initialize to an appropriate value
            string schemaFile = string.Empty; // TODO: Initialize to an appropriate value
            XmlValidator target = new XmlValidator(xmlFile, schemaFile); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ValidationEventArgs args = null; // TODO: Initialize to an appropriate value
            target.CustomValidationEventHandler(sender, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsValid
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void IsValidTest()
        {
            string xmlFile = string.Empty; // TODO: Initialize to an appropriate value
            string schemaFile = string.Empty; // TODO: Initialize to an appropriate value
            XmlValidator target = new XmlValidator(xmlFile, schemaFile); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsValid();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsValidFlag
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void IsValidFlagTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlValidator_Accessor target = new XmlValidator_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsValidFlag = expected;
            actual = target.IsValidFlag;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchemaFile
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void SchemaFileTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlValidator_Accessor target = new XmlValidator_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SchemaFile = expected;
            actual = target.SchemaFile;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XmlFile
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void XmlFileTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlValidator_Accessor target = new XmlValidator_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.XmlFile = expected;
            actual = target.XmlFile;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XmlValidator Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void XmlValidatorConstructorTest1()
        {
            string xmlFile = string.Empty; // TODO: Initialize to an appropriate value
            string schemaFile = string.Empty; // TODO: Initialize to an appropriate value
            XmlValidator target = new XmlValidator(xmlFile, schemaFile);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CustomValidationEventHandler
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void CustomValidationEventHandlerTest1()
        {
            string xmlFile = string.Empty; // TODO: Initialize to an appropriate value
            string schemaFile = string.Empty; // TODO: Initialize to an appropriate value
            XmlValidator target = new XmlValidator(xmlFile, schemaFile); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ValidationEventArgs args = null; // TODO: Initialize to an appropriate value
            target.CustomValidationEventHandler(sender, args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsValid
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        public void IsValidTest1()
        {
            string xmlFile = string.Empty; // TODO: Initialize to an appropriate value
            string schemaFile = string.Empty; // TODO: Initialize to an appropriate value
            XmlValidator target = new XmlValidator(xmlFile, schemaFile); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsValid();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsValidFlag
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void IsValidFlagTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlValidator_Accessor target = new XmlValidator_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsValidFlag = expected;
            actual = target.IsValidFlag;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchemaFile
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void SchemaFileTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlValidator_Accessor target = new XmlValidator_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SchemaFile = expected;
            actual = target.SchemaFile;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for XmlFile
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Dev\\Workspace\\MethodenDerProgrammierung\\CrossText\\service\\CrossText.Service", "/")]
        [UrlToTest("http://localhost:1042/")]
        [DeploymentItem("CrossText.Service.dll")]
        public void XmlFileTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            XmlValidator_Accessor target = new XmlValidator_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.XmlFile = expected;
            actual = target.XmlFile;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
