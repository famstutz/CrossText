using CrossText.Service.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for ConfigurationHelperTest and is intended
    ///to contain all ConfigurationHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConfigurationHelperTest
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
        ///A test for GetSetting
        ///</summary>
        public void GetSettingTestHelper<T>()
        {
            string settingKey = "ImageMimeType";
            string expected = "image/gif";
            string actual;
            actual = ConfigurationHelper_Accessor.GetSetting<string>(settingKey);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetSettingTest()
        {
            GetSettingTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ImageMimeType
        ///</summary>
        [TestMethod()]
        public void ImageMimeTypeTest()
        {
            string actual;
            actual = ConfigurationHelper.ImageMimeType;
            Assert.IsNotNull(actual); 
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        /// <summary>
        ///A test for SerializedSiteCacheFile
        ///</summary>
        [TestMethod()]
        public void SerializedSiteCacheFileTest()
        {
            string actual;
            actual = ConfigurationHelper.SerializedSiteCacheFile;
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        /// <summary>
        ///A test for TeletextBaseUrl
        ///</summary>
        [TestMethod()]
        public void TeletextBaseUrlTest()
        {
            string actual;
            actual = ConfigurationHelper.TeletextBaseUrl;
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        /// <summary>
        ///A test for TeletextStructureDefinition
        ///</summary>
        [TestMethod()]
        public void TeletextStructureDefinitionTest()
        {
            string actual;
            actual = ConfigurationHelper.TeletextStructureDefinition;
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        /// <summary>
        ///A test for TeletextStructureSchema
        ///</summary>
        [TestMethod()]
        public void TeletextStructureSchemaTest()
        {
            string actual;
            actual = ConfigurationHelper.TeletextStructureSchema;
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        /// <summary>
        ///A test for TeletextStructureSchemaNamespace
        ///</summary>
        [TestMethod()]
        public void TeletextStructureSchemaNamespaceTest()
        {
            string actual;
            actual = ConfigurationHelper.TeletextStructureSchemaNamespace;
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(string));
        }
    }
}
