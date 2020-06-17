using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Puzzle_14
{
    class Problem18
    {

        public static void Main(string[] args)
        {
            new Problem18().BruteForce();
            //new Problem18().Dynamic();
        }


        public void BruteForce()
        {
            Stopwatch clock = Stopwatch.StartNew();
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\input.txt";
            int[,] inputTriangle = readInput(filename);

            int posSolutions = (int)Math.Pow(2, inputTriangle.GetLength(0) - 1);
            int largestSum = 0;
            int tempSum, index;

            for (int i = 0; i < posSolutions; i++)
            {
                tempSum = inputTriangle[0, 0];
                index = 0;
                Console.WriteLine("-----New Solution-----");
                Console.WriteLine("Value of i is {0}", i);
                for (int j = 0; j < inputTriangle.GetLength(0) - 1; j++)
                {
                    index = index + (i >> j & 1);
                   // Console.WriteLine("i is {0} and j is {1} and i >> j is {2}",i,j,i >> j);
                    Console.WriteLine("pos is [{0}][{1}]",j+1,index);
                    tempSum += inputTriangle[j + 1, index];
                }

                if (tempSum > largestSum)
                {
                    largestSum = tempSum;
                }
            }
            clock.Stop();
            Console.WriteLine("The largest sum through the triangle is: {0}", largestSum);
            Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
            Console.ReadKey();
        }


       //public void Dynamic()
       // {
       //     Stopwatch clock = Stopwatch.StartNew();

       //     string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\input.txt";
       //     int[,] inputTriangle = readInput(filename);
       //     int lines = inputTriangle.GetLength(0);
       //     int[] largestValues = new int[lines];

       //     //Initialise the algorithm
       //     for (int i = 0; i < lines; i++)
       //     {
       //         largestValues[i] = inputTriangle[lines - 1, i];
       //     }

       //     for (int i = lines - 2; i >= 0; i--)
       //     {
       //         for (int j = 0; j <= i; j++)
       //         {
       //             largestValues[j] = inputTriangle[i, j] + Math.Max(largestValues[j], largestValues[j + 1]);
       //         }
       //     }

       //     clock.Stop();
       //     Console.WriteLine("The largest sum through the triangle is: {0}", largestValues[0]);
       //     Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
       // }


        private int[,] readInput(string filename)
        {
            string line;
            string[] linePieces;
            int lines = 0;

            StreamReader r = new StreamReader(filename);
            while ((line = r.ReadLine()) != null)
            {
                lines++;
            }

            int[,] inputTriangle = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputTriangle[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }

            r.Close();

            return inputTriangle;
        }
    }



}