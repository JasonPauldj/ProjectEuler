using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, 
 * the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
 * A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if 
 * this sum exceeds n.
 * As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as 
 * the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
 * Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
 */
 
namespace Puzzle_18_Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al_abd_num = new ArrayList();
            double ans = 0;
            for (int i=1;i<= 28123;i++)
            {
                int sum = FindSumDivisors(i);
                if(sum > i)
                {
                    al_abd_num.Add(i);
                }
            }

            Console.WriteLine("int max calus is {0}", int.MaxValue);
            int len = al_abd_num.Count;

            bool[] canBeWrittenasAbundent = new bool[28124];
            for (int i = 0; i < al_abd_num.Count; i++)
            {
                for (int j = i; j < al_abd_num.Count; j++)
                {
                    if ((int)al_abd_num[i] + (int)al_abd_num[j] <= 28123)
                    {
                        canBeWrittenasAbundent[(int)al_abd_num[i] + (int)al_abd_num[j]] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }


          for(int i=1;i<=28123;i++)
            {
                if(!canBeWrittenasAbundent[i])
                {
                    ans += i;
                }
            }
           
            Console.WriteLine("ans is {0}",ans);
            Console.ReadKey();


            int FindSumDivisors(int num)
            {
                int sum = 1;
                int i = 2;
                while (i * i <= num)
                {
                    if (num % i == 0)
                    {
                        if (num / i == i)
                            sum += i;
                        else
                            sum = sum + i + num / i;
                    }
                    i++;
                }
                return sum;
            }
           
        }
    }
}
