using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
 */

namespace Problem_3.Compare_char_arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please write the desired length of the first array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the desired length of the second array: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, take time to write elements one by one (Remember that they sould be {0}): ", n);
            char[] arrayOne = new char[n];
            char[] arrayTwo = new char[m];
            bool areEqual = true;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter element number {0} ", i + 1);
                arrayOne[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the elements of the second array, they should be {0}): ", m);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter element number {0} ", i + 1);
                arrayTwo[i] = char.Parse(Console.ReadLine());
            }
            if (n != m)
            {
                Console.WriteLine("Sorry to inform you, but the elements of these arrays not the same ");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (arrayOne[i] != arrayTwo[i])
                    {
                        areEqual = false;
                    }

                }
                if (areEqual == true)
                {
                    Console.WriteLine("They have the same elements");
                }
                else if (areEqual != true)
                {
                    Console.WriteLine("They don't have the exact same elements");
                }
            }
        }
    }
}
