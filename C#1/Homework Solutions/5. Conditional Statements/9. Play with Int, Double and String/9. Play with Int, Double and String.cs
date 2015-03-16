using System;

//Problem 9. Play with Int, Double and String
//• Write a program that, depending on the user’s choice, inputs an  int ,  double
//or  string  variable. ◦ If the variable is  int  or  double , the program increases it by one.
//◦ If the variable is a  string , the program appends  *  at the end.
//• Print the result at the console. Use switch statement.

//Example 1:
//program                         user
//Please choose a type:  
//1 --> int  
//2 --> double                    3 
//3 --> string  

//Please enter a string:          hello 
//hello*  

//Example 2:
//program                         user
//Please choose a type:  
//1 --> int  
//2 --> double                    2 
//3 --> string  
  
//Please enter a double:          1.5 
//2.5 

class Play_with_Int_Double_and_String
{
    static void Main()
    {
        Console.WriteLine("Please choose:\n1 -> Int\n2 -> double\n3 -> string");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                {
                    Console.WriteLine("You chose Int\nPlease enter an Int");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                }
            case "2":
                {
                    Console.WriteLine("You chose double\nPlease enter a double");
                    double number = double.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                }
            case "3":
                {
                    Console.WriteLine("You chose string\nPlease enter a string");
                    string word = Console.ReadLine();
                    Console.WriteLine(word + "*");
                    break;
                }
            
        }
    }
}

