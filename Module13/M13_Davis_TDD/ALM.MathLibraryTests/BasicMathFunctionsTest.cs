using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ALM.MathLibrary;

/** =========================================================

 Spencer Davis
 Windows 7
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Module 13 TDD
 Project Description: Followed the guide to TDD from:
    https://visualstudiomagazine.com/articles/2013/07/29/test-driven-development-with-visual-studio-2012.aspx
    as per assignment instructions.


 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace ALM.MathLibraryTests
{
    /// <summary>
    /// Summary description for BasicMathFunctionsTest
    /// </summary>
    [TestClass]
    public class BasicMathFunctionsTest
    {
        public BasicMathFunctionsTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void AddTest()
        {
            var system = new BasicMathLibrary();

            int expected = 42;

            int actual = system.Add(40, 2);

            Assert.AreEqual(expected, actual, "The expected value did not match the acutal value");
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.Inconclusive();
        }
    }
}
