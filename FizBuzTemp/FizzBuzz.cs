using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizBuzTemp
{
    public class FizzBuzz
    {
        public string IdentifyFizzBuzz(long number)
        {

            return string.Empty;
        }

        public long ValidateFizzBuzznumber(long number)
        {
            if (number < 0 || number > Int32.MaxValue)
                return -1;
            return number;
        }
    }
}
