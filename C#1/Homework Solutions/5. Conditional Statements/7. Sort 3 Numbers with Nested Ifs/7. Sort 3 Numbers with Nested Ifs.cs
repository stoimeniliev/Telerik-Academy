using System;

//Problem 7. Sort 3 Numbers with Nested Ifs
//• Write a program that enters 3 real numbers and prints them sorted in descending order. ◦ Use nested  if  statements.
//Note: Don’t use arrays and the built-in sorting functionality.
//Examples:
//a       b       c       result
//5       1       2       5 2 1 
//-2      -2      1       1 -2 -2 
//-2      4       3       4 3 -2 
//0       -2.5    5       5 0 -2.5 
//-1.1    -0.5    -0.1    -0.1 -0.5 -1.1 
//10      20      30      30 20 10 
//1       1       1       1 1 1 

class Sort_3_Numbers_with_Nested_Ifs
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());


        if (a >= b && a >= c)
        {
            Console.Write(a + " ");
            if (b >= c)
            {
                Console.Write(b + " ");
                Console.Write(c);
            }
            else
            {
                Console.Write(c + " ");
                Console.Write(b);
            }
        }
        else if (b >= a && b >= c)
        {
            Console.Write(b + " ");
            if (a >= c)
            {
                Console.Write(a+ " ");
                Console.Write(c + " ");
            }
            else
            {
                Console.WriteLine(c + " ");
                Console.WriteLine(a);
            }
        }

        else if (c >= b && c >= a)
        {
            Console.WriteLine(c + " ");
            if (b >= a)
            {
                Console.WriteLine(b + " ");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(a + " ");
                Console.WriteLine(b);
            }
        }
    }
}

