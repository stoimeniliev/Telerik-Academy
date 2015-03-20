using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Problem 2. Constructors

Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null. */

namespace Problem_1.Define_class
{
    class GSM
    {
        private string phoneModel;
        private string phoneManufacturer;
        private double phonePrice;
        private string phoneOwner;
        private Battery battery;
        private Display display;
        
        private static GSM iPhone = new GSM("iPhone 6+", "Apple", 599, "Tim Cook", new Battery("LiIon", 200, 500, BatteryTypeEnum.LiIon), new Display(6, 165222));
        private List<Calls> callHistory = new List<Calls>();

        public GSM(string phoneModel, string phoneManufacturer)
        {
            //this.phoneModel = phoneModel;
        }

        public GSM(string phoneModel, string phoneManufacturer, double phonePrice, string phoneOwner, Battery battery, Display display)
        {
            this.Model = phoneModel;
            this.Manufacturer = phoneManufacturer;
            this.Price = phonePrice;
            this.Owner = phoneOwner;
            this.Battery = battery;
            this.Display = display;

        }

        public string Model
        {
            get { return this.phoneModel; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.phoneModel = value;
                }
            }
        }


        public string Manufacturer
        {
            get { return this.phoneManufacturer; }
            set
            {

                if (value == string.Empty)
                { throw new ArgumentNullException(); }
                else
                {
                    this.phoneManufacturer = value;
                }
            }

        }

        public double Price
        {

            get { return this.phonePrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price of the GSM has to be positive!");
                }
                else
                {
                    this.phonePrice = value;
                }
            }

        }

        public string Owner
        {
            get { return this.phoneOwner; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.phoneOwner = value;
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        /*public Calls Calls
        {
            get { return this.calls; }
            set { this.calls = value; }

        }*/

        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }

        }

        public void AddCalls(DateTime date, DateTime time, string dialedPhone, int callLength)
        {
            //Calls newCall = new Calls(date, time, dialedPhone, callLength);
            this.CallHistory.Add(new Calls(date, time, dialedPhone, callLength));

        }

        public void RemoveCalls(int index)
        {
            if (callHistory.Count > index && index > -1)
            {
                callHistory.RemoveAt(index);
            }
            else
            {
                throw new ArgumentException("The required call is not in the list.");
            }

        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }


        public double CalculateTotalPrice(double pricePerMinute)
        {
            double spentMoney = 0.0;
            double entireDuration = 0.0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                entireDuration += CallHistory[i].CallLength;
            }
            spentMoney += (entireDuration * pricePerMinute);
            return spentMoney;
        }

        public void DeleteLongestCall()
        {
            int longestCallIndex = 0;
            int duration = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].CallLength > duration)
                {
                    duration = CallHistory[i].CallLength;
                    longestCallIndex = i;
                }
            }

            CallHistory.RemoveAt(longestCallIndex);
        }

        public override string ToString()
        {
            return string.Format("GSM model: {0}\nGSM manifacturer: {1}\nGSM price: {2}\nGSM owner: {3}\n{4}\n{5}",
                this.phoneModel, this.phoneManufacturer, this.phonePrice, this.phoneOwner, this.battery, this.display);
        }

        
        public static GSM IPhone
        {
            get
            {
                return iPhone;
            }
        }



    }
}
