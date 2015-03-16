using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

namespace Problem_3.Correct_brackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {

            string brackets = Console.ReadLine();
            

            int bracketCount = 0;

            foreach (var letter in brackets)
            {
                if (letter == '(')
                    ++bracketCount;
                else if (letter == ')')
                    --bracketCount;

                if (bracketCount < 0)
                {
                    Console.WriteLine("Brackets not correct!");
                    break;
                }
            }
            if (bracketCount != 0)
            {
                Console.WriteLine("Brackets not correct!");
            }
            else
            {
                Console.WriteLine("Brackets are correct");
            }

        }
    }
}
