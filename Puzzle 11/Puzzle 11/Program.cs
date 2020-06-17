using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
//How many such routes are there through a 20×20 grid?

namespace Puzzle_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for the n * n grid");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            Console.WriteLine("The number of ways in the lattice");
            double ways = 1, fact1=1, fact2=1;
            for(int j= 1;j<=n*2;j++)
            {
                fact2 = fact2 * j;
                if(j==n)
                {
                    fact1 = fact2;
                }
                
            }
            
            ways = fact2 / (fact1 * fact1);
            Console.WriteLine(ways);
            Console.ReadKey();
        }
    }
}
