using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The following iterative sequence is defined for the set of positive integers:

///n = n/2 (n is even)
///n = 3n + 1 (n is odd)

///Using the rule above and starting with 13, we generate the following sequence:

///13 - 40 - 20 -10 - 5 - 16 - 8 - 4 - 2 - 1
///It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

///Which starting number, under one million, produces the longest chain?

///NOTE: Once the chain starts the terms are allowed to go above one million.
/// 
/// </summary>
namespace Puzzle_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int cnt = 1, j= 1000000, max=0, ans=0;
            // Hashtable collatzvalues = new Hashtable();
            while (j >=1 )
            {
                cnt = 1;
                Collatz(j);
                if(cnt >= max)
                {
                    max = cnt;
                    ans = j;
                }
                j--;
            }
            watch.Stop();
            Console.WriteLine("\n {0} and count is {1}", ans, max);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            Console.ReadKey();

            double Collatz(double n)
            {
                if (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        cnt++;
                        //Console.Write("{0} ", n / 2);
                        return Collatz(n / 2);
                    }
                    else
                    {
                        cnt++;
                       // Console.Write("{0} ", 3 * n + 1);
                        return Collatz(3 * n + 1);
                    }
                }
                else
                    return cnt;
            }
        }
    }
}
