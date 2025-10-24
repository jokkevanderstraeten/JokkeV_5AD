using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokkeV_10Dobbel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jokke Van Der Straeten
            //14/10/2025
            //Project10 Dobbel
            
            //velden
            Byte _Keuze = 0;
            Byte _getal = 0;
            Random _rdm = new Random();
            
            //programma 
            
            //stap 1: intro
            Console.WriteLine("Hallo, welkom bij mijn dobbelsteen\ndruk om verder te gaan");
            Console.ReadKey();
            Console.Clear();
            do
            {
                try
                {   //stap 2: keuzemenu tonen en keuze opslaan
                    Console.WriteLine("Wat wil je kiezen?");
                    Console.WriteLine("1. Dobbelsteen Gooien \n2. Afsluiten");
                    _Keuze = Byte.Parse(Console.ReadLine());
                    //Stap 3: als (gooi)
                    if (_Keuze == 1)
                    {
                        //bepaal getal van 1 - 6 en toon deze
                        _getal = Convert.ToByte(_rdm.Next(0, 7));
                        Console.WriteLine($"De dobbelsteen stopt op {_getal}");
                 
                    }
                    //Stap 4: als (afsluiten)
                    else if (_Keuze == 2)
                    {
                        //sluit af en toon bericht
                        Console.WriteLine("Afgesloten");
                        return;
                        
                    }
                    //Stap 5: als er iets anders is geef foutmelding
                    else { Console.WriteLine("Er ging iets mis kies 1 of 2"); }
                } 
                catch { //scherm wissen
                        Console.Clear();
                        //foutmelding
                        Console.WriteLine("Er ging iets mis kies 1 of 2");
                        
                }

            }
            while (_Keuze != 2);
            
           
        }
    }
}
