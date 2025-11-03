using System;

namespace JokkeV_12MeerDobbel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jokke Van der Straeten
            // 24/10/2025
            // Project 12: MeerDobbel

            // velden
            int _totaal = 0;
            int _ogen = 0;
            int _worp = 0;
            byte _keuze = 0;
            Random _dobbel = new Random();
            

            // programma
            
            Console.WriteLine("Welkom bij het programma!");
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.ReadKey();
            Console.Clear();

            do
            {
               
                try
                {
                    // Stap 1: nagaan of het aantal ogen al is ingesteld
                    if (_ogen == 0)
                    {
                        Console.Write("Met hoeveel ogen wil je gooien? ");
                        _ogen = int.Parse(Console.ReadLine());
                        
                    }
                    else
                    {
                        // Stap 2: keuzemenu
                        Console.WriteLine("\nMaak een keuze:");
                        Console.WriteLine("1. Gooien");
                        Console.WriteLine("2. Resetten");
                        Console.WriteLine("3. afsluiten");
                        _keuze = byte.Parse(Console.ReadLine());
                        Console.Clear();

                        // Stap 3: uitvoer
                        //als gooien
                        if (_keuze == 1)
                        {
                            _worp = _dobbel.Next(0,_ogen + 1);
                             
                            Console.WriteLine($"Je gooide {_worp.ToString()} met een max van {_ogen.ToString()}");
                           _totaal += _worp;
                            Console.WriteLine($"Totaal tot nu toe: {_totaal.ToString()}");
                            //keuzemenu opnieuw
                            Console.WriteLine("\nMaak een keuze:");
                            Console.WriteLine("1. opnieuw  Gooien");
                            Console.WriteLine("2. Resetten");
                            Console.WriteLine("3. afsluiten");
                            
                            _keuze = byte.Parse(Console.ReadLine());
                            Console.Clear();
                            
                        }
                        //als reset
                        else if (_keuze == 2)
                        {
                            _ogen = 0;
                            _totaal = 0;
                            Console.WriteLine("Ogen en totaal zijn gereset.");
                        }
                        //als afsluiten
                        else if (_keuze == 3)
                        {   
                            Console.WriteLine("Daag!");
                            return;
                        }
                        //foutmelding
                        else
                        {
                            Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Er ging iets fout, probeer opnieuw.");
                }

            } while (_keuze != 3  );
        }
    }
}
