namespace FizzBuzzApplication
{
    public interface ICommandFizzBuzzService
    {
        bool CanServiceFizzBuzz(long number);
        string ServiceFizzBuzz(long number);
        string ProvideServiceFizzBuzz(long number);
    }
}