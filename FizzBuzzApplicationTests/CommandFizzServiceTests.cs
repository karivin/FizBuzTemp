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
            cmdService = new CommandFizzBuzzService();
            bool result;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsTrue(result);
        }

      }
}