using System;
/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */

namespace Problem_5.Larger_than_neighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 3, 4, 5, 6, 1 };
            int k = int.Parse(Console.ReadLine());
            CheckLarger(arr, k);
        }

        private static void CheckLarger(int[] arr, int k)
        {
            
            
                if (arr[k] > arr[k-1] && arr[k] > arr[k+1])
                {
                    Console.WriteLine("Yup");
                }
                else
                {
                    Console.WriteLine("No");
                }
            
        }
    }
}
