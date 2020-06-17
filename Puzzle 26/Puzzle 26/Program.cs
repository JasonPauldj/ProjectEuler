using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Project Euler Problem 31 - https://projecteuler.net/problem=31
namespace Puzzle_26
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] coin_values = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int final_val = 200;
            int[] max_coins = new int[coin_values.Length];
            int ans = 0;
            for (int i = 0; i < coin_values.Length; i++)
            {
                max_coins[i] = final_val / coin_values[i];
            }
            for (int a = 0; a <= max_coins[1]; a++)
                for (int b = 0; b <= max_coins[2]; b++)
                    for (int c = 0; c <= max_coins[3]; c++)
                        for (int d = 0; d <= max_coins[4]; d++)
                            for (int e = 0; e <= max_coins[5]; e++)
                                for (int f = 0; f <= max_coins[6]; f++)
                                {
                                    if (2 * a + 5 * b + 10 * c + 20 * d + 50 *e +100 *f <= 200)
                                    {
                                        ans++;
                                    }
                                }
            /* i am adding 1 beacause there are 2 additional ways {1p*200 or 200p*1} but 
            in the above iterations i will get a case when a=b=c=d=e=f=0 ..this case needs to be subtracted.*/
            ans += 1; 
            Console.ReadKey();
        }
    }
}
