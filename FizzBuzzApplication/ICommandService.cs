﻿namespace FizzBuzzApplication
{
    public interface ICommandService
    {
        bool CanServiceFizzBuzz(long number);
        string ServiceFizzBuzz(long number);
    }
}
   