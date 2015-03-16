using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
 */

namespace Problem_3.Decimal_to_hexadecimal
{
    class DecToHex
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(number));
        }

        private static string DecimalToHex(long number)
        {
            
            string hex = "";
            while (number > 0)
            {
                long digit = number % 16;
                if (digit >= 0 && digit <=9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <=15)
                {
                    hex = (char)(digit - 10 + 'A') + hex;
                }
                number /= 16;
            }
            return hex;
        }
    }
}
