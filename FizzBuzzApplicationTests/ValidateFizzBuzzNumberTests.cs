using System;
using FizzBuzzApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests
{
    [TestClass()]
    public class ValidateFizzBuzzNumberTests
    {
        private IValidateFizzBuzzNumber validateFizzBuzz = new ValidateFizzBuzzNumber();
        Random r = new Random();
        bool result;

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectPositiveNumberMax32BitInteger_ReturnsTrue()
        {
            //Arrange
            long number = r.Next(0, Int32.MaxValue);
            

            //Act
            result = validateFizzBuzz.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number > 0);
            Assert.IsTrue(number <= Int32.MaxValue);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberMoreThan32BitInteger_ReturnFalse()
        {
            //Arrange
            long number = 12345678910;
            
            //Act
            result = validateFizzBuzz.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number > Int32.MaxValue);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberLessThan0_ReturnFalse()
        {
            //Arrange
            long number = -1;
           
            //Act
            result = validateFizzBuzz.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number < 0);
            Assert.IsFalse(result);
        }

    }
}