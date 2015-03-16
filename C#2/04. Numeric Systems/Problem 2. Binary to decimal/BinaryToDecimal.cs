using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
 */

namespace Problem_2.Binary_to_decimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(number));
        }

        static long BinaryToDecimal(string binaryNumber)
        {
            long decimalNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                //binaryNumber[i] ---> '0' or '1'
                int digit = binaryNumber[i] - '0';
                int position = binaryNumber.Length - i - 1;

                decimalNumber += digit * (long)Math.Pow(2, position); 
            }
            return decimalNumber;

        }
    }
}
