namespace FizzBuzzApplication
{
    public class CommandBuzzService: CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            return (number%Buzz == 0);
        }

        public override string ServiceFizzBuzz(long number)
        {
            return DisplayBuzz;
        }
    }
}