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
            int totaal = 0;
            int ogen = 0;
            byte keuze = 0;
            Random dobbel = new Random();
            

            // programma
            
            Console.WriteLine("Welkom bij het programma MeerDob!");
            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.ReadKey();
            Console.Clear();

            do
            {
                try
                {
                    // Stap 1: nagaan of het aantal ogen al is ingesteld
                    if (ogen == 0)
                    {
                        Console.Write("Met hoeveel ogen wil je gooien? ");
                        ogen = int.Parse(Console.ReadLine());
                        
                    }
                    else
                    {
                        // Stap 2: keuzemenu
                        Console.WriteLine("\nMaak een keuze:");
                        Console.WriteLine("1. Gooien");
                        Console.WriteLine("2. Resetten");
                        Console.WriteLine("3. Afsluiten");
                        keuze = byte.Parse(Console.ReadLine());
                        Console.Clear();

                        // Stap 3: uitvoer
                        //als gooien
                        if (keuze == 1)
                        {
                            int worp = dobbel.Next(1, ogen + 1);
                            Console.WriteLine($"Je gooide {worp} met een max van {ogen}");
                           totaal = worp + totaal;
                            Console.WriteLine($"Totaal tot nu toe: {totaal}");
                        }
                        //als reset
                        else if (keuze == 2)
                        {
                            ogen = 0;
                            totaal = 0;
                            Console.WriteLine("Ogen en totaal zijn gereset.");
                        }
                        //als afsluiten
                        else if (keuze == 3)
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

            } while (keuze != 3);
        }
    }
}
