using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
 * Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?*/



namespace Puzzle_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            int len = num.Length;
            double max = 0;
            double prod = 1;
            int digits = int.Parse(Console.ReadLine());
            //FINDING THE PRODUCT OF THE FIRST "DIGIT" CONSECUTIVE NUMBERS
            for (int i = 0; i < digits; i++)
            {
                prod = prod * int.Parse(num[i].ToString());
            }

            /* Logic is divide the "prod" with the "first number" that was used to get the "prod" and 
               multiply it with the number next to the "last number" that was used to get the "prod".
               This way we get the consecutive prod*/
            for (int j = 0; j <= len - digits - 1; j++)
            {
                /*Logic is that if the "prod" of the cosecutive integers is zero, it means there is a zero present.
                 We find the "position" of the last zero that occurs in the consecutive number.
                 So, obviously all consecutive numbers that include this "position", the prod will be 0.
                 Hence, we need to find the "prod" of the consecutive integers after the position
                 */
                if (prod == 0)
                {
                    j = FindPosZero(j);
                    getProd(j + 1, digits);
                }
                else
                {
                    prod = prod / int.Parse(num[j].ToString());
                    /* If the number next to the "last number" that was used to get the "prod" ==0. 
                       In this case we need not find the position as we already know it.
                       We simply find the "prod" of the next consecutive digits.
                     */
                    if (int.Parse(num[j + digits].ToString()) == 0)
                    {
                        getProd(j + digits + 1, digits);
                        j = j + digits;

                        if (prod > max)
                        {

                            Console.WriteLine("from {0} & prod is {1}", j + 1 + 1, prod);
                            max = prod;
                        }
                    }
                    else
                    {
                        prod = prod * int.Parse(num[j + digits].ToString());

                        if (prod > max)
                        {
                            Console.WriteLine("from {0} & prod is {1}", j + 1, prod);
                            max = prod;
                        }
                    }
                }

            }

            Console.WriteLine("MAX PROD IS {0}", max);

            int FindPosZero(int j)
            {
                int pos = 0;
                for (int i = j + digits - 1; i >= j; i--)
                {
                    if (int.Parse(num[i].ToString()) == 0)
                    {
                        pos = i;
                        break;
                    }
                }
                return pos;
            }

            void getProd(int j, int digit)
            {
                prod = 1;

                for (int i = 0; i < digits; i++)
                {
                    if (j + i < len)//this condition is to ensure we do not go out of bounds
                        prod = prod * int.Parse(num[j + i].ToString());
                    else
                        prod = 0;
                }
            }
            Console.ReadKey();

        }
    }
}
