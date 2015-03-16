using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */

namespace Problem_8.Binary_short
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of type short: ");
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2));
        }
    }
}
