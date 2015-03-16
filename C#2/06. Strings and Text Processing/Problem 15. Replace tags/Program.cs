using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

namespace Problem_15.Replace_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace("<a href=\"", "[URL=");
            input = input.Replace("\">", "]");
            input = input.Replace("</a>", "[/URL]");
            Console.WriteLine(input);
        }
    }
}
