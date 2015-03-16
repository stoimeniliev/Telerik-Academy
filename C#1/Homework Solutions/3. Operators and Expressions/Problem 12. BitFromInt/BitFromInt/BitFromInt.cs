using System;
/*
Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
 */

namespace BitFromInt
{
    class BitFromInt
    {
        static void Main(string[] args)
        {
            int number= int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int result = mask & number;
            result = result >> position;
            Console.WriteLine(result);
            
        
        }
    }
}
