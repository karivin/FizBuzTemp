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
        public void ServiceFizzBuzzTest()
        {
            Assert.Fail();
        }
    }
}