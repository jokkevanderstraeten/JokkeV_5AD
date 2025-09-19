
// Jokke Van Der straeten
// 19/09/2025
// Project Rekensom

// velden
int _getal1 = 0;
int _getal2 = 0;
int _som = 0;
int _vermeerderd = 0;
int _vermenigvuldigd = 0;
double _gedeeld = 0;

const int _vermeerdering = 5;
const int _deling = 2;
const int _vermenigvuldiging = 10;
// programma


// Vraag getal 1 en sla het op
Console.WriteLine("Geef jou eerste getal");

_getal1 = int.Parse(Console.ReadLine());

// Vraag getal 2 en sla het op
Console.WriteLine("Geef jou tweede getal");
_getal2 = int.Parse(Console.ReadLine());

// bereken de som en sla deze op
_som = (_getal1 + _getal2);

// vermeerder de som met 5 en sla op
_vermeerderd = (_som + _vermeerdering);

// vermenigvuldiging de som met 10 en sla op
_vermenigvuldigd = (_vermeerderd * _vermenigvuldiging);

// Deel het getal door 2 en sla op
_gedeeld = (_vermenigvuldigd / _deling);
// scherm leegmaken
Console.Clear();
// vul de tekst in en toon deze aan de gebruiker
Console.WriteLine($"Uw gaf getallen {_getal1.ToString()} en {_getal2.ToString()} in." +
    $"\r\nDe som hiervan is {_som.ToString()}\r\nDit getal werd vermeerderd met 5. Dit gaf als uitkomst {_vermeerderd.ToString()}" +
    $"\r\nDaarna werd er vermenigvuldig met 10. Dit gaf als uitkomst {_vermenigvuldigd.ToString()}" +
    $"\r\nAls laatste werd er gedeeld door 2. " +
    $"\r\nHet uiteindelijke resultaat is {_gedeeld.ToString()}\r\n");

//afsluiten van programma
Console.WriteLine("Druk op enter om af te sluiten");
Console.ReadKey();
return;
