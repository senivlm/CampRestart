using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task6
{
    internal class TextHandler
    {
        List<string> strings = new List<string>();

        string line = "";

        public TextHandler(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);
                line += reader.ReadToEnd();
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
        public override string ToString()
        {
            return line;
        }

        public List<string> MakeSentence()
        {
            string[] array = line.Split('.');
            for (int i = 0; i < array.Length; i++)
            {
                strings.Add(array[i]);
                Console.WriteLine(strings[i] + ".");
            }
            return strings;
        }
        
        public List<string> MakeWords()
        {
            string[] array = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                strings.Add(array[i]);
                Console.WriteLine(strings[i]);
            }
            return strings;
        }
        public void WriteToFile(string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            for (int i = 0; i < strings.Count; i++)
            {
                writer.WriteLine(strings[i]);
            }
            writer.Close();
        }

        public string RemoveExtraSpaces()
        {
            line = line.Trim();
            StringBuilder stringBuilder = new StringBuilder("");
            
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ' && line[i + 1] == ' ')
                {
                    continue;
                }
                stringBuilder.Append(line[i]);
            }
            line = stringBuilder.ToString();
            return line;
        }
    }
}
