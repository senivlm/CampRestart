using Task3And4;

//Vector vector1 = new Vector(20);
//vector1.InitRandom(1, 5);

//Console.WriteLine(vector1);

//Pair[] pairs = vector1.CalcFrequency();

//for (int i = 0; i < pairs.Length; i++)
//{
//    Console.WriteLine(pairs[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine("Longest frequency is: " + vector1.LongestFrequency(pairs));

//Vector vector2 = new Vector(6);
//vector2.InitShuffle();

//Console.WriteLine(vector2);

//Vector vector3 = new Vector(10);
//vector3.InitRandom(1, 20);
//Console.WriteLine(vector3);
//vector3.SplitMergeSort();
//Console.WriteLine(vector3);

//Vector vector4 = new Vector();
//vector4.ManualInitialisation();

//Console.WriteLine(vector4);
//vector4.HeapSort();

//Console.WriteLine(vector4);

Vector vector5 = new Vector(20);
vector5.InitRandom(1, 100);
Console.WriteLine(vector5);
vector5.WriteArrayToFile();

Vector vector6 = new Vector();
vector6.ReadFromFile();
Console.WriteLine(vector6);
