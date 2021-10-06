using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuedeFallar
{
    public static class FizzBuzzExtension
    {
        public static string FizzBuzz(this Int32 int32)
        {
            string int32ToString;
            bool divisiblePor3 = int32 % 3 == 0;
            bool divisiblePor5 = int32 % 5 == 0;
            if (divisiblePor3 && divisiblePor5)
            {
                int32ToString = "FizzBuzz";
            }
            else if (divisiblePor3)
            {
                int32ToString = "Fizz";
            }
            else if (divisiblePor5)
            {
                int32ToString = "Buzz";
            }
            else
            {
                int32ToString = int32.ToString();
            }
            return int32ToString;
        }
    }
}
