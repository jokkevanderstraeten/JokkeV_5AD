//jokke van der straeten
//26/09/25
// oefening 04 project_Registreren


//velden

string _wachtwoordinstellen;
string _loginnaaminstellen;
//programma
//Stap 1: Intro
Console.WriteLine("Hallo, registreer je op onze website");
Console.WriteLine("Druk op een toets om verder te gaan");
Console.ReadKey();
Console.Clear();
//naam vragen + opslaan
Console.WriteLine("Wat wil je gebruiken als Loginnaam?");
_loginnaaminstellen = (Console.ReadLine());
//wachtwoord vragen + opslaan
Console.WriteLine("Wat wil je gebruiken als wachtwoord?");
_wachtwoordinstellen = (Console.ReadLine());