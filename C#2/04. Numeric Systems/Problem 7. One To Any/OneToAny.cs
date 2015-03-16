﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

class OneToAny
{
    static void Main()
    {
        

        Console.WriteLine("Choose the first numeral system [2...16]:");
        int firstNumSystem = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number in {0}-based numberal system:", firstNumSystem);
        long input = Math.Abs(long.Parse(Console.ReadLine()));
        Console.WriteLine("Choose the second numeral system into which you want to convert [2...16]:");
        int secondNumSystem = int.Parse(Console.ReadLine());
        long number = input;
        long decNumber = 0;
        int power = 0;
        while (number > 0)
        {
            int digit = (int)number % 10;
            digit *= (int)Math.Pow(firstNumSystem, (double)power);
            decNumber += digit;
            power++;
            number /= 10;
        }
        StringBuilder str = new StringBuilder();
        while (decNumber > 0)
        {
            str.Insert(0, decNumber % secondNumSystem);
            decNumber /= secondNumSystem;
        }
        Console.WriteLine("The number {0} in {1}-based numeral system is: {2} in {3}-based numeral system\n"
        , input, firstNumSystem, str.ToString(), secondNumSystem);
    }
}