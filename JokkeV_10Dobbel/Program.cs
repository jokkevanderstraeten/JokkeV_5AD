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
            Boolean _herhalen = true;
            //intro
            Console.WriteLine("Hallo, welkom bij mijn dobbelsteen\ndruk om verder te gaan");
            Console.ReadKey();
            //Scherm leegmaken
            Console.Clear();
            //keuze vragen en opslaan
            do
            {
                try
                {   //keuze vragen en opslaan
                    Console.WriteLine("Wat wil je kiezen?");
                    Console.WriteLine("1. Dobbelsteen Gooien \n2. Afsluiten");
                    _Keuze = Byte.Parse(Console.ReadLine());
                    //scherm leegmaken
                    Console.Clear();
                    //als keuze = 1 geef een getal van 1-6
                    if (_Keuze == 1)
                    {
                        _getal = Convert.ToByte(_rdm.Next(0, 7));
                        Console.WriteLine($"De dobbelsteen stopt op {_getal}");
                        _herhalen = false;
                    }
                    //als keuze = 2 sluit af en toon bericht
                    else if (_Keuze == 2)
                    {
                        Console.WriteLine("Afgesloten");
                        _herhalen = false;
                        return;
                        
                    }
                    //als er iets anders is geef foutmelding
                    else { Console.WriteLine("Er ging iets mis kies 1 of 2"); }
                }
                //foutmelding
                catch { Console.WriteLine("Er ging iets mis kies 1 of 2"); }
            }
            //herhaal terwijl _herhalen true is
            while (_herhalen);
            
           
        }
    }
}
