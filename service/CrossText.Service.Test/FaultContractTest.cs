﻿using CrossText.Service.DataContract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace CrossText.Service.Test
{
    
    
    /// <summary>
    ///This is a test class for FaultContractTest and is intended
    ///to contain all FaultContractTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FaultContractTest
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
        ///A test for FaultContract Constructor
        ///</summary>
        [TestMethod()]
        public void FaultContractConstructorTest()
        {
          FaultContract target = new FaultContract() { Message = "Test Message", Source = "Source", StackTrace = "StackTrace" };
          bool expected = true;
          Assert.AreEqual(expected, target.Message.Length > 0);
        }

        /// <summary>
        ///A test for Message
        ///</summary>
        [TestMethod()]
        public void MessageTest()
        {
            FaultContract target = new FaultContract() { Message = "Test Message" };
            string expected = target.Message;

            Assert.AreEqual(expected, target.Message);
        }

        /// <summary>
        ///A test for Source
        ///</summary>
        [TestMethod()]
        public void SourceTest()
        {
          FaultContract target = new FaultContract() { Source = "Test Message" };
          string expected = target.Source;

          Assert.AreEqual(expected, target.Source);
        }

        /// <summary>
        ///A test for StackTrace
        ///</summary>
        [TestMethod()]
        public void StackTraceTest()
        {
          FaultContract target = new FaultContract() { StackTrace = "Test Message" };
          string expected = target.StackTrace;

          Assert.AreEqual(expected, target.StackTrace);
        }
    }
}
