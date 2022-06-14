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
        
        public List<string> Strings
        {
            get { return strings; }
            set { strings = value; }
        }

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

        public List<string> MakeSentence() //i think, it is another way here
        {
            string[] array = line.Split('.'); 
            for (int i = 0; i < array.Length; i++)
            {
                strings.Add(array[i]);
            }
            return strings;
        }
        
        public List<string> MakeWords()
        {
            string[] array = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                strings.Add(array[i]);
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
                writer.WriteLine(strings[i] + ".");
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
        public string MakeWordCollection(int index)
        {
            string sentence = strings[index];
            return sentence;
        }
        public void FindMinMaxWord(string sentence) //it doesn't work correctly, MakeSentence is problem?
        {
            string[] words = sentence.Split(' ');
            
            int min = words[0].Length;
            int max = words[0].Length;
            
            string longestWord = words[0];
            string shortestWord = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    longestWord = words[i];
                    max = words[i].Length;
                }
                if (words[i].Length < min)
                {
                    shortestWord = words[i];
                    min = words[i].Length;
                }
            }
            Console.WriteLine("The longest word in sentence: " + longestWord + '\n' +
                "The shortest word in sentence: " + shortestWord);
        }
        public void PrintMinMaxWordColl()
        {
            for (int i = 0; i < strings.Count; i++)
            {
                string temp = strings[i];
                Console.WriteLine();
                FindMinMaxWord(temp);
            }
        }
        
    }
}
