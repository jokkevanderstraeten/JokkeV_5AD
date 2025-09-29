

//Jokke Van Der Straeten
//29/09//2025
//Toets02_OverJezelf

//Velden
string _Voornaam;
string _Achternaam;
string _Hobby;
string _Adres;

//Programma

//Stap 1: Vraag de gebruiker zijn voornaam + opslaan
Console.WriteLine("Hey, Wat is je voornaam?");
_Voornaam = (Console.ReadLine());

//Stap 2: Vraag de gebruiker zijn achternaam + opslaan
Console.WriteLine("en wat is je achternaam?");
_Achternaam = (Console.ReadLine());

//Stap 3:Vraag de gebruiker zijn  adres + opslaan
Console.WriteLine("en wat is je adres?");
_Adres = (Console.ReadLine());

//Stap 4:Vraag de gebruiker zijn favoriete hobby + opslaan
Console.WriteLine("Wat is je favoriete hobby?");
_Hobby = (Console.ReadLine());

//stap 5: maak het scherm leeg
Console.Clear();

//Stap 6: zeg tegen de gebruiker dat je alles zult samenvatten
Console.WriteLine("Ik zal alles even kort samenvatten voor je");

//Stap 7: Wacht tot de gebruiker een toets intikt
Console.WriteLine("Druk op een toets om verder te gaan");
Console.ReadKey();

//Stap 8: maak het scherm leeg
Console.Clear();
//Stap 9: toon de tekst met de door de gebruiker ingevulde gegevens
Console.WriteLine($"Dag {_Voornaam} {_Achternaam}");
Console.WriteLine($"Je adres is {_Adres}");
Console.WriteLine($"Je favoriete hobby is {_Hobby}");