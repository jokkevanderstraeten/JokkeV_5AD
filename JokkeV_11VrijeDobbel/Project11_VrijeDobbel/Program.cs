using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11_VrijeDobbel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jokke Van Der Straeten
            //16/10/2025
            //Project 11 Vrijedobbelsteen

            //velden
            Boolean _herhalen = true;
            byte _keuze = 0;
            int _maxWaarde = 0;
            int _minWaarde = 0;
            int _getal = 0;
            Random random = new Random();
            //programma

            //stap 1: intro
            Console.WriteLine("Welkom bij het programma.");
            Console.WriteLine("Tik op een toets om verder te gaan...");
            Console.ReadKey();
            Console.Clear();

            do
            {
                try
                {
                    //Keuzemenu tonen en keuze  Opslaan
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("1. Gooien met de dobbelsteen \n2. Afsluiten");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //als gebruiker kiest voor 1 vraag een max en min waarden + geef getal
                    if (_keuze == 1)
                    {
                        //min waarde vragen + opslaan
                        Console.WriteLine("Geef een Minimum waarde in");
                        _minWaarde = int.Parse(Console.ReadLine());
                        Console.Clear();
                        //max waarde + opslaan
                        Console.WriteLine("Geef een Maximum waarde in");
                        _maxWaarde = int.Parse(Console.ReadLine());
                        Console.Clear();
                        //getal bepalen en tonen
                        _getal = random.Next(_minWaarde, _maxWaarde + 1);
                        Console.WriteLine($"De dobbelsteen geeft {_getal}");
                        _herhalen = false;

                    }
                    //als gebruiker kiest voor 2 sluit het programma af en toon de tekst
                    else if (_keuze == 2)
                    {
                        Console.WriteLine("Oke, Dag");
                        _herhalen = false;
                        return;
                    }
                    //Foutmelding
                    else
                    { Console.WriteLine("Er ging iets mis, geef een juiste keuze in"); }
                }
                catch
                {//Scherm leegmaken
                    Console.Clear();
                    //foutmelding
                    Console.WriteLine("Je gaf een verkeerd keuze in.");
                }
            }
            while (_herhalen);
        

            }
        }
    }


