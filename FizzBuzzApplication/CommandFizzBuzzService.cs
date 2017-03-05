namespace FizzBuzzApplication
{
    internal abstract class CommandFizzBuzzService : ICommandFizzBuzzService
    {
        protected CommandFizzBuzzService Service;
        public abstract bool CanServiceFizzBuzz(long number);
        public abstract string ServiceFizzBuzz(long number);

        public string ProvideServiceFizzBuzz(long number)
        {
            return CanServiceFizzBuzz(number) ? ServiceFizzBuzz(number) : Service.ProvideServiceFizzBuzz(number);
        }

        public CommandFizzBuzzService SetService(CommandFizzBuzzService newService)
        {
            if (Service == null)
                Service = newService;
            else
                Service.SetService(newService);
            return this;
        }
    }
}