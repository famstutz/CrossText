using CrossText.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Drawing;
using System.Net;
using System.IO;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for HelperTest and is intended
    ///to contain all HelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HelperTest
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
        ///A test for CheckIfURLExists
        ///</summary>
        [TestMethod()]
        public void CheckIfURLExistsTest()
        {
            string BaseURL = "http://www.teletext.ch/pics/SF1/{0}-{1}.gif";

            Uri url1 = new Uri(string.Format(BaseURL,"241","01"));
            bool expected1 = true;
            bool actual1 = Helper.CheckIfURLExists(url1);
            Assert.AreEqual(expected1, actual1);
        }

        /// <summary>
        ///A test for GetBase64DataURI
        ///</summary>
        [TestMethod()]
        public void GetBase64DataURITest()
        {
            string mimeType = "image/gif";
            string BaseURL = "http://www.teletext.ch/pics/SF1/{0}-{1}.gif";

            byte[] data = Helper.GetImageFromURL(string.Format(BaseURL, "241", "01"));
            string expected = "data:image/gif;base64,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";
            string actual = string.Empty;
            actual = Helper.GetBase64DataURI(mimeType, data);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetImageFromURL
        ///</summary>
        [TestMethod()]
        public void GetImageFromURLTest()
        {
          string BaseURL = "http://www.teletext.ch/pics/SF1/{0}-{1}.gif";

          byte[] expected = Helper.GetImageFromURL(string.Format(BaseURL, "241", "01"));
          byte[] actual = Helper.GetImageFromURL(string.Format(BaseURL, "241", "01"));
          Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        /// <summary>
        ///A test for byteArrayToImage
        ///</summary>
        [TestMethod()]
        public void byteArrayToImageTest()
        {
            string BaseURL = "http://www.teletext.ch/pics/SF1/{0}-{1}.gif";

            byte[] data = Helper.GetImageFromURL(string.Format(BaseURL, "241", "01"));

            Image expected  = Helper_Accessor.byteArrayToImage(data);
            Image actual = Helper_Accessor.byteArrayToImage(data);

            Assert.AreEqual(expected.Size, actual.Size);
        }

        /// <summary>
        ///A test for imageToByteArray
        ///</summary>
        [TestMethod()]
        public void imageToByteArrayTest()
        {
            string BaseURL = "http://www.teletext.ch/pics/SF1/{0}-{1}.gif";

            byte[] data = Helper.GetImageFromURL(string.Format(BaseURL, "241", "01"));

            Image img1 = Helper_Accessor.byteArrayToImage(data);
            Image img2 = Helper_Accessor.byteArrayToImage(data);

            byte[] expected = Helper_Accessor.imageToByteArray(img1);
            byte[] actual = Helper_Accessor.imageToByteArray(img2);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
