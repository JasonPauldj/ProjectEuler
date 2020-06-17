using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 28 Project Euler - https://projecteuler.net/problem=28
namespace Puzzle_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a odd value \"n\" to form the n*n spiral");
            int n = Convert.ToInt16(Console.ReadLine());
            int ans = 0;
            for(int j = n; j >= 3; j-=2)
            {
                ans += (j * j) + (j - 1) * (j - 1) + 1 - (j - 1);
            }
            ans *= 2;
            ans += 1;
            Console.WriteLine("answer is {0}",ans);
            Console.ReadKey();
        }
    }
}
