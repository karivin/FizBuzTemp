﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void CanServiceFizzBuzzTest_NumberNotFizzBuzz_ReturnTrue()
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
        public void CanServiceFizzBuzzTest_NumberFizz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            bool result;
            number = 3;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberBuzz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            bool result;
            number = 5;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsFalse(result);
        }


        [TestMethod()]
        public void ServiceFizzBuzzTest_ReturnEmptyString()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            string result;
           
            //Act
            result = cmdService.ServiceFizzBuzz(number);

            //Assert
            Assert.AreEqual(String.Empty,result);
        }
    }
}