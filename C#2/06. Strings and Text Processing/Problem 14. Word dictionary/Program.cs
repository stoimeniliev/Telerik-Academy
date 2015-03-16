using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


/*
 * Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	output
.NET	platform for applications from Microsoft
CLR	managed execution environment for .NET
namespace	hierarchical organization of classes
 */


namespace Problem_14.Word_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");

            Console.WriteLine("Current words in dictionary: CRL, .NET, namespace" );
            string word = Console.ReadLine();
            if (dict.ContainsKey(word))
            {
                string value = dict[word];
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("No such word in dict");
            }
                    

        }
    }
}
