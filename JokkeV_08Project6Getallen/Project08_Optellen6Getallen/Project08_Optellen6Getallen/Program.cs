//Jokke Van Der Straeten
//09/10/2025
//Project Optellen 6 getallen



//velden
 int[] _getallen = new int[6];
int i = 0;

Boolean _herhalen = true;
//programma
Console.WriteLine("Welkom bij mijn programma:");
Console.WriteLine("Druk op een toets om verder te gaan");
Console.ReadKey();
do
{
    try
    {
        Console.WriteLine("Geef 6 getallen in");
        for (i = 0; i < _getallen.Length; i++)
        {
            Console.WriteLine($"Geef getal {i}");
            _getallen[i] = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        int _som = _getallen[0] + _getallen[1] + _getallen[2] + _getallen[3] + _getallen[4] + _getallen[5];
        Console.ReadKey();
        _herhalen = false;
    }


    catch { Console.WriteLine("geef een juist getal in"); }
            
}       

while (_herhalen);
