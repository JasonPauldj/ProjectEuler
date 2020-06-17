using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?*/

namespace Puzzle_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int limit;
            double ans = 1;
            Dictionary<int, int> dict_primenums = new Dictionary<int, int>();

            Console.WriteLine("Enter the value n to find the smallest positive number that is evenly divisible by all of the numbers from 1 to 'n' ");
            limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= limit; i++)
            {
                get_primefactors(i);
            }

            foreach (KeyValuePair<int, int> prime_num in dict_primenums)
            {
                Console.WriteLine("prime factor is {0} and power is {1}", prime_num.Key, prime_num.Value);
            }
            foreach (KeyValuePair<int, int> prime_num in dict_primenums)
            {
                ans = ans * Math.Pow(prime_num.Key, prime_num.Value);
            }

            Console.WriteLine("solution is {0}", ans);

            Console.ReadKey();

            /// <summary>
            /// In this function we iterate the number 'i' through all the prime factors we found till now.
            /// basically we express the number 'i' if it is a composite as a product of prime factors.
            /// if any power of the prime factor is greater than the already existing highest power we replace it using the count variable.
            /// if it cannot be expressed as a product of primes we add it to our dictionary.
            /// </summary> 
            void get_primefactors(int i)
            {
                int num = i;
                foreach (int prime_num in dict_primenums.Keys)
                {
                    int count = 0;
                    while (i % prime_num == 0 && i != 1)
                    {
                        i = i / prime_num;
                        count++;
                    }
                    if (count > dict_primenums[prime_num])
                    {
                        dict_primenums[prime_num] = count;
                    }
                    if (i == 1)
                    {
                        break;
                    }
                }
                if (i != 1)
                    dict_primenums.Add(num, 1);

            }
        }

    }
}
