using System;
/*
 Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */

namespace CirclePandR
{
    class CirclePandR
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;

            double radius = double.Parse(Console.ReadLine());
            double area = pi * radius * radius;
            double perimeter = 2 * pi * radius;
            Console.WriteLine("The perimeter of the circle is: " + Math.Round(perimeter, 2));
            Console.WriteLine("The area of the circle is: " + Math.Round(area, 2));

        }
    }
}
