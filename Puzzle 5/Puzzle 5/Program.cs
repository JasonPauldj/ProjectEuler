using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.*/
namespace Puzzle_5
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many number digits for finding the palindrome ");
            int digit = Convert.ToInt32(Console.ReadLine());

            int start_point = (int)Math.Pow((Math.Pow(10, digit) - 1), 2);
            int end_point = (int)Math.Pow(Math.Pow(10, digit - 1), 2);

            Console.WriteLine("starting point is {0}", start_point);
            Console.WriteLine("end point is {0}", end_point);

            bool ans_found = false;
          
            //largest_digit_num is nothing but 9(for digit=1) or 99(for digit=2) or 999(for digit=3) and so on
            int largest_digit_num = (int)(Math.Pow(10, digit) - 1);

            Console.WriteLine("largest digit num is {0}", largest_digit_num);

            for (int i = start_point; i >= end_point; i--)
            {
                bool ispalindrome = false;
                ispalindrome = chkpalindrome(i);
                if (ispalindrome)
                {
                    /* since start_point = 81(for digit=1) or 9801(for digit=2) or 998001(for digit=3) and so on
                       we use the following algorithm
                       step 1: check if the number is divisible by largest_digit_num
                       step 2: if yes:check if the quo is of the required digits.
                                  if yes: answer is found because the starting point is the max possible value
                                      and reducing from there.
                       step 3: find out the quotient of i/largest_digit_num and add 1 to it.
                               Because we cannot select a number less than this quotient as a number less than this quotient 
                               would mean we have to multiply with a number greater than largest_digit_num
                       step 4: set the loop count to largest_digit_num -1.
                       step 5: logic is this we keep incrementing from max and reducing from largest_digit_num.
                               In other words, I am getting a balance between increase and decrease
                      */
                    if (i % largest_digit_num == 0)
                    {
                        int quo = i / largest_digit_num;
                        if (quo.ToString().Length == digit)
                        {
                            Console.WriteLine("the largest palindrome is {0}", i);
                            Console.WriteLine("{0} * {1}", largest_digit_num, i / largest_digit_num);
                        }
                        break;
                    }
                    
                    {
                        int max = i / largest_digit_num + 1;
                       
                        {
                            int loop_cnt = largest_digit_num -1;
                            for (int k = max; k < largest_digit_num; k++)
                            {
                                if (k <= loop_cnt && k/ Math.Pow(10, digit - 1) !=0)
                                {
                                    for (int j = loop_cnt; j >= max; j--)
                                    {
                                        if (j * k == i)
                                        {
                                            Console.WriteLine("max is {0}", max);
                                            Console.WriteLine("the largest palindrome is {0}", i);
                                            Console.WriteLine("{0} * {1}", j, k);
                                            ans_found = true;

                                        }
                                        else if (j * k < i)
                                        {
                                            loop_cnt = j;
                                            break;
                                        }
                                    }
                                }
                                if (ans_found)
                                    break;

                            }
                        }
                        if (ans_found)
                            break;
                    }
                }
            }

            //bool test = chkpalindrome(707);
            Console.ReadKey();

            bool chkpalindrome(int i)
            {
                int num = i;
                int num_rev = 0;

                while (num > 0)
                {
                    int rem = num % 10;
                    num = num / 10;
                    num_rev = rem + num_rev * 10;
                    //Console.WriteLine("i is {0}", i);
                    //Console.WriteLine("num is {0}", num);
                    //Console.WriteLine("num_rev is {0}", num_rev);
                }
                if (i == num_rev)
                {
                   // Console.WriteLine("Number is a palindrome {0}", i);
                    return true;
                }
                else
                    return false;
            }

        }
    }
}
