using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 1. Define class

Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 */
namespace Problem_1.Define_class
{
    class Battery
    {
        private string batteryModel;
        private int batteryIdle;
        private int batteryTalk;
        private BatteryTypeEnum batteryType;

        public Battery(string batteryModel, int batteryIdle, int batteryTalk, BatteryTypeEnum batteryType)
        {
            this.BatteryModel = batteryModel;
            this.BatteryIdleTime = batteryIdle;
            this.BatteryTalkTime = batteryTalk;
            this.BatteryType = batteryType;
        }
        public Battery(string batteryModel)
        { }

        public string BatteryModel
        {

            get { return batteryModel; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    batteryModel = value;
                }
            }
        }

        public int BatteryIdleTime
        { 

            get { return batteryIdle;}
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Must be higher than 0");
                }
                else
                {
                    batteryIdle = value;
                }
            }

                
        
        }

        public int BatteryTalkTime
        {

            get { return batteryTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Must be higher than 0");
                }
                else
                {
                    batteryTalk = value;
                }
            }

        }

        public BatteryTypeEnum BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        
        
        
        }
        public override string ToString()
        {
            return string.Format("Battery model: {0}\nHours idle: {1} h\nTalk time: {2} h\nBattery type: {3}",
                this.BatteryModel, this.BatteryIdleTime, this.BatteryTalkTime, this.BatteryType);
        }

    }
}
