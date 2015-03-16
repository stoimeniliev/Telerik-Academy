using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
 */

namespace Problem_11.Format_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D} to Decimal", num);
            Console.WriteLine("{0,15:X} to Hexadecimal", num);
            Console.WriteLine("{0,15:P} to Percentage", num);
            Console.WriteLine("{0,15:E} to Scientific notation", num);
        }
    }
}
