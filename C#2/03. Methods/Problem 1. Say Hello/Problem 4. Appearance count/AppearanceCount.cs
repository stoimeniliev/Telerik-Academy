using System;
/*
 * Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */

namespace Problem_4.Appearance_count
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements?");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Which element to count?");
            int k = int.Parse(Console.ReadLine());
            GetCount(arr, k);
        }

        static void GetCount(int[] arr, int k)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    counter++;
                }
            }
            Console.WriteLine("The element {0} appears {1} times in the array", k, counter);
        }
    }
}
