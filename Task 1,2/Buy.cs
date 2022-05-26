using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2And3
{

    internal class Buy
    {
        private int boughtNumber;
        private double boughtPrice;
        private double boughtWeight;
        public int BoughtNumber { get; set; }
        public double BoughtPrice { get; set; }
        public double BoughtWeight { get; set; }

        public Buy() : this(0, 0.0, 0.0) { }

        public Buy(int boughtNumber, double boughtWeight, double boughtPrice)
        {
            BoughtNumber = boughtNumber;
            BoughtWeight = boughtWeight;
            BoughtPrice = boughtPrice;
        }

        public override string ToString()
        {
            return string.Format("Goods: " + BoughtNumber + " Weight: " + BoughtWeight +
                " Price: " + BoughtPrice);
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Buy);
        }
        public void Parse(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            string[] arrayStr = str.Split(' ');
            if (!(int.TryParse(arrayStr[0], out boughtNumber)))
            {
                throw new ArgumentException();
            }
            if (!(double.TryParse(arrayStr[1], out boughtWeight)))
            {
                throw new ArgumentException();
            }
            if (!(double.TryParse(arrayStr[2], out boughtPrice)))
            {
                throw new ArgumentException();
            }
        }
    }
}
