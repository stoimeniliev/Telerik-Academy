using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
 */

namespace Problem_2.Compare_arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, dear Sir, please write the desired length of the first array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you, kindly! Now do me a favor and write the desired length of the second array: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("You are simply awesome! Now, take time to write elements one by one (Remember that they sould be {0}): ", n);
            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[m];
            bool areEqual = true;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter element number {0} ", i + 1);
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Almost done! You shouldn't have picked such a long length!. Enter the elements of the second array, they should be {0}): ", m);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter element number {0} ", i + 1);
                arrayTwo[i] = int.Parse(Console.ReadLine());
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
