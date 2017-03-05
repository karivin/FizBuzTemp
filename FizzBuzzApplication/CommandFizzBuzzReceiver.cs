using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace FizzBuzzApplication
{
    public class CommandFizzBuzzReceiver : ICommandFizzBuzzReceiver
    {
        //set all services available and sent it to invoker
        public CommandService ReceiveFizzBuzzService()
        {
            var fizzBuzz = new CommandFizzBuzzService()
                .SetService(new CommandFizzBuzzService())
                .SetService(new CommandFizzService())
                .SetService(new CommandBuzzService());
            return fizzBuzz;
        }
    }
}