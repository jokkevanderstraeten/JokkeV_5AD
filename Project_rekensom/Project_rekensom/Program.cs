
//Jokke Van Der straeten
//19/09/2025
//Project Rekensom

//velden
byte _getal1 = 0;
byte _getal2 = 0;
byte _som = 0;
byte _vermeerdering = 0;
int _vermenigvuldiging = 0;
byte _delen = 0;
byte _uitkomst = 0;
//programma


//Vraag getal 1 en sla het op
Console.WriteLine("Geef jou eerste getal");
_getal1 = byte.Parse(Console.ReadLine());

//Vraag getal 2 en sla het op
Console.WriteLine("Geef jou tweede getal");
_getal2 = byte.Parse(Console.ReadLine());

//bereken de som en sla deze op
_som = Convert.ToByte(_getal1 + _getal2);

//vermeerder de som met 5 en sla op
_vermeerdering = Convert.ToByte(_som + 5);

//vermenigvuldiging de som met 10 en sla op
_vermenigvuldiging = Convert.ToByte(_vermeerdering * 10);

//Deel het getal door 2 en sla op
_delen = Convert.ToByte(_vermenigvuldiging / 2);

//
_uitkomst = _delen;
// vul de tekst in en toon deze aan de gebruiker