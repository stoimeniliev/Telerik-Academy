using System;
/*
 * Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
namespace Problem_11.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            //if you want to test the program, just uncomment
            int[] array = { 1, 2, 5, 6, 9, 10, 12, 4, -1};
            //int[] array = { 1, 2, 5, 6, 9, 10, 12, 4, -1 };
            //int[] array = { 11, -2, 53, 16, 69, -10, -12, 4, -1 };
            Console.Write("Your array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
            Array.Sort(array);
            Console.Write("Your sorted array is: ");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + ", ");
            }
            Console.WriteLine("Desired number's index: ");
            int n = int.Parse(Console.ReadLine());
            
            int index = BSearch(array, 0, array.Length - 1, n);
            Console.WriteLine(index);

        }
        public static int BSearch(int[] array, int lowBound, int highBound, int n)
        {
            int mid;
            while (lowBound <= highBound)
            {
                mid = (lowBound + highBound) / 2;
                if (array[mid] < n)
                {
                    lowBound = mid + 1;
                    continue;
                }
                else if (array[mid] > n)
                {
                    highBound = mid - 1;
                    continue;
                }
                
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
