﻿using System;

namespace FizzBuzzApplication
{
    public class CommandFizzBuzzService : CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            return (number%Fizz != 0 && number%Buzz != 0);
        }

        public override string ServiceFizzBuzz(long number)
        {
            return String.Empty;
        }
    }
}