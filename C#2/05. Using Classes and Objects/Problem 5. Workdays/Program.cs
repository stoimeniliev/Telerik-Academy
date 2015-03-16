using System;
using System.Linq;
/*
 * Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

namespace Problem_5.Workdays
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime user = DateTime.Parse(Console.ReadLine());
            Console.WriteLine((GetWorkingDays(user)));
        }
        public static int GetWorkingDays(DateTime to)
        {

            DateTime[] dt = {
                            
             new DateTime(2015, 01, 25), new DateTime(2015, 01, 6), new DateTime(2015, 2, 5),
             new DateTime(2015, 2, 14), new DateTime(2015, 03, 6), new DateTime(2015, 06, 23)


                            };

            var dayDifference = (int)to.Subtract(DateTime.Now).TotalDays;
            return Enumerable
                .Range(1, dayDifference)
                .Select(x => DateTime.Now.AddDays(dayDifference))
                .Count(x => x.DayOfWeek != DayOfWeek.Saturday && x.DayOfWeek != DayOfWeek.Sunday && !x.Equals(dt) );
        }

    }
}
