using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation 
 over the first letter of the string with the first of the key, the second 
– with the second, etc. When the last key character is reached, the next is the first.
 */

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text that you want to decode/encode");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the decoder");
            string cipher = Console.ReadLine();
            Console.WriteLine("The decoded is: " + Encoder(text, cipher));
            Console.WriteLine("The decoded is: " + Encoder(Encoder(text, cipher), cipher));
        }

        private static string Encoder(string text, string cipher)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
			{
			int inputLetter = (int)text[i];
            int cipherLetter = (int)cipher[i % cipher.Length];
            sb.Append((char)(inputLetter ^ cipherLetter));
			}


            return sb.ToString();
        }
    }
}
