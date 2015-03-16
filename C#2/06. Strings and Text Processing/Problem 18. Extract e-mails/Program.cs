using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

namespace Problem_18.Extract_e_mails
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "You can write me to hello@abv.bg. Our office@abv.bg is not active nor is com.yahoo@office";
            string[] words = txt.Split(' ', ',');
            List<string> mails = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                
                if (words[i].Contains("@"))
                {
                    
                    if (words[i][words[i].Length - 1] == '.')
                    {
                        words[i] = words[i].Substring(0, words[i].Length - 1);
                    }

                    
                    if (words[i].Contains("."))
                    {
                        if (words[i].IndexOf('@') < words[i].IndexOf('.'))
                        {
                            mails.Add(words[i]);
                        }
                    }
                }
            }

            foreach (var item in mails)
            {
                Console.WriteLine(item);
            }
        }
    }
}
