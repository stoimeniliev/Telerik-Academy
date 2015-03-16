using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

namespace Problem_5.Hexadecimal_to_binary
{
    class HexToBinary
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(DecimalBinary(HexToDecimal(number)));

        }

        static long HexToDecimal(string hex)
        {
            long decimalNumber = 0;
            for (int i = 0; i < hex.Length; i++)
            {

                int digit = 0;
                if (hex[i] >= '0' && hex[i] <= '9')
                {

                    digit = hex[i] - '0';
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    digit = hex[i] - 'A' + 10;
                }
                decimalNumber += digit * (long)Math.Pow(16, hex.Length - i - 1);

            }
            return decimalNumber;
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
