using System;
/*
 * Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
 and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

namespace CircleAndRectangle
{
    class CircleAndRectangle
    {
        static void Main(string[] args)
        {
            
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());
            
            
            bool inCircle = ((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1)) <= 2.25;
            bool inRectangle = ((-1 <= pointX) && (pointX <= 5)) && ((-1 <= pointY) && (pointY <= 1));
            if (inCircle && !inRectangle)
            {
                Console.WriteLine("It is in the circle and outside of the rectangle");
            }
            else
            {
                Console.WriteLine("It's not in the circle and outside of the rectangle at the same time");
            }
           
        }
    }
}
