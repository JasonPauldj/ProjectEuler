using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Project Euler problem 30 - https://projecteuler.net/problem=30
namespace Puzzle_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            List<int> powers = new List<int>();
            powers.Add(0);
            powers.Add(1);
            for(int i=2;i<=9;i++)
            {
                int val = i;
                for(int j=2;j<=5;j++)
                {
                    val *= i;
                }
                powers.Add(val);
            }

            //foreach (int power in powers)
            //    Console.WriteLine(power);
            //Console.WriteLine(powers.Sum());


            for (int i=1001;i<= 355000; i++)
            {
                //Console.WriteLine("checking {0}", i);
                int sum = 0;
                int num = i;
                int len = i.ToString().Length;
                for(int j=1;j<=len;j++)
                {
                    int digit = num % 10;
                   num = num / 10;
                    sum += powers[digit];
                }
                if(sum==i)
                {
                    Console.WriteLine(i);
                    ans += i;
                }
            }
            Console.WriteLine("ans is {0}",ans);
            Console.ReadKey();
        }
    }
}
