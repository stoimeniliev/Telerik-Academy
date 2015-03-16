using System;
/*
 Problem 7. Quotes in Strings

Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.
 */

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string quote1 = "The \"use\" of quotations causes difficulties.";
            string quote2 = @"The ""use"" of quotations causes difficulties.";
            
            Console.WriteLine(quote1);
            Console.WriteLine(quote2);
        }
    }
}
