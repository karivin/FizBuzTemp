﻿namespace FizzBuzzApplication
{
    public class CommandBuzzService: CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            throw new System.NotImplementedException();
        }

        public override string ServiceFizzBuzz(long number)
        {
            throw new System.NotImplementedException();
        }
    }
}