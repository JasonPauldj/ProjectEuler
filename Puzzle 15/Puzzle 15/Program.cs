using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_15
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1901, 1, 1);
            //Console.WriteLine(dt.DayOfWeek);
            int ans=0;
            for (int i = 0; i <= 1200; i++)
            {
                DateTime test = dt.AddMonths(i);
                if (test.DayOfWeek.ToString() == "Sunday")
                {
                    ans++;
                    Console.WriteLine(test.ToLongDateString());
                }
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
