using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

input	
3, 2, 3, 4, 2, 2, 4
 * 
 * result 2, 3, 4
 */

namespace Maximal_Increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long would you like array to be?");
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            int current;
            int element = 0;
            int currentMax = 1;
            int counter = 0; ;
            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());

            }
            current = sequence[0];
            for (int i = 0; i < n - 1; i++)
            {
                if (sequence[i] + 1 == sequence[i + 1])
                {
                    counter++;
                    if (counter > currentMax)
                    {
                        currentMax = counter;
                        element = sequence[i];

                    }


                }
                else if (sequence[i] + 1 != sequence[i + 1])
                {
                    if (counter > currentMax)
                    {
                        currentMax = counter;
                        element = sequence[i];
                        counter = 0;

                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }
            element = element + 1 - currentMax;
            if (n <= 1)
            {
                Console.WriteLine("There is no sequence to be displayed");
            }
            else
            {
                for (int i = element; i <= element + currentMax; i++)
                {
                    Console.Write(i + " ");


                }
            }
        }
    }
}
