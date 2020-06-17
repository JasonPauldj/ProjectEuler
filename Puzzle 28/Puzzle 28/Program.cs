using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Project Euler Problem -33 https://projecteuler.net/problem=33
namespace Puzzle_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int  prod_num = 1;
            int prod_denom = 1;
            for(int i=11;i<=50;i++)
            {
               // Console.WriteLine("CHECKING FOR NUM {0}", i);
                if (i % 10 == 0)
                {
                    continue;
                }
                else
                {
                    int tens_digit =(int) i / 10;
                    int unit_digit = (int)i % 10;
                    int tens_upper_bound = (int)(tens_digit + 1) ;
                    int units_upper_bound = (int)(unit_digit * 10);

                    for (int j = i+1; j < (tens_upper_bound *10) ; j++)
                    {
                        //Console.WriteLine(j);
                        if((float)unit_digit/ (j%10) == (float)(i/j))
                        {
                            prod_num *=(int) i;
                            prod_denom *=(int) j;
                            Console.WriteLine("fraction is {0}/{1}", i, j);
                        }
                    }
                    //Console.WriteLine();

                    if (unit_digit>tens_digit)
                    {
                      
                        for(float k= 1; k<=9;k++)
                        {
                            //Console.WriteLine(units_upper_bound + k);
                            if (i / (units_upper_bound + k) == (tens_digit / k ))
                            {
                                prod_num *= (int)i;
                                prod_denom *= (int)(units_upper_bound + k);
                                Console.WriteLine("fraction is {0}/{1}", i, units_upper_bound + k);
                            }
                        }
                        //Console.WriteLine();
                    }

                    for(int j=tens_upper_bound;j<=9;j++)
                    {
                        //Console.WriteLine(unit_digit);
                        //Console.WriteLine(j);
                        //Console.WriteLine(j * 10 + unit_digit);
                        //Console.WriteLine(j * 10 + tens_digit);
                        
                        if (unit_digit != j)
                        {
                            if ((float)i / (j * 10 + unit_digit) == (float)(tens_digit / j))
                            {
                                prod_num *= i;
                                prod_denom *= (j * 10 + unit_digit);
                                Console.WriteLine("fraction is {0}/{1}", i, j * 10 + unit_digit);
                            }

                            if ((float)i / (j * 10 + tens_digit) == (float)(unit_digit / j))
                            {
                                prod_num *=(int) i;
                                prod_denom *= (int)(j * 10 + tens_digit);
                                Console.WriteLine("fraction is {0}/{1}", i, j * 10 + tens_digit);
                            }
                        }
                        
                    }
                   // Console.WriteLine();
                }
            }

       
            int HCF=  gcd(prod_num,prod_denom);
            Console.WriteLine(HCF);

            int gcd(int a,int b)
            {
                if (b == 0)
                    return a;
                return (gcd(b, a % b));
            }

            int ans = prod_denom / HCF;
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
