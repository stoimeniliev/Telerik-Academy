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
    class Display
    {
        private int displaySize;
        private int displayColorsNum;

        public Display(int displaySize, int displayColorsNum)
        {
            this.DisplaySize = displaySize;
            this.DisplayColors = displayColorsNum;
        }
        public Display(int displaySize)
        { }


        public int DisplaySize
        {
            get { return this.displaySize; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("The display must be bigger!");
                }
                else
                {
                    this.displaySize = value;
                }
            }
        
        }
        public int DisplayColors
        {
            get { return this.displayColorsNum; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("There must be some colors");
                }
                else
                {
                    this.displayColorsNum = value;
                }
            }

        }
        public override string ToString()
        {
            return string.Format("Display Size: {0}\nDisplay Colors: {1}",
                this.displaySize, this.displayColorsNum);
        }

    }
}
