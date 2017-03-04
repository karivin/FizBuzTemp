using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizBuzTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a positive number(max 32 bit integer) : ");
            long number = Convert.ToInt64(Console.ReadLine());
            IFizzBuzz fizzBuzzObj = new FizzBuzz();
             Console.WriteLine(fizzBuzzObj.IdentifyFizzBuzz(number));
        }
    }
}
