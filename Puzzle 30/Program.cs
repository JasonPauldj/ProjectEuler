using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Project Euler Problem 35 https://projecteuler.net/problem=35

namespace Puzzle_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Stopwatch stpwatch = Stopwatch.StartNew();
            SortedSet<int> prime_nums = new SortedSet<int>();
            prime_nums.Add(2);
            SieveofEratosthenes(number);
            int ans = 0;

            foreach (int i in prime_nums)
                CheckCircularPrimes(i);


            Console.WriteLine("no of circular primes are {0}", ans);
            Console.WriteLine("elapsed time is {0}", stpwatch.ElapsedMilliseconds);

            Console.ReadKey();
            void CheckCircularPrimes(int num)
            {
                int no_of_possibilites = num.ToString().Length - 1;
                int pow = no_of_possibilites;
                int temp = num;

                for (int i = no_of_possibilites; i > 0; i--)
                {
                    int digit = temp % 10;
                    //if (digit == 2 || digit == 5)
                    //    break;
                    temp = temp / 10;
                    temp = digit * (int)Math.Pow(10, pow) + temp;
                    if (!prime_nums.Contains(temp))
                        break;
                    else
                        no_of_possibilites--;
                }
                if (no_of_possibilites == 0)
                {
                    //Console.WriteLine(num);
                    ans++;

                }
            }

            void SieveofEratosthenes(int upper_limit)
            {
                int no_odd_numbers = (upper_limit - 1) / 2;
                // suppose the upperlimit is 36 then 3*3 < 36 and 5*5 < 36.
                //Therefore the number of iterations is 2 as all possible combinations of odd numbers are covered.
                //3*3,3*5,3*7,...3*11,5*7
                int no_of_iteration = ((int)Math.Sqrt(upper_limit) - 1) / 2;

                //every odd number can be represented as 2i+1.
                //therefore 3=2(1) + 1, 5=2(2) + 1,....
                //initializing all prime numbers to be prime
                BitArray odd_nums = new BitArray(no_odd_numbers + 1, true);

                for (int i = 1; i <= no_of_iteration; i++)
                {
                    if (odd_nums[i])
                    {
                        // suppose we are checking for the odd number 7 i.e i=3 ( because 3,5,7)
                        //then we start from 7*7 and go on
                        //7*7 = (2i+1)(2i+1) = 2 *(2i(i+1)) + 1;
                        // j= 2i*(i+1) and we keep incrementing by 7
                        for (int j = (2 * i * (i + 1)); j <= no_odd_numbers; j += 2 * i + 1)
                        {
                            odd_nums[j] = false;
                        }
                    }

                }


                for (int i = 1; i <= no_odd_numbers; i++)
                {
                    if (odd_nums[i])
                        prime_nums.Add(2 * i + 1);
                }
            }

        }
    }
}

