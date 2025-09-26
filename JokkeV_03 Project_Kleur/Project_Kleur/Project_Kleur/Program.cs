//Jokke Van Der straeten
//26/09/25
//Oef 16 Project_Kleur

//Velden

byte _Keuze;

//Programma


//Stap 1: toon de keuzes (rood, groen of blauw)
Console.WriteLine("1. Rood\n2. Groen\n3. Blauw ");
Console.WriteLine("kies een kleur");

try
{ 
    //stap 2: vraag de gebruiker werlke kleur + sla op
    _Keuze = Byte.Parse(Console.ReadLine());

    //stap 3:Maak het scherm leeg    
    Console.Clear();
    //stap 4: als de keuze rood is toon rood
    if (_Keuze == 1)
    {
        Console.WriteLine($"je koos de volgende kleur: Rood");
    }

    //stap 4: als de keuze groen is toon  groen
    else if (_Keuze == 2)
    {
        Console.WriteLine($"je koos de volgende kleur: Groen");
    }


    //stap 4: als de keuze blauw is toon blauw    
    else if (_Keuze == 3)
    {
        Console.WriteLine($"je koos de volgende kleur: Blauw");
    }

    else
    {
        Console.WriteLine("geef 1,2 of 3 in");
    }
    }
catch
{
    Console.WriteLine("geef 1,2 of 3 in");
}