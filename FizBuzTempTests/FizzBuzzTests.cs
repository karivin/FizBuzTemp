using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizBuzTemp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ValidateFizzBuzzNumber_ExpectNumberMax10Digit()
        {
            //Arrange
            long number = r.Next(Int32.MaxValue, Int32.MaxValue);
            long result;

            //Act
            result = fbObj.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number <= Int32.MaxValue);
            Assert.IsTrue(result != -1);
        }
    }
}