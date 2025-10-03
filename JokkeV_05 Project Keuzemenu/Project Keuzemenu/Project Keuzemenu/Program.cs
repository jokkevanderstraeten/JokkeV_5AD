//Jokke Van Der Straeten
//2/10/2025
//project Keuzemenu


//velden
using System.Linq.Expressions;

Boolean _herhalen = true;
byte _keuze = 0;

//programma
do
{
    //scherm leegmaken
    Console.Clear();
    //toon men
    Console.WriteLine("Maak een keuze uit het menu.");
    Console.WriteLine("\n 1. zeg hallo \n2. afsluiten");
    Console.WriteLine("geef uw keuze in:");
    Console.ReadLine();

    //scherm leegmaken
    Console.Clear;
    try
    {
        // vang invoer op en convert naar byte 
        _keuze = Convert.ToByte(Console.ReadLine());

        if (_keuze == 1)
        {
            //Zeg hallo
            Console.WriteLine("Hallo Gebruiker");
            Console.WriteLine("\nDruk op een willekeurige toets om terug te gaan");
        }

        else if (_keuze == 2)
        {
            //stoppen van herhaling
            _herhalen = false;
        }

        else
        {
            //foutmelding bij ongeldige keuze
            Console.WriteLine("ongeldige keuze, probeer opnieuw.");
            Console.WriteLine("\nDruk op een willekeurige toets om terug te gaan");
        }
            catch
    {

            }
    }
      
}
       
 