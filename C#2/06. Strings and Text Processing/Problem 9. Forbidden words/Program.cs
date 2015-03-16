using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/*
 * Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */

namespace Problem_9.Forbidden_words
{
    class Program
    {
        static void Main(string[] args)
        {

            //To test it simply change the text or the forbidden words!
            string  text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbidden = { "PHP", "CLR", "Microsoft" };
            string[] textNew = text.Split(' ');
            for (int i = 0; i < textNew.Length; i++)
            {

                for (int j = 0; j < forbidden.Length; j++)
                {
                    if (textNew[i].Contains(forbidden[j]))
                    {
                        string aster = new String('*', forbidden[j].Length);
                        textNew[i] = aster;
                    }
                }
            }

            for (int i = 0; i < textNew.Length; i++)
            {
                Console.Write(textNew[i] + " ");
            }
        }
    }
}
