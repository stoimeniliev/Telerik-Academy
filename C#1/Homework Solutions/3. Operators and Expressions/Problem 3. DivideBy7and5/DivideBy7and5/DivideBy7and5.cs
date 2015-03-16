using System;
/*
 Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 */

namespace DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main(string[] args)
        {
            int divide = int.Parse(Console.ReadLine());
            if (divide != 0)
            {
                bool trueFalse = (divide % 7 == 0 && divide % 5 == 0);
                Console.WriteLine(trueFalse);  
            }
            else if (divide == 0)
            { 
                bool trueFalse = false;
                Console.WriteLine(trueFalse);
            }
        }
    }
}
