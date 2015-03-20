using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class GSMTest
    {

        static void Main()
        {
            
        Console.WriteLine(GSM.IPhone);


        GSM[] mobilePhones = new GSM[3];
        mobilePhones[0] = new GSM("Iphone 6+", "Apple", 1000, "Tito", new Battery("Apple", 350, 17, BatteryTypeEnum.LiIon), new Display(5, 16));
        mobilePhones[1] = new GSM("Xperia S3", "Apple", 800, "Mito", new Battery("Apple", 590, 12, BatteryTypeEnum.LiIon), new Display(4, 16));
        mobilePhones[2] = new GSM("Xperia S2", "Apple", 600, "Vito", new Battery("Apple", 710, 9, BatteryTypeEnum.LiIon), new Display(4, 16));
        for (int i = 0; i < mobilePhones.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine(mobilePhones[i]);
        }



        GSM myGSM = new GSM("Titos Xperia S4", "Apple", 1000, "Tito", new Battery("Apple", 350, 17, BatteryTypeEnum.LiIon), new Display(5, 160000));
        //Console.WriteLine(tito);
        // for simplification just these date and times

        var date = new DateTime(2014, 1, 18);
        var time = DateTime.Parse("10:00:00 AM");
        

        myGSM.AddCalls(date.Date, time, "0883462942", 42);
        myGSM.AddCalls(date.Date, time, "0889011202", 31);
        myGSM.AddCalls(date.Date, time, "0883462942", 62);

            
        foreach (var calls in myGSM.CallHistory)
        {
            Console.WriteLine(calls);
            Console.WriteLine();
        }




        double money = myGSM.CalculateTotalPrice(0.37);
        Console.WriteLine("Spent money for calls: {0}", money);

        myGSM.DeleteLongestCall(); //Deleting the longest call



        money = myGSM.CalculateTotalPrice(0.37);
        Console.WriteLine("Price after the longest call is deleted: {0}", money); //price after longest call



        myGSM.ClearCallHistory();
        Console.WriteLine("We just cleaned the call list, this is what we have there:");
        Console.WriteLine();

        foreach (var call in myGSM.CallHistory)
        {
            Console.WriteLine(call);
            Console.WriteLine();
        }
        }
    }
}
