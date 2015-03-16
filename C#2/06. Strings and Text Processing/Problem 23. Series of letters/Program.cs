using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 */

namespace Problem_23.Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            for (int i = 0; i < sb.Length; i++)
            {
                char letter = sb[i];
                for (int j = i + 1; j < sb.Length; j++)
                {
                    if (sb[j] == letter)
                    {
                        sb.Remove(j, 1);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
