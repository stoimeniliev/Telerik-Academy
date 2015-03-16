using System;
/*
 Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            double moonWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the moon would be: " + moonWeight * 0.17);

        }
    }
}
