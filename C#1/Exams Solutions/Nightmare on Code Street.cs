using System;


namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
		
		// Uslovie na zada4ata http://bgcoder.com/Contests/Practice/DownloadResource/514
		
            string digits = Console.ReadLine();
            char[] text = digits.ToCharArray();

            int counter = 0;
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                
                if (i % 2 != 0 && i !=0)
                {
                    if (Char.IsDigit(text[i]))
                    {

                        counter++;
                        sum = sum + int.Parse(text[i].ToString());
                    }
                }
                
                
            }
            Console.Write(counter + " " + sum);
            
            
        }
    }
}
