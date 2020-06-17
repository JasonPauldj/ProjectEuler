using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?*/

namespace Puzzle_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list_prime = new ArrayList();

            list_prime.Add(2);
            int len = 1;
            long num, quo = 0, ans = 0;

            Console.WriteLine("Enter the number for which to find the biggest prime number");
            num = Convert.ToInt64(Console.ReadLine());
            quo = num;

            for (int j = 3; j <= quo; j=j+2)
            {
                bool is_prime = false;
                is_prime = chk_numprime(j);
                if (is_prime)
                {
                    chk_ifdivisible(j);
                }
                if (quo == 1)
                {
                    break;
                }
            }

            Console.WriteLine("answer is {0}", ans);

            bool chk_numprime(int j)
            {
                for (int k = 0; k < len; k++)
                {
                    if (j % (int)list_prime[k] == 0)
                        return false;
                }
                list_prime.Add(j);
                len++;
                return true;
            }
            void chk_ifdivisible(int j)
            {

                int num_power = j;
                while (quo % num_power == 0)
                {
                    
                    quo = quo / num_power;
                    if (quo == 1)
                    {
                        ans = j;
                        break;
                    }
                    num_power *= num_power;
                }
            }
            Console.WriteLine("REACHED THE END");
            Console.ReadKey();
        }


    }
}


