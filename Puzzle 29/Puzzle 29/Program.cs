using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Project Euler Problem 34 - https://projecteuler.net/problem=34
namespace Puzzle_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            int[] arr_fact_digits=new int[10];
            arr_fact_digits[0] = 1;


            for(int i =1;i<arr_fact_digits.Length;i++)
            {
                arr_fact_digits[i] = Factorial(i);
            }

            int Factorial(int num)
            {
                if (num == 1)
                    return 1;
                return num * Factorial(num - 1);
            }

            foreach (int i in arr_fact_digits)
                Console.WriteLine(i);

            for(int i=3;i<2541060;i++)
            {
                int temp = i;
                int sum = 0;
                while(temp !=0)
                {
                    sum += arr_fact_digits[temp % 10];
                    temp = temp / 10;
                }
                if(sum==i)
                {
                    ans += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
