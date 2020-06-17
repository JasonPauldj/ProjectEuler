using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            for (int i = 2; i <= 100000; i++)
            {
                int cnt = FindSumDivisors(i);
                if (cnt <= 100000 && cnt !=1 && cnt !=i && cnt > i)
                {
                    int cnt1 = FindSumDivisors(cnt);
                    if (i == cnt1)
                    {
                        Console.WriteLine("the amicable pair is {0} and {1}", i, cnt);
                        ans += i + cnt;
                    }
                }
            }
            Console.WriteLine("the sum of amicable pairs less than 10000 is {0}", ans);
            Console.WriteLine("H" +
                "ello World!");
            Console.ReadKey();

            int FindSumDivisors(int num)
            {
                int sum = 1;
              
                for (int i = 2; i < num; i++)
                {
                    if (i * i <= num)
                    {
                        if (num % i == 0)
                        {
                            if (num / i == i)
                            {
                                sum += i;
                            }
                            else
                                sum += (num / i) + i;
                        }
                    }
                    else
                        break;
                }
               
                return sum;
            }
        }
    }
}
