using System;
using System.Globalization;

/*
 * Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */

namespace Problem_16.Date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start date in the following format: day.month.year ");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter end date in the following format: day.month.year ");
            string endDate = Console.ReadLine();

            DateTime firstDate = DateTime.ParseExact(startDate, "d.M.yyyy",
        CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(endDate, "d.M.yyyy",
        CultureInfo.InvariantCulture);
            Console.WriteLine("The difference is: " + Math.Abs((firstDate - secondDate).TotalDays));
        }
    }
}
