using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/*
 * Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number
 */

namespace Problem_10.N_Factorial
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(number);
            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
