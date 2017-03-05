namespace FizzBuzzApplication
{
    public abstract class CommandService :ICommandService
    {
        protected CommandService Service;
        public abstract bool CanServiceFizzBuzz(long number);
        public abstract string ServiceFizzBuzz(long number);
        protected int Fizz => 3;
        protected int Buzz => 5;
        protected string DisplayFizz => "Fizz";
        protected string DisplayBuzz => "Buzz";

        public string ProvideServiceFizzBuzz(long number)
        {
            return CanServiceFizzBuzz(number) ? ServiceFizzBuzz(number) : Service.ProvideServiceFizzBuzz(number);
        }

        public CommandService SetService(CommandService newService)
        {
            if (Service == null)
                Service = newService;
            else
                Service.SetService(newService);
            return this;
        }
    }
}