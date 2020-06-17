using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] words2 = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] words3 = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string[,] words4 = new string[8, 9];
            int ans = 0;

            for (int i = 0; i < words3.Length; i++)
            {
                for (int j = 0; j < words1.Length - 1; j++)
                {
                    words4[i, j] = String.Concat(words3[i], words1[j]);
                    //Console.WriteLine(words4[i, j]);
                }

            }
            

            //from 1 to 10
            for (int i = 0; i < words1.Length; i++)
            {
                ans += words1[i].Length;
               
            }
            Console.WriteLine("1 to 10 {0}", ans);

            //from 11 to 19
            for (int i = 0; i < words2.Length; i++)
            {
                ans += words2[i].Length;
            }
            Console.WriteLine("11 to 19 {0}", ans);

            //for 20,30,40,..90
            for (int i = 0; i < words3.Length; i++)
            {
                ans += words3[i].Length;
            }
            Console.WriteLine("20,30,40 to 90 {0}", ans);

            //for 21,22...29,31,32....39,....99
            for (int i = 0; i < 8; i++)
            {
                for(int j =0; j<9;j++)
                ans += words4[i,j].Length;
            }
            Console.WriteLine("21,29,31 to 939 {0}", ans);


            //from 101 to 999 excluding 100,200,300,...900
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j < words1.Length; j++)

                    ans += words1[i].Length + 10 + words1[j].Length;

                for (int j = 0; j < words2.Length; j++)
                    ans += words1[i].Length + 10 + words2[j].Length;

                for (int j = 0; j < words3.Length; j++)
                    ans += words1[i].Length + 10 + words3[j].Length;
                for (int j = 0; j < 8; j++)
                    for (int k = 0; k < 9; k++)
                        ans += words1[i].Length + 10 + words4[j, k].Length;
            }
            // for 100,200,300...900
            for (int i = 0; i <= 8; i++)
            {
                ans += words1[i].Length + 7;
            }

            //for one thousand
            ans += 11;

            Console.WriteLine("the total number of letters are {0} ",ans);
            Console.ReadKey();
        }
    }
}

