using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
 */

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
                sb.Append(s[i]);
            Console.WriteLine(sb.ToString());
        }
    }
}
