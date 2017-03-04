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

        [TestMethod()]
        public void IdentifyFizzBuzzTest_ExpectReturnEmptyString()
        {
            //Arrange
            Random r = new Random();
            long number = r.Next();
            string result = String.Empty;

            //Act
            result = fbObj.IdentifyFizzBuzz(number);
            
            //Assert
            Assert.AreEqual(result, String.Empty);
        }
    }
}