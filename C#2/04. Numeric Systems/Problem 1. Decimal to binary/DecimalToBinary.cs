using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
 */

namespace Problem_1.Decimal_to_binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalBinary(number));
        }

        static string DecimalBinary(long decimalNumber)
        {
            string binaryNumber = "";
            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber = digit + binaryNumber;
                decimalNumber = decimalNumber / 2;
            }
            return binaryNumber;
        }
    }
}
