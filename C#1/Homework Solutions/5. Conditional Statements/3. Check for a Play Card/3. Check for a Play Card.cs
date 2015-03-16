using System;

//Problem 3. Check for a Play Card
//• Classical play cards use the following signs to designate the card face:
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
//and prints “yes” if it is a valid card sign or “no” otherwise.
//Examples:
//character       Valid card sign?
//5               yes 
//1               no 
//Q               yes 
//q               no 
//P               no 
//10              yes 
//500             no 

class Check_for_a_Play_Card
{
    static void Main()
    {
        string cards = Console.ReadLine();
        if (cards.Equals("2") || cards.Equals("3") || cards.Equals("4") || cards.Equals("5") || cards.Equals("6") || cards.Equals("7") || cards.Equals("8") || cards.Equals("9") || cards.Equals("10") || cards.Equals("J") || cards.Equals("Q") || cards.Equals("K") || cards.Equals("A"))
        {
            Console.WriteLine("yes");
        }
        else
            Console.WriteLine("no");
    }
}

