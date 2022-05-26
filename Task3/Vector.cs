using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Vector
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
        public void Bubble()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        int item = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = item;
                    }
                }
            }
        }
        public void Counting()
        {
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            int[] temp = new int[max - min + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[array[i] - min]++;
            }
            int count = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i]; j++)
                {
                    array[count] = i + min;
                    count++;

                }

            }
        }

        public void InitShuffle()
        {
            int number;
            int count = 0;
            Random random1 = new Random();

            while (count < array.Length)
            {
                number = random1.Next(1, array.Length + 1);
                if (Array.IndexOf(array, number) == -1)
                {
                    array[count] = number;
                    count++;
                }
            }
        }
        public void InitShuffleFirst()
        {
            int number;
            Random random1 = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    number = random1.Next(1, array.Length + 1);
                    bool isExist = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (array[j] == number)
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        array[i] = number;
                        break;
                    }

                }
            }

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
        public Pair LongestFrequency(Pair[] pairs)
        {
            int maxFrequency = 0;
            Pair result = new Pair(0, 0);
            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i].Frequency > maxFrequency)
                {
                    maxFrequency = pairs[i].Frequency;
                }
            }
            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i].Frequency == maxFrequency)
                {
                    result = pairs[i];
                }
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
        public bool IsIntPalindrom(string input) //also for enjoyment
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
            int[] temp = new int[array.Length];
            for (int i = array.Length, j = 0; i > 0; i--, j++)
            {

                int number = array[i - 1];
                temp[j] = number;
            }
            array = temp;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public void StandartReverse()
        {
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
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