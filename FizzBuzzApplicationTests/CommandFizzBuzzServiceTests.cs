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
    public class CommandFizzBuzzServiceTests
    {
        private ICommandService cmdService;
        private long number = 1234;

        [TestMethod()]
        public void CanServiceFizzBuzzTest()
        {
           //Arrange
           cmdService = new CommandFizzBuzzService();
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