using System;

namespace FizzBuzzApplication
{
    public class ValidateFizzBuzzNumber : IValidateFizzBuzzNumber
    {
        public bool ValidateFizzBuzznumber(long number)
        {
            if (number < 0 || number > Int32.MaxValue)
                return false;
            return true;
        }
    }
}
