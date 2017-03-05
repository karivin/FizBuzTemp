using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FizzBuzzApplication
{
    public class CommandFizzBuzzReceiver : ICommandFizzBuzzReceiver
    {
        //private ICommandFizzBuzzReceiver cmdFizzBuzzReceiver;
        //private List<ICommandFizzBuzzService> cmdFizzBuzzServices; 

        //public List<ICommandFizzBuzzService> ReceiveFizzBuzzService(ICommandFizzBuzzService cmdService)
        //{
        //    if (cmdFizzBuzzServices == null)
        //        cmdFizzBuzzServices = new List<ICommandFizzBuzzService>();
        //    cmdFizzBuzzServices.Add(cmdService);
        //    return cmdFizzBuzzServices;
        //}

        //public IEnumerable<ICommandFizzBuzzService> ReceiveFizzBuzzService()
        //{
        //    var services =
        //        Assembly.GetExecutingAssembly().GetExportedTypes().Where(
        //            cmdServ => typeof(ICommandFizzBuzzService).IsAssignableFrom(cmdServ) && cmdServ.IsClass)
        //            .Select(Activator.CreateInstance)
        //            .Cast<ICommandFizzBuzzService>();

        //    return services;
        //}

        
        public IEnumerable<ICommandFizzBuzzService> ReceiveFizzBuzzService()
        {
            throw new NotImplementedException();

        }
    }


    }