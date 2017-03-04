using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizBuzTemp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;
using Rhino.Mocks.Impl;

namespace FizBuzTemp.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        private FizzBuzz fbObj = new FizzBuzz();
        Random r = new Random();
        
        [TestMethod()]
        public void IdentifyFizzBuzzTest_ExpectReturnEmptyString()
        {
            //Arrange
            long number = r.Next();
            string result = String.Empty;

            //Act
            result = fbObj.IdentifyFizzBuzz(number);
            
            //Assert
            Assert.AreEqual(result, String.Empty);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberMax32BitIntegerReturns()
        {
            //Arrange
            long number = r.Next(0, Int32.MaxValue);
            long result;

            //Act
            result = fbObj.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number <= Int32.MaxValue);
            Assert.IsTrue(result != -1);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberMoreThan32BitIntegerReturnMinus1()
        {
            //Arrange
            long number = 12345678910;
            long result;

            //Act
            result = fbObj.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number > Int32.MaxValue);
            Assert.IsTrue(result == -1);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberLessThan0ReturnMinus1()
        {
            //Arrange
            long number = -1;
            long result;

            //Act
            result = fbObj.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number < 0);
            Assert.IsTrue(result == -1);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberBetween0And32BitIntegerReturnSameNumber()
        {
            //Arrange
            long number = r.Next(0,Int32.MaxValue);
            long result;

            //Act
            result = fbObj.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number <= Int32.MaxValue);
            Assert.IsTrue(number > 0);
            Assert.AreEqual(number,result);
        }

        [TestMethod()]
        public void IdentifyFizzBuzzTest_InvalidNumberReturnEmptyString()
        {
            //Arrange
            long number = -1;
            string result = String.Empty;
           
            //Act
            result = fbObj.IdentifyFizzBuzz(number);
            
            //Assert
            Assert.AreEqual(result, String.Empty);
        }

        [TestMethod()]
        public void IdentifyFizzBuzzTest_ValidNumberReturnFizzNumberDivisibleBy3()
        {
            //Arrange
            long number = 9;
            string result = String.Empty;

            //Act
            result = fbObj.IdentifyFizzBuzz(number);

            //Assert
            Assert.AreEqual(result, fbObj.Fizz);
        }

        [TestMethod()]
        public void IdentifyFizzBuzzTest_ValidNumberReturnBuzzNumberDivisibleBy5()
        {
            //Arrange
            long number = 10;
            string result = String.Empty;

            //Act
            result = fbObj.IdentifyFizzBuzz(number);

            //Assert
            Assert.AreEqual(result, fbObj.Buzz);
        }
    }
}