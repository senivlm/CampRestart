using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Pair
    {
        private int number;
        private int frequency;

        public int Number { get => number; set => number = value; }
        public int Frequency { get => frequency; set => frequency = value; }

        public Pair(int number, int frequency)
        {
            Number = number;
            Frequency = frequency;
        }
        public override string ToString()
        {
            return $"{number} - {frequency}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Pair))
            {
                return false;
            }
            return Number == ((Pair)obj).Number && Frequency == ((Pair)obj).Frequency;

        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
