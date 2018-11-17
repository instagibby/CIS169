using System;
using Cups_To_Ounces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cups_To_OuncesTests
{
    [TestClass]
    public class CupsToOuncesTest
    {
        [TestMethod]
        public void CupsToOz_First_Success()
        {
            // Arrange
            var cupTest = new CupsToOunces();
            double expected = 24;

            // Act
            var result = cupTest.CupsToOz(3);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CupsToOz_Second_Success()
        {
            // Arrange
            var cupTest = new CupsToOunces();
            double expected = 4;

            // Act
            var result = cupTest.CupsToOz(0.5);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CupsToOz_Third_Success()
        {
            // Arrange
            var cupTest = new CupsToOunces();
            double expected = ((1 /3) * 8);

            // Act
            var result = cupTest.CupsToOz((1/3));

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid Number")]
        public void CupsToOz_Fourth_InvalidReturnsErrMsg()
        {
            var cupTest = new CupsToOunces();
            var result = cupTest.CupsToOz(-1);
            
        }


    }
}
