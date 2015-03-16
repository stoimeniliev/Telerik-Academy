using System;
/*
 * Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm.
 */

namespace Problem_14.Quick_sort
{
    class QuickSort
    {
        static void Main(string[] args)
        {

            // Create an notSorted array of string elements
            int[] notSorted = { 1, 22, 2, 44, 55, 33, 23 };
            // Print the notSorted array
            for (int i = 0; i < notSorted.Length; i++)
            {
                Console.Write(notSorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            QuicksortSearch(notSorted, 0, notSorted.Length - 1);

            // Print the sorted array
            for (int i = 0; i < notSorted.Length; i++)
            {
                Console.Write(notSorted[i] + " ");
            }

        }

        public static void QuicksortSearch(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuicksortSearch(elements, left, j);
            }

            if (i < right)
            {
                QuicksortSearch(elements, i, right);
            }
        }

    }
}
