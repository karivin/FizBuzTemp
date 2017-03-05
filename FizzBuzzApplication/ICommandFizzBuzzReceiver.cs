using System.Collections.Generic;

namespace FizzBuzzApplication
{
    public interface ICommandFizzBuzzReceiver
    {
        CommandService ReceiveFizzBuzzService();
    }
}