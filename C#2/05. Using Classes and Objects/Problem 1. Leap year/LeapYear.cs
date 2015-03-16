using System;




namespace Problem_1.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} leap.",
                year, (DateTime.IsLeapYear(year)) ? "IS" : "IS NOT");
        }
    }
}
