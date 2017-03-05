namespace FizzBuzzApplication
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        private ICommandFizzBuzzService cmdFizzBuzzService;
        private ICommandFizzBuzzReceiver cmdFizzBuzzReceiver;

        public void ExecuteFizzBuzz(long number)
        {
            throw new System.NotImplementedException();
        }
    }
}