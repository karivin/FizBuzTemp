using System.Linq;

namespace FizzBuzzApplication
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        private ICommandService cmdFizzBuzzService;
        private readonly ICommandFizzBuzzReceiver cmdFizzBuzzReceiver;

        internal CommandFizzBuzzExecutor()
        {
            cmdFizzBuzzReceiver = new CommandFizzBuzzReceiver();
            cmdFizzBuzzService = cmdFizzBuzzReceiver.ReceiveFizzBuzzService();
        }


        public string ExecuteFizzBuzz(long number)
        {
            return cmdFizzBuzzReceiver.ReceiveFizzBuzzService().ProvideServiceFizzBuzz(number);
        }
    }
}