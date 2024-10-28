int[] masyvas = { 54, 12, 5, 8 };

for (int i = 0; i < masyvas.Length; i++)
{
    Console.WriteLine(masyvas[i]);
}

masyvas[2] = masyvas[2] * masyvas[2];

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(masyvas[2]);

string[] sakinys = new string[5];

for (int i = 0; i < sakinys.Length; i++)
{
    sakinys[i] = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < sakinys.Length; i++)
{
    Console.WriteLine(sakinys[i]);
}










