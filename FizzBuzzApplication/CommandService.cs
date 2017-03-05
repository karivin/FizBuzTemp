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

        //Provide Service and if not found check for another service
        protected internal string ProvideServiceFizzBuzz(long number)
        {
            return CanServiceFizzBuzz(number) ? ServiceFizzBuzz(number) : Service.ProvideServiceFizzBuzz(number);
        }

        protected internal CommandService SetService(ICommandService newService)
        {
            if (Service == null)
                Service = (CommandService) newService;
            else
                Service.SetService(newService);
            return this;
        }
    }
}