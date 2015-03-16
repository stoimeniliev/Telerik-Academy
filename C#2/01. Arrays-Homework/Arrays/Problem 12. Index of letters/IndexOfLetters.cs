using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Index_of_letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {

            char[] alphabetArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Please write a word: ");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            for (int i = 0; i < wordArray.Length; i++)
            {
                for (int j = 0; j < alphabetArray.Length; j++)
                {
                    if (wordArray[i] == alphabetArray[j])
                    {
                        char letter = wordArray[i];
                        Console.WriteLine(Array.IndexOf(alphabetArray, letter));
                    }
                }
                
            }
        }
    }
}
