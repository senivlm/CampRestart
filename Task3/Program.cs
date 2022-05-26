

using Task3;

Vector vector1 = new Vector(20);
vector1.InitRandom(1, 5);

Console.WriteLine(vector1);

Pair[] pairs = vector1.CalcFrequency();

for (int i = 0; i < pairs.Length; i++)
{
    Console.WriteLine(pairs[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Longest frequency is: " + vector1.LongestFrequency(pairs));

Vector vector2 = new Vector(6);
vector2.InitShuffle();

Console.WriteLine(vector2);