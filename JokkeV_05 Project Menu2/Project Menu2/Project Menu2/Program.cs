//Jokke Van Der Straeten
//3/10/2025
//Project06 Menu2

//Velden

Boolean _herhalen = true;
Byte _keuze;
int _getal1 = 0;
int _getal2 = 0;
int _UITKOMSTVER = 0;
int _UITKOMSTMIN = 0;
int _UITKOMSTPLUS = 0;
//programma

// Intro
Console.WriteLine("Welkom bij ons rekenprogramma");
Console.ReadKey
//scherm leegmaken
Console.Clear();
do
{
    try
    {
        //vraag getal1 + opslaan
        Console.WriteLine("Welk getal wil je gebruiken als eerste getal?");
        _getal1 = int.Parse(Console.ReadLine());
        //scherm leegmaken
        Console.Clear();

        //vraag getal2 + opslaan
        Console.WriteLine("Welk getal wil je gebruiken als tweede getal?");
        _getal2 = int.Parse(Console.ReadLine());
        //scherm leegmaken
        Console.Clear();

        //Vraag of hij wilt  Vermenigvuldigen, optellen of verminderen of asluiten + sla op
        Console.WriteLine("Kies uit deze keuzes");
        Console.WriteLine("1. Vermenigvuldigen\n2. optellen\n3. verminderen\n4. afsluiten");
        _keuze = Byte.Parse(Console.ReadLine());
        //scherm leegmaken
        Console.Clear();
        
        if (_keuze == 1)
        {
            // als hij kiest voor vermenigvuldigen doe dan getal1 * getal2
            _UITKOMSTVER = _getal1 * _getal2;
            Console.WriteLine($"je uitkomst is {_UITKOMSTVER}");
            _herhalen = false;
        }

        else if (_keuze == 2)
        {
            //Als hij kiest voor optellen doe dan Getal1 +getal2
            _UITKOMSTPLUS = _getal1 + _getal2;
            Console.WriteLine($"je uitkomst is {_UITKOMSTPLUS}");

            _herhalen = false;
        }
        else if (_keuze == 3)
        {
            //Als hij kiest voor verminderen doe dan Getal1 - getal2
            _UITKOMSTMIN = _getal1 - _getal2;
            Console.WriteLine($"je uitkomst is {_UITKOMSTMIN}");

            _herhalen = false;
        }
        else if (_keuze == 4)
        {
            //afsluiten
            Console.WriteLine("daag");
            _herhalen = false;
            return;
        }
        else
        {
            //foutmelding
            Console.WriteLine("Er ging iets mis, geef een juist getal in");
        }
    }
    catch
    {
        //foutmelding
        Console.WriteLine("Er ging iets mis, geef een juist getal in");
    }


}


while (_herhalen);
