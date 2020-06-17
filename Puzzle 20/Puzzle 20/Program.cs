using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//The Fibonacci sequence is defined by the recurrence relation
//The 12th term is the first term to contain three digits.
//What is the index of the first term in the Fibonacci sequence to contain 1000 digits?

namespace Puzzle_20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = 1;
            BigInteger num2 = 2;
            int ans = 3;
            FibonacciSeries(num1, num2);

            void FibonacciSeries(BigInteger n1, BigInteger n2)
            {

                BigInteger sum = n1 + n2;
                ans++;
                if (sum.ToString().Length < 1000)
                    FibonacciSeries(n2, sum);
                else
                    Console.WriteLine("answer is {0}", ans);
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
