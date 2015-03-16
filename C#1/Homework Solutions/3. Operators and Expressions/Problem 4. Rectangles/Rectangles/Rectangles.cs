using System;
/*
 Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter is: " + (height*2 + width*2));
            Console.WriteLine("Area is: " + (height * width));
            
        }
    }
}
