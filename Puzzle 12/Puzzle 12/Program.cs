using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

//What is the sum of the digits of the number 21000?
namespace Puzzle_12
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int result = 0;
            BigInteger number = BigInteger.Pow(2, 1000);
            Console.WriteLine(number);
            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;

            }
                Console.WriteLine("the sum of digits in 2 power 1000 is {0}", result);
            Console.ReadKey();
        }
    }
}
