using System;
using System.Linq;

namespace FizzBuzzApplication
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        private ICommandService cmdFizzBuzzService;
        private readonly ICommandFizzBuzzReceiver cmdFizzBuzzReceiver;
        private readonly IValidateFizzBuzzNumber validateFizzBuzz;

        internal CommandFizzBuzzExecutor(ICommandFizzBuzzReceiver cmdFizzBuzzReceiver, IValidateFizzBuzzNumber validateFizzBuzz)
        {
            this.cmdFizzBuzzReceiver = cmdFizzBuzzReceiver;
            cmdFizzBuzzService = cmdFizzBuzzReceiver.ReceiveFizzBuzzService();
            this.validateFizzBuzz = validateFizzBuzz;
        }


        public string ExecuteFizzBuzz(long number)
        {
            if(validateFizzBuzz.ValidateFizzBuzznumber(number))
                return cmdFizzBuzzReceiver.ReceiveFizzBuzzService().ProvideServiceFizzBuzz(number);
            return String.Empty;
        }
    }
}