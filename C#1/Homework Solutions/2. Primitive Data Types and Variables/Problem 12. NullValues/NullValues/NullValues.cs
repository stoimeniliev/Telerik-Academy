using System;
/*
 Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
 */
namespace NullValues
{
    class NullValues
    {
        static void Main(string[] args)
        {
            int? value1 = null;
            double? value2 = null;
            Console.WriteLine("value 1: " + value1 + " " + "value 2: " + value2);
            value1 = 10;
            value2 = 15;
            Console.WriteLine("value 1: " + value1 + " " + "value 2: " + value2);
        }
    }
}
