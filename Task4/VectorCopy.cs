using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class VectorCopy
    {
        int[] array;
        public int[] ArrayProp
        {
            get { return array; }
            set { array = value; }
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set
            {
                array[index] = value;
            }
        }
        public VectorCopy() : this(0) { }

        public VectorCopy(int n)
        {
            array = new int[n];
        }

        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < array.Length; i++)
            {
                line += array[i] + " ";
            }
            return line;
        }

        public void InitRandom(int a, int b)
        {
            Random random1 = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random1.Next(a, b);
            }
        }

        
      
    }
}
