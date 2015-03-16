﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */

namespace Problem_8.Extract_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Write a word to find: ");
            string word = " " + Console.ReadLine() + " ";
            string[] textSplit = text.Split('.');

            for (int i = 0; i < textSplit.Length; i++)
            {
                if (textSplit[i].IndexOf(word) > 0)
                {
                    Console.Write(textSplit[i] + ".");
                }
            }
            Console.WriteLine();
        }
    }
}
