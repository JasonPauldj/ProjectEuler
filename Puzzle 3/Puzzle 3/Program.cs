using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, len;
            bool is_prime;
            ArrayList list_primenum = new ArrayList();
            list_primenum.Add(2);
            len = 1;
            //for getting the prime numbers below 1000
            for (i = 3; i < 1000000; i = i + 2)
            {
                is_prime = true;
                foreach (int j in list_primenum)
                {
                    if (i % j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }
                if (is_prime)
                {
                    list_primenum.Add(i);
                    len++;
                }
            }
           
            //below commented code is for printing the prime numbers
            //Console.WriteLine("this are all the prime numbers");
            /* for printing the prime numbers
            foreach (int j in list_primenum)
            {
                Console.WriteLine(j);
            }*/

            //this array is used to store all the prime numbers that can be expressed as a sum of consecutive prime numbers
            /*ArrayList list_res = new ArrayList();*/

            bool is_possible;
            int ans=0, max_count=0;
            for (i = 0; i < len; i++)
            {
                is_possible = true;
                ArrayList list_pns = new ArrayList();
                int prime_num = (int)list_primenum[i];
                int sum = 0;
                int end = prime_num / 2;
                int count = 0;

                foreach (int j in list_primenum)
                {
                    if (j <= end)
                    {
                        list_pns.Add(j);
                        sum += j;

                    }
                    else
                    {
                        count = list_pns.Count;
                        break;
                    }
                }
                if (sum == prime_num)
                {
                    
                    if(count >= max_count)
                    {
                        max_count = count;
                        ans = prime_num;
                    }
                    //list_res.Add(prime_num);
                    continue;
                }
                if (sum < prime_num)
                {
                    is_possible = false;
                    continue;
                }
                if (is_possible)
                {
                    int chk_sum = sum;
                    int cnt = list_pns.Count;
                    for (int j = cnt - 1; j >= 0; j--)
                    {
                        
                        chk_sum -= (int)list_pns[j];
                        count -= 1;
                        if (chk_sum == prime_num)
                        {
                            if(count >= max_count)
                            {
                                max_count = count;
                                ans = prime_num;
                            }
                           // list_res.Add(prime_num);
                            break;
                        }
                        else if (chk_sum < prime_num)
                        {
                            count += 1;
                            chk_sum += (int)list_pns[j];
                            break;
                        }

                    }

                    foreach (int k in list_pns)
                    {
                        chk_sum -= k;
                        count -= 1;
                        if (chk_sum == prime_num)
                        {
                            if(count >= max_count)
                            {
                                max_count = count;
                                ans = prime_num;
                            }
                            //list_res.Add(prime_num);
                            break;
                        }
                        else if (chk_sum < prime_num)
                        {
                            break;
                        }
                    }


                }
                else
                {
                    continue;
                }


            }
            Console.WriteLine("the result is as follows");

            //the below commented code is used to diplay all the prime numbers that can be expressed as the sum of consecutive prime numbers
            /*foreach (int j in list_res)
            {
                Console.WriteLine(j);
            }*/

            Console.WriteLine(ans);
            Console.ReadKey();
        }




    }
}
