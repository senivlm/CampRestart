using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampRestart.VectorsAndMatrix
{
    internal class Vector
    {
        int[] array;

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
        public Vector() : this(0) { }

        public Vector(int n)
        {
            array = new int[n];
        }
        public void InitRandom(int a, int b)
        {
            Random random1 = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random1.Next(a, b);
            }
        }
        public void InitShuffle()
        {
            int index = Array.IndexOf(array, 0);
            Console.WriteLine(index);
            //int number;
            //Random random1 = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    while (true)
            //    {
            //        number = random1.Next(1, array.Length + 1);
            //        bool isExist = false;
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (array[j] == number)
            //            {
            //                isExist = true;
            //                break;
            //            }
            //        }
            //        if(!isExist)
            //        {
            //            array[i] = number;
            //            break;
            //        }

            //    }
            //}

        }
        public Pair[] CalcFrequency()
        {
            Pair[] pairs = new Pair[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                pairs[i] = new Pair(0, 0);
            }
            int countDifference = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if (array[i] == pairs[j].Number)
                    {
                        pairs[j].Frequency++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Frequency++;
                    pairs[countDifference].Number = array[i];
                    countDifference++;
                }
            }
            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }
            return result;
        }
        public bool IsPalindrom(string input)
        {
            {
                string equalStr1 = "";
                string equalStr2 = "";
                for (int i = 0; i < input.Length / 2; i++)
                {
                    equalStr1 = equalStr1 + input[i];
                }
                for (int i = (input.Length - 1) / 2; i >= 0; i--)
                {
                    equalStr2 = input[i] + equalStr2;
                }

                if (equalStr1 == equalStr2)
                {
                    Console.WriteLine("It's a palindrom");
                    return true;
                }
                else
                {
                    Console.WriteLine("It isn`t a palindrom");
                    return false;
                }
            }
        }
        public bool IsIntPalindrom(string input)
        {
            string[] strArray = input.Split(' ');
            int[] result = new int[strArray.Length];

            for (int i = 0; i < result.Length; i++)
            {
                int number = int.Parse(strArray[i]);
                result[i] = number;
            }
            int count = 0;
            for (int i = 0; i < result.Length / 2; i++)
            {
                if (result[i] == result[result.Length - 1 - i])
                {
                    count++;
                }
                else
                {
                    count = 0;
                    break;
                }
            }
            if (count > 0 || result.Length == 1)
            {
                Console.WriteLine("It`s a palindrom"); ;
                return true;
            }
            else
            {
                Console.WriteLine("It isn`t a palindrom");
                return false;
            }
        }
        public void ManualReverse()
        {
            for (int i = 0; i < array.Length; i++)
            {

            }
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
    }
}