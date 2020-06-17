using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Puzzle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("getting the divisors");
            ArrayList divisors = new ArrayList();
            divisors.Add(1);
            int lim = num;
            for(int j=2;j<lim;j++)
            {
                if(num%j==0)
                {
                    divisors.Add(j);
                    divisors.Add(num / j);
                    lim = num / j;
                }
            }
            foreach(int div in divisors)
            {
                Console.WriteLine(div);
            }

            Console.ReadKey();
        }
    }
}
