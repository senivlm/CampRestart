using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithTextFile
{
    internal class TextHandler
    {
        public string[] ReadFromFile(string fileName)
        {

            //string text = "Hello, I'm    a C#     student  - Alona";
            //string[] array = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + "*");
            //}

            string[] arrayFromFile = new string[2];
            try
            {
                StreamReader reader = new StreamReader(fileName);
                arrayFromFile[0] = reader.ReadLine();
                arrayFromFile[1] = reader.ReadToEnd();
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            return arrayFromFile;
        }
    }
}
