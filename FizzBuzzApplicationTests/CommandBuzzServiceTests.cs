using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApplication.Tests
{
    [TestClass()]
    public class CommandBuzzServiceTests
    {
        private ICommandService cmdService;
        private long number = 5;

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberBuzz_ReturnTrue()
        {
            //Arrange
            cmdService = new CommandBuzzService();
            bool result;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberNotBuzz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandBuzzService();
            bool result;
            number = 3;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ServiceFizzBuzzTest_ReturnsBuzz()
        {
            //Arrange
            cmdService = new CommandBuzzService();
            string result;

            //Act
            result = cmdService.ServiceFizzBuzz(number);

            //Assert
            Assert.AreEqual("Buzz", result);
        }
    }
}