using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 
 * and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. 
 * The lexicographic permutations of 0, 1 and 2 are:
 * 012   021   102   120   201   210
 * What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
 * 
 */

namespace Puzzle_19
{
    class Program
    {
        static string ans;
        static void ModifyArray(int pos, List<int> numbers)
        {
            Console.WriteLine("removing the number {0} from pos {1}", numbers[pos], pos);
            ans = ans + numbers[pos].ToString();
            numbers.RemoveAt(pos);
            return;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of digits you will use. \nFor Example if you enter 4 we will be using 0,1,2,3");
            int n = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[n];
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(i);
            }


            int min = 1;
            int max = Factorial(n);
            Console.WriteLine(max);
            Console.WriteLine("Enter the position of the lexicographic order that you want to find and it should be between {0} and {1}", min, max);
            int pos_to_find = Convert.ToInt32(Console.ReadLine());

            Find_Num_Rem(pos_to_find -1, n - 1);

            ans = ans + numbers[0];

            Console.WriteLine("answer is {0}", ans);
            Console.ReadKey();

            int Factorial(int num)
            {
                if (num == 1)
                    return 1;
                int prod = num;
                return prod * Factorial(num - 1);
            }

            void Find_Num_Rem(int pos_cnt, int no_of_digits)
            {
                foreach (int num in numbers)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
                int rem;
                int divisor = Factorial(no_of_digits);

                //if (no_of_digits - 1 != 0)
                //{
                int quotient;
                quotient = pos_cnt / divisor;
                rem = pos_cnt % divisor;
                Console.WriteLine("pos is {0}/{1}", pos_cnt, divisor);
                Console.WriteLine("quotient is {0}", quotient);
                Console.WriteLine("rem is {0}", rem);
                ModifyArray(quotient, numbers);


                if (no_of_digits - 1 != 0)
                {
                    Find_Num_Rem(rem, no_of_digits - 1);
                }
                else
                    return;
            }
            //else
            //{

            //    //Console.WriteLine("rem is {0}", rem);
            //    //ModifyArray(rem, numbers);
            //        return;

            //}
        }


    }
}
