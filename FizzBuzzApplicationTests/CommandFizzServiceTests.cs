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
    public class CommandFizzServiceTests
    {
        private ICommandService cmdService;
        private long number = 3;

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberFizz_ReturnTrue()
        {
            //Arrange
            cmdService = new CommandFizzService();
            bool result;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberNotFizz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandFizzService();
            bool result;
            number = 4;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ServiceFizzBuzzTest_ReturnFizz()
        {
            //Arrange
            cmdService = new CommandFizzService();
            string result;

            //Act
            result = cmdService.ServiceFizzBuzz(number);

            //Assert
            Assert.AreEqual("Fizz", result);
        }
    }
}