int[] _best = new int[5];
int _keuzeInt = 0;
for (int i = 0; i < _best.Length; i++)
{
    Console.WriteLine($"Geef getal {i} in:");
    _best[i] = int.Parse(Console.ReadLine());
}

Console.Write("Welk getal wil je zien?");
_keuzeInt = int.Parse(Console.ReadLine()); 
for (int i = 0; i < _keuzeInt; i++)
{
    Console.Write(_best[i =_keuzeInt] + " ");
}
