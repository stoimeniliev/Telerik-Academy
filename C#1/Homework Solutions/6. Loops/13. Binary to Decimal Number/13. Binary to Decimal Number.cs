using System;

//Problem 13. Binary to Decimal Number
//• Using loops write a program that converts a binary integer number to
//its decimal form.
//• The input is entered as string. The output should be a variable of type long.
//• Do not use the built-in .NET functionality.

//Examples:
//binary                          decimal
//0                               0 
//11                              3 
//1010101010101011                43691 
//1110000110000101100101000000    236476736 

class Binary_to_Decimal_Number
{
    static void Main()
    {
        Console.WriteLine("Enter binary:");
        string binary = Console.ReadLine();
        int[] num = new int[binary.Length];
        long decimalNum = 0;
        long degree = binary.Length - 1;
        for (int i = 0; i < binary.Length; i++)
        {
            char ch = binary[i];
            num[i] = Convert.ToInt32(ch.ToString());
            decimalNum += num[i] * (long)Math.Pow(2, degree);
            degree--;
        }
        Console.WriteLine("{0}", decimalNum);
    }
}
