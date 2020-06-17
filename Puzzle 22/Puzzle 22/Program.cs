using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 27 in Project Euler - https://projecteuler.net/problem=27
namespace Puzzle_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch =Stopwatch.StartNew();
            List<int> prime_num = new List<int>();
            int v1=0, v2=0;
            int max=0;
            int ans = 0;
            prime_num.Add(2);
            for (int b = 3; b < 1000; b=b+2)
            {
                bool is_prime = chk_prime(b);
                if (is_prime)
                {
                    prime_num.Add(b);
                }

            }
            int len = prime_num.Count;
            Console.WriteLine(prime_num[len-1]);
            for (int a = -999; a <= 999; a+=2)
            {
                for (int b = 0; b < len; b++)
                {
                    if (a + b > 0)
                    {
                        int cnt = 1;
                        int n = 1;
                        bool continue_loop = true;
                        while (continue_loop == true)
                        {
                            // Console.WriteLine("a is {0} and b is {1} and cnt is {2}", a, prime_num[b], cnt);
                            // Console.WriteLine("n is {0}", n);
                            int val = (n * n) + (a * n) + (prime_num[b]);
                            if (val > 1)
                            {
                                continue_loop = chk_primenum(val);
                                //if(continue_loop)
                                //Console.WriteLine("val is {0} and number is prime", val);
                                //else
                                //    Console.WriteLine("val is {0} and number is not prime", val);
                                cnt++;
                            }
                            else
                            {
                                continue_loop = false;
                            }
                            n = n + 1;
                            //Console.WriteLine(n);
                        }

                        if (max < cnt)
                        {

                            v1 = a;
                            v2 = prime_num[b];
                            ans = a * prime_num[b];
                            max = cnt;
                            //Console.WriteLine("a is {0} and b is {1} max is {2}",v1,v2, max);
                        }
                    }
                }
            }

            Console.WriteLine("time taken is {0}", stopWatch.Elapsed.Seconds);
            Console.WriteLine("ans is {0} and coefficients are {1} {2}", ans, v1, v2);
            //foreach (int n in prime_num)
            //    Console.WriteLine(n);
            Console.ReadKey();
            bool chk_prime(int j)
            {
                foreach (int n in prime_num)
                {
                    if (j % n == 0)
                        return false;
                }
                    return true;
            }
            bool chk_primenum(int num)
            {
                foreach (int n in prime_num)
                {
                    if (num % n == 0 && n !=num)
                    {
                        return false;
                    }
                }
                int start = prime_num[prime_num.Count - 1];
                for (int i = start + 2; i * i < num; i += 2)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                prime_num.Add(num);
                return true;
            }

        }
    }
}
