using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

//Using names.txt(right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
//Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
//For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
//So, COLIN would obtain a score of 938 × 53 = 49714.
//What is the total of all the name scores in the file?
 
namespace Puzzle_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\names.txt";
            StreamReader r = new StreamReader(filename);
            r.BaseStream.Seek(0, SeekOrigin.Begin);
            string all_names;
            string[] arr_names;
            all_names = r.ReadToEnd();
            int ans = 0;

            arr_names = all_names.Split(',');
            int len = arr_names.Length;
            Console.WriteLine("the total number of names is {0} ", len);

            for (int i = 0; i < len; i++)
            {
                arr_names[i] = arr_names[i].Replace("\"", "");
            }

            for (int j = 0; j < len - 1; j++)
            {
                for (int i = 0; i < len - 1; i++)
                {
                    if (arr_names[i].CompareTo(arr_names[i + 1]) == 1)
                    {
                        string temp = arr_names[i];
                        arr_names[i] = arr_names[i + 1];
                        arr_names[i + 1] = temp;
                    }
                }
            }
            //int test = 0;
            //foreach (string name in arr_names)
            //{
            //    test++;
            //    Console.WriteLine("name at {0} is {1}",test,name);
            //}
           
            
            for (int j = 0; j < len; j++)
            {
                int score = 0;
                int name_len = arr_names[j].Length;
                byte[] asciibytes = Encoding.ASCII.GetBytes(arr_names[j]);
                for (int k = 0; k < name_len; k++)
                {
                    score += (asciibytes[k] - 65 + 1);
                }
                ans += (score * (j + 1));
            }

            //string test = "ABC";
            //int score=0;
            //byte[] asciibytes = Encoding.ASCII.GetBytes(test);
            //for (int k = 0; k < asciibytes.Length; k++)
            //{
            //    Console.WriteLine(asciibytes[k]);
            //    score += (int)asciibytes[k]-65 + 1;
            //}
            //Console.WriteLine("score is {0}",score);
            Console.WriteLine("solution is {0}", ans);
            Console.ReadKey();
        }
    }
}
