using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int ans = 0;
            for (int num = 2; num < 1000; num++)
            {
                decimal d = (decimal)1 / num;
                string s = d.ToString();
                int cnt_initial_zeros = 1;
                int start = 2;
                int div = 10;
                int cnt_digits = 0;
                bool is_Repeat = true;
                List<int> to_check = new List<int>();
                for (int i = 2; i < s.Length; i++)
                {
                    if ((s[i] == '0'))
                    {
                        cnt_initial_zeros++;
                    }
                    else
                    {
                        div = (int)Math.Pow(10, cnt_initial_zeros);
                        break;
                    }
                }
                do
                {
                    to_check.Add(div % num);
                    cnt_digits++;
                    if (div % num == 0)
                    {
                        is_Repeat = false;
                        break;
                    }
                    else
                    {
                        div = (div % num) * 10;
                    }
                } while (!to_check.Contains((div % num)));

                if (is_Repeat)
                {
                    if (max <= cnt_digits)
                    {
                        max = cnt_digits;
                        ans = num;
                    }
                }
            }



            // Console.WriteLine(d);
            Console.WriteLine("answer is ans {0} and repeating length is {1}", ans, max);
            Console.ReadKey();
        }
    }
 }
