using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
 */

namespace Problem_6.String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string text = Console.ReadLine();
            if (text.Length > 20)
            {
                Console.WriteLine("Too long try again");
            }
            else
            {
                foreach (var item in text)
                {
                    sb.Append(item);
                }

                while (sb.Length < 20)
                {
                    sb.Append("*");
                }
                Console.WriteLine(sb);
            }
            

        }
    }
}
