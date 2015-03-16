using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements in the array? ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int Result = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("What number to find?");
            int k = int.Parse(Console.ReadLine());
            if (arr[0] > k)
            {
                Console.WriteLine("There is no number that is less than or equal to k.");
            }
            else
            {
                int IndexOfElement = Array.BinarySearch(arr, k);
                if (IndexOfElement >= 0)
                {
                    Result = arr[IndexOfElement];
                    Console.WriteLine("The largest number of the array with value <=k is : " + Result);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        
                        if (arr[i] <= k)
                        {
                            Result = arr[i];
                        }
                    }
                    Console.WriteLine("The largest number of the array with value <=k is : " + Result);
                }
            }
        }
    }
}
