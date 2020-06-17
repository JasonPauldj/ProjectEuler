using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Project Euler Problem 32 - https://projecteuler.net/problem=32
namespace Puzzle_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string pandigital = "123456789";
            int ans = 0;
            List<int> pandigital_prod = new List<int>();

            //so multicand(d1)*multiplier(d2)=products(d3)
            //here d1,d2,d3 are the numbers of digts in the multicand, multiplier and product respectively
            //pandigital will have 9 digts(1-9) in jumbled up order
            //Hence, d1+d2=d3
            //Also d3>=(d1 or d2) and using these we get (d1=1,d2=4,d3=4) and (d1=2,d2=3,d3=4)
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1023; j <= 9999; j++)
                {
                    int prod = i * j;
                    if (prod.ToString().Length == 4)
                    {
                        string check = i.ToString() + j.ToString() + prod.ToString();
                        char[] digits = check.ToCharArray();
                        Array.Sort(digits);
                        check = "";
                        foreach (char c in digits)
                        {
                            check += c;
                        }
                        //checking if it is pandigital and hasn't appeared before
                        if (check == pandigital && !pandigital_prod.Contains(prod))
                        {
                            pandigital_prod.Add(prod);
                            Console.WriteLine("{0} * {1} = {2}", i, j, prod);
                            ans += prod;
                        }

                    }
                    else
                        break;
                }

            }

            for (int i = 12; i <= 99; i++)
            {
                for (int j = 102; j <= 999; j++)
                {
                    int prod = i * j;
                    if (prod.ToString().Length == 4)
                    {
                        string check = i.ToString() + j.ToString() + prod.ToString();
                        char[] digits = check.ToCharArray();
                        Array.Sort(digits);
                        check = "";
                        foreach (char c in digits)
                        {
                            check += c;
                        }
                        if (check == pandigital && !pandigital_prod.Contains(prod))
                        {
                            pandigital_prod.Add(prod);
                            Console.WriteLine("{0} * {1} = {2}", i, j, prod);
                            ans += prod;
                        }

                    }
                    else
                        break;
                }
            }
            Console.WriteLine("ans is {0}", ans);
         //   Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
