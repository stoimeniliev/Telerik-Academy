using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 6. binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

namespace Problem_6.binary_to_hexadecimal
{
    class BinaryToHex
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(DecimalToHex(BinaryToDecimal(number)));
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
        private static string DecimalToHex(long number)
        {

            string hex = "";
            while (number > 0)
            {
                long digit = number % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex = (char)(digit - 10 + 'A') + hex;
                }
                number /= 16;
            }
            return hex;
        }
    }
}
