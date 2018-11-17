using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pay_and_Bonus;

namespace PayAndBonusTest
{
    [TestClass]
    public class InputIsValidTests
    {
      
        [TestMethod]
        public void InputwoValidInputs_ReturnsTrue()
        {
            // Arrange
            var input = new PayAndBonus();

            // Act
            var result = input.InputIsValid("2500", "500");
            // Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void InputwoInValidInputs_ReturnsFalse()
        {
            // Arrange
            var input = new PayAndBonus();

            // Act
            var result = input.InputIsValid("yxd", "ads");
            // Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void FirstInvalidSecondValid_ReturnsFalse()
        {
            // Arrange
            var input = new PayAndBonus();

            // Act
            var result = input.InputIsValid("yxd", "253");
            // Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void FirstValidSecondInvalid_ReturnsFalse()
        {
            // Arrange
            var input = new PayAndBonus();

            // Act
            var result = input.InputIsValid("2451", "asda");
            // Assert
            Assert.IsFalse(result);

        }


    }
}
