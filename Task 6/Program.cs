
using Task6;

TextHandler text1 = new TextHandler("TextFile.txt");

//text1.MakeSentence();

text1.MakeWords();
text1.WriteToFile("Result.txt");