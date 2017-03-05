using System;
using System.Collections;
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
             CommandFizzBuzzService fizzBuzz = new CommandFizzBuzzService();
                
            //use reflections
            IEnumerable<ICommandFizzBuzzService> services =
            Assembly.GetExecutingAssembly().GetExportedTypes().Where(
            t => typeof(ICommandFizzBuzzService).IsAssignableFrom(t) && t.IsClass)
            .Select(Activator.CreateInstance)
            .Cast<ICommandFizzBuzzService>();

            // ReSharper disable once SuspiciousTypeConversion.Global
            foreach (ICommandFizzBuzzService service in services)
                fizzBuzz.SetService(service);
            return fizzBuzz;
        }
    }
}