using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

//Project euler problem 29 - https://projecteuler.net/problem=29
namespace Puzzle_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stpwatch = Stopwatch.StartNew();
            List<double> numbers = new List<double>();
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    if (!numbers.Contains(Math.Pow(a, b)))
                    {
                        numbers.Add(Math.Pow(a, b));
                    }
                }
            }

            Console.WriteLine("ans is {0}",numbers.Count);
           
            Console.ReadKey();
        }
    }
}
