//Jokke Van Der Straeten
//09/10/2025
//Project Optellen 6 getallen



//velden
int[] _getallen = new int[6];
int i = 0;
Boolean _herhalen = true;
//programma
//intro
Console.WriteLine("Welkom bij mijn programma:");
Console.WriteLine("Druk op een toets om verder te gaan");
Console.ReadKey();
do
{
    try
    {
        //vraag 6 getallen en sla deze op
        Console.WriteLine("Geef 6 getallen in");
        for (i = 0; i < _getallen.Length; i++)
        {
            //toon welk getal hij ingeeft
            Console.WriteLine($"Geef getal {i}");
            _getallen[i] = int.Parse(Console.ReadLine());
        }
        //scherm leegmaken
        Console.Clear();
      // Bereken de som 
        int _som = _getallen[0] + _getallen[1] + _getallen[2] + _getallen[3] + _getallen[4] + _getallen[5];
        // toon de som en wacht om af te sluiten
        Console.WriteLine($"De som is {_som}");
        Console.ReadKey();
        _herhalen = false;

    }

    //foutmelding
    catch { Console.WriteLine("geef een juist getal in"); }
            
}       
while (_herhalen);
