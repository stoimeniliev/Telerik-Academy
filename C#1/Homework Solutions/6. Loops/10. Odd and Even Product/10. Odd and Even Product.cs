using System;

//Problem 10. Odd and Even Product
//• You are given  n  integers (given in a single line, separated by a space).
//• Write a program that checks whether the product of the odd elements is equal
//to the product of the even elements.
//• Elements are counted from  1  to  n , so the first element is odd, the second 
//is even, etc.

//Examples:
//numbers             result
//2 1 1 6 3           yes 
//product = 6  
  
//3 10 4 6 5 1        yes 
//product = 60  
  
//4 3 2 5 2           no 
//odd_product = 16  
//even_product = 15 

class Odd_and_Even_Product
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] numSeparated = numbers.Split(new Char[] { ' ' });
        double odd = 1.0;
        double even = 1.0;
        for (int i = 1; i <= numSeparated.Length; i++)
        {
            if (i % 2 != 0)
            {
                odd *= double.Parse(numSeparated[i-1]);    
            }
            else if (i % 2 == 0)
            {
                even *= double.Parse(numSeparated[i-1]); 
            }

        }
        Console.WriteLine(odd + " " + even);
        if (odd == even)
        {
            Console.WriteLine("Yes");
        }
        else if (odd != even)
        {
            Console.WriteLine("No");
        }
     

    }
}
