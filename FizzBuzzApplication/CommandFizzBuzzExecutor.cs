namespace FizzBuzzApplication
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        private ICommandFizzBuzzService cmdFizzBuzzService;
        private ICommandFizzBuzzReceiver cmdFizzBuzzReceiver;

        private CommandFizzBuzzExecutor()
        {
            cmdFizzBuzzReceiver = new CommandFizzBuzzReceiver();
           // cmdFizzBuzzService = cmdFizzBuzzReceiver.ReceiveFizzBuzzService();
           

        }


        public void ExecuteFizzBuzz(long number)
        {
            throw new System.NotImplementedException();
        }
    }
}