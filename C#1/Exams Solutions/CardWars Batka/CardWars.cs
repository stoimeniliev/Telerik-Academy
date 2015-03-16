using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars_Batka
{
    class CardWars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oneWon = 0;
            int twoWon = 0;
            int oneScore = 0;
            int twoScore = 0;
            
            for (int i = 0; i < n; i++)
            {
                string fCardo = Console.ReadLine();
                string sCardo = Console.ReadLine();
                string tCardo = Console.ReadLine();

                string fCardt = Console.ReadLine();
                string sCardt = Console.ReadLine();
                string tCardt = Console.ReadLine();

                if (fCardo.Equals(2))
                    oneScore += 10;
                else if (fCardo.Equals(3))
                    oneScore += 9;
                else if (fCardo.Equals(4))
                    oneScore += 8;
                else if (fCardo.Equals(5))
                    oneScore += 7;
                else if (fCardo.Equals(6))
                    oneScore += 6;
                else if (fCardo.Equals(7))
                    oneScore += 5;
                else if (fCardo.Equals(8))
                    oneScore += 4;
                else if (fCardo.Equals(9))
                    oneScore += 3;
                else if (fCardo.Equals(10))
                    oneScore += 2;
                else if (fCardo.Equals('A'))
                    oneScore += 1;
                else if (fCardo.Equals('J'))
                    oneScore += 11;
                else if (fCardo.Equals('Q'))
                    oneScore += 12;
                else if (fCardo.Equals('K'))
                    oneScore += 13;
                else if (fCardo.Equals('X'))
                {
                    oneScore += 9;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    break;
                }
                else if (fCardo.Equals('Z'))
                    oneScore *= 2;
                else if (fCardo.Equals('Y'))
                    oneScore -= 200;


                
                if (sCardo.Equals(2))
                    oneScore += 10;
                else if (sCardo.Equals(3))
                    oneScore += 9;
                else if (sCardo.Equals(4))
                    oneScore += 8;
                else if (sCardo.Equals(5))
                    oneScore += 7;
                else if (sCardo.Equals(6))
                    oneScore += 6;
                else if (sCardo.Equals(7))
                    oneScore += 5;
                else if (sCardo.Equals(8))
                    oneScore += 4;
                else if (sCardo.Equals(9))
                    oneScore += 3;
                else if (sCardo.Equals(10))
                    oneScore += 2;
                else if (sCardo.Equals('A'))
                    oneScore += 1;
                else if (sCardo.Equals('J'))
                    oneScore += 11;
                else if (sCardo.Equals('Q'))
                    oneScore += 12;
                else if (sCardo.Equals('K'))
                    oneScore += 13;
                else if (sCardo.Equals('X'))
                {
                    oneScore += 9;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    break;
                }
                else if (sCardo.Equals('Z'))
                    oneScore *= 2;
                else if (sCardo.Equals('Y'))
                    oneScore -= 200;
                
                
                if (tCardo.Equals(2))
                    oneScore += 10;
                else if (tCardo.Equals(3))
                    oneScore += 9;
                else if (tCardo.Equals(4))
                    oneScore += 8;
                else if (tCardo.Equals(5))
                    oneScore += 7;
                else if (tCardo.Equals(6))
                    oneScore += 6;
                else if (tCardo.Equals(7))
                    oneScore += 5;
                else if (tCardo.Equals(8))
                    oneScore += 4;
                else if (tCardo.Equals(9))
                    oneScore += 3;
                else if (tCardo.Equals(10))
                    oneScore += 2;
                else if (tCardo.Equals('A'))
                    oneScore += 1;
                else if (tCardo.Equals('J'))
                    oneScore += 11;
                else if (tCardo.Equals('Q'))
                    oneScore += 12;
                else if (tCardo.Equals('K'))
                    oneScore += 13;
                else if (tCardo.Equals('X'))
                {
                    oneScore += 9;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    break;
                }
                else if (tCardo.Equals('Z'))
                    oneScore *= 2;
                else if (tCardo.Equals('Y'))
                    oneScore -= 200;



                if (fCardt.Equals(2))
                    twoScore += 10;
                else if (fCardt.Equals(3))
                    twoScore += 9;
                else if (fCardt.Equals(4))
                    twoScore += 8;
                else if (fCardt.Equals(5))
                    twoScore += 7;
                else if (fCardt.Equals(6))
                    twoScore += 6;
                else if (fCardt.Equals(7))
                    twoScore += 5;
                else if (fCardt.Equals(8))
                    twoScore += 4;
                else if (fCardt.Equals(9))
                    twoScore += 3;
                else if (fCardt.Equals(10))
                    twoScore += 2;
                else if (fCardt.Equals('A'))
                    twoScore += 1;
                else if (fCardt.Equals('J'))
                    twoScore += 11;
                else if (fCardt.Equals('Q'))
                    twoScore += 12;
                else if (fCardt.Equals('K'))
                    twoScore += 13;
                else if (fCardt.Equals('X'))
                {
                    twoScore += 9;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    break;
                }
                else if (fCardt.Equals('Z'))
                    twoScore *= 2;
                else if (fCardt.Equals('Y'))
                    twoScore -= 200;


                

                if (sCardt.Equals(2))
                    twoScore += 10;
                else if (sCardt.Equals(3))
                    twoScore += 9;
                else if (sCardt.Equals(4))
                    twoScore += 8;
                else if (sCardt.Equals(5))
                    twoScore += 7;
                else if (sCardt.Equals(6))
                    twoScore += 6;
                else if (sCardt.Equals(7))
                    twoScore += 5;
                else if (sCardt.Equals(8))
                    twoScore += 4;
                else if (sCardt.Equals(9))
                    twoScore += 3;
                else if (sCardt.Equals(10))
                    twoScore += 2;
                else if (sCardt.Equals('A'))
                    twoScore += 1;
                else if (sCardt.Equals('J'))
                    twoScore += 11;
                else if (sCardt.Equals('Q'))
                    twoScore += 12;
                else if (sCardt.Equals('K'))
                    twoScore += 13;
                else if (sCardt.Equals('X'))
                {
                    twoScore += 9;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    break;
                }
                else if (sCardt.Equals('Z'))
                    twoScore *= 2;
                else if (sCardt.Equals('Y'))
                    twoScore -= 200;

                

                if (tCardt.Equals(2))
                    twoScore += 10;
                else if (tCardt.Equals(3))
                    twoScore += 9;
                else if (tCardt.Equals(4))
                    twoScore += 8;
                else if (tCardt.Equals(5))
                    twoScore += 7;
                else if (tCardt.Equals(6))
                    twoScore += 6;
                else if (tCardt.Equals(7))
                    twoScore += 5;
                else if (tCardt.Equals(8))
                    twoScore += 4;
                else if (tCardt.Equals(9))
                    twoScore += 3;
                else if (tCardt.Equals(10))
                    twoScore += 2;
                else if (tCardt.Equals('A'))
                    twoScore += 1;
                else if (tCardt.Equals('J'))
                    twoScore += 11;
                else if (tCardt.Equals('Q'))
                    twoScore += 12;
                else if (tCardt.Equals('K'))
                    twoScore += 13;
                else if (tCardt.Equals('X'))
                {
                    twoScore += 9;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    break;
                }
                else if (tCardt.Equals('Z'))
                    twoScore *= 2;
                else if (tCardt.Equals('Y'))
                    twoScore -= 200;

                if (oneScore > twoScore)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score:" + oneScore);
                    oneWon++;
                }
                else if (oneScore < twoScore)
                {
                    
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score:" + twoScore);
                    oneWon++;
                }
                else if (oneScore == twoScore)
                {
                    oneScore
                }
                


            }
        }
    }
}
