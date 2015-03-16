﻿using System;
using System.Collections.Generic;
using System.Globalization;
//### Problem 19. Dates from text in Canada
//*	Write a program that extracts from a given text all dates that match the format `DD.MM.YYYY`.
//*	Display them in the standard date format for Canada.
class Program
{
    static void Main()
    {
        string txt = "TThi is a story about how my file got flipper-turned upside down 19.01.2015 In west philadlphia born and raised 25.06.2017. on the playground is where i spend most of my days Fake: 1.1.2014, 15.5.2012";
        string[] words = txt.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        List<DateTime> dates = new List<DateTime>();
        for (int i = 0; i < words.Length; i++)
        {
            // take care of trailing '.' if current word was at the end of sentence
            if (words[i][words[i].Length - 1] == '.')
            {
                words[i] = words[i].Substring(0, words[i].Length - 1);
            }

            DateTime date;
            if (DateTime.TryParseExact(words[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                dates.Add(date);
            }
        }

        //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        foreach (var item in dates)
        {
            //string output = item.ToString(new CultureInfo("en-CA"));
            Console.WriteLine(item.ToString(new CultureInfo("en-CA")));
        }
    }
}