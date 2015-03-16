using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	output
Hi!	\u0048\u0069\u0021
 */

namespace Problem_10.Unicode_characters
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(string.Format(@"\n{0:X4}", (int)text[i]));
            }
            Console.WriteLine();
        }
    }
}
