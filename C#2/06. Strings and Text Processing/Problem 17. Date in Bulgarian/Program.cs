﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format:
day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

namespace Problem_17.Date_in_Bulgarian
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a date and time in the format [dd.MM.yyyy HH:mm:ss]: ");
            string date = Console.ReadLine();

            DateTime dateTime = DateTime.Parse(date).AddHours(6).AddMinutes(30);
            Console.WriteLine("{0} {1}", dateTime.DayOfWeek, dateTime);
        }
    }
}
