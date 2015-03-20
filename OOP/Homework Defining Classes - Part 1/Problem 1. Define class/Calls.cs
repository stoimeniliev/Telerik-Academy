using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_1.Define_class
{
    class Calls
    {

        //private string callWith;
        private int callLength;
        private string dialedPhone;
        private DateTime date;
        private DateTime time;

        public Calls(DateTime date, DateTime time, string dialedPhone, int callLength)
        {
            
            this.Time = time;
            this.Date = date;
            
            this.DialedPhone = dialedPhone;
            this.CallLength = callLength;
        
        }

        public Calls(string dialedPhone, int callLength)
        {
            
            this.DialedPhone = dialedPhone;
            this.CallLength = callLength;

        }

        
        public int CallLength
        {
            get { return this.callLength; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght should be longer than 0");
                }
                else
                {
                    this.callLength = value;
                }
            }

        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else if (value.Length > 11)
                {
                    throw new ArgumentException("Mnogo dulgi");
                }
                else
                {
                    this.dialedPhone = value;
                }
            }

        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                { this.date = value; }
            }
        
        }
        public DateTime Time
        {
            get { return this.time; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                { this.time = value; }
            }

        }
        public override string ToString()
        {
            return string.Format("Date: {0}\nTime: {1}Call with: {2};\nduration: {3}\nCall ", this.Date, this.Time, this.DialedPhone, this.CallLength);
        }

    }

}
