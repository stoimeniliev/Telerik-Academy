using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
Example:

input	
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	
 * result: 4 (5 times)
 */

namespace Problem_9.Frequent_number
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            //If you would like to test for different cases, just uncomment!

            int[] array = { 1, 2, 5, 5, 5, 5, 6, 2, 1, 1, 1, };
            int index = 0;
            int currentMax = 0;
            int topMax = 0;
            //int[] array = {1, 2, 5, 5, 5, 5, 5, 6, 2, 1, 1, 1, };
            //int[] array = { 1, 2, 5, 5, 5, 5, 6, 2, 1, 1, 1, 1, 1, 1, 1 };
            //int[] array = { 1, 2, 5, 5, 5, 5, 6, 2, -1, -1, -1, -1, -1, -1 };
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        currentMax++;
                    }

                }
                if (currentMax > topMax)
                {
                    topMax = currentMax;
                    currentMax = 0;
                    index = array[i];
                }
                currentMax = 0;

            }
            Console.WriteLine(index + " ({0} times)", topMax);
        }
    }
}
