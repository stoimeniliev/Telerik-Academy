using System;
/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
 */

namespace Problem_6.First_larger_than_neighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)

        {
            //if you want to check for different cases, just uncomment
            int[] arr = { 1, 2, 1, 3, 4, 5, 6, 1 };
            //int[] arr = { 1, 2, 2, 10, 4, 5, 6, 1 };
            //int[] arr = { 20, 2, 2, 10, 4, 5, 6, 1 };
            
            FindNumbers(arr);
            
        }

        private static void FindNumbers(int[] arr)
        {
            for (int i = 1; i < arr.Length -1; i++)
            {
                if (CheckLarger(arr, i) != -1)
                {
                    Console.WriteLine("The element is: " + arr[i]);
                    break;
                } 
            }
        }

        private static int CheckLarger(int[] arr, int k)
        {


            if (arr[k] > arr[k - 1] && arr[k] > arr[k + 1])
            {
                return arr[k];
            }
            else
            {
                return -1;
            }
           

        }
    }
}
