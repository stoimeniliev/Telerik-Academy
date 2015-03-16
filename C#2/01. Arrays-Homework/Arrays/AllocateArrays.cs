using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
 */

namespace Arrays
{
    class AllocateArrays
    {
        static void Main(string[] args)
        {
            int[] myIntArray;
            myIntArray = new int[20];
            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = i * 5;
                Console.Write(myIntArray[i] + ", ");
            }
        }
    }
}
