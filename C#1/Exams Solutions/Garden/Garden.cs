using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            int tomatoSeeds = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberSeeds = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoSeeds = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotSeeds = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageSeeds = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beansSeeds = int.Parse(Console.ReadLine());
            double totalCost = (tomatoSeeds * 0.5) + (cucumberSeeds * 0.4) + (potatoSeeds * 0.25) + (carrotSeeds * 0.6) + (cabbageSeeds * 0.3) + (beansSeeds * 0.4);
            Console.WriteLine("Total cost: {0:0.00}", totalCost);
            int area = 250;
            int remainingArea = area - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;
            if (remainingArea < 0)
            {
                Console.WriteLine("Insufficient area"); 
            }
            else if (remainingArea > 0)
            {
                Console.WriteLine("Beans area: " + remainingArea);
            }
            else if (remainingArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
        }
    }
}
