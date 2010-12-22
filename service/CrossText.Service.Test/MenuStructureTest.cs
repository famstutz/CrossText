using CrossText.Service.DataContract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for MenuStructureTest and is intended
    ///to contain all MenuStructureTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MenuStructureTest
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
        ///A test for MenuStructure Constructor
        ///</summary>
        [TestMethod()]
        public void MenuStructureConstructorTest()
        {
            MenuStructure target = new MenuStructure();
            bool expected = true;
            Assert.AreEqual(expected, target!=null);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            MenuStructure target = new MenuStructure() { Title = "News", SiteNumber = 100 };
            object obj = null;
            bool expected = false;
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SiteNumber
        ///</summary>
        [TestMethod()]
        public void SiteNumberTest()
        {
            MenuStructure target = new MenuStructure() { SiteNumber = 256 };
            int expected = 256;
            int actual;
            actual = target.SiteNumber;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Title
        ///</summary>
        [TestMethod()]
        public void TitleTest()
        {
            MenuStructure target = new MenuStructure() { Title = "News" };
            string expected = "News";
            string actual;
            actual = target.Title;
            Assert.AreEqual(expected, actual);
        }
    }
}
