//Jokke Van Der Straeten
//19/08/2025
//Project vermenigvuldigen

//velden
int _vermenigvuldigd = 0;
int _getal1 = 0;
int _getal2 = 0;
//programma
// vraag getal 1 en sla dit op
Console.Write("Kies een eerste getal");
 _getal1 = int.Parse(Console.ReadLine());
// vraag getal 2 en sla dit op
Console.Write("Kies een tweede getal");
 _getal2 = int.Parse(Console.ReadLine());
//vermenigvuldig de getallen en sla dit op
 _vermenigvuldigd = (_getal1 * _getal2);

// toon de uitkomst
Console.WriteLine($"Het antwoord is {_vermenigvuldigd}");