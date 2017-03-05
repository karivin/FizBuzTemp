using System.Collections.Generic;

namespace FizzBuzzApplication
{
    public interface ICommandFizzBuzzReceiver
    {
        IEnumerable<ICommandFizzBuzzService> ReceiveFizzBuzzService();
    }
}