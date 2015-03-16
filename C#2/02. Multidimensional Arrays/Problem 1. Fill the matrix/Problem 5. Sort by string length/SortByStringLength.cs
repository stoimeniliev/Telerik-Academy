using System;
/*
 * Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 * */

namespace Problem_5.Sort_by_string_length
{
    class SortByStringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements in the array?");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Please type the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Array.Sort(arr,(x, y) => x.Length.CompareTo(y.Length));
            foreach (string element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}
