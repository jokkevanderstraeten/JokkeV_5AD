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
            try
            {
                //intro
                Console.WriteLine("Welkom bij het programma.");
                Console.WriteLine("Tik op een toets om verder te gaan...");
                Console.ReadKey();
                Console.Clear();

                do
                {
                    //Vragen wat hij wilt doen + Opslaan
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("1. Gooien met de dobbelsteen \n2. Afsluiten");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //als gebruiker kiest voor 1 vraag een max en min waarden + geef getal
                    if (_keuze == 1)
                    {
                        //min waarde
                        Console.WriteLine("Geef een Minimum waarde in");
                        _minWaarde = int.Parse(Console.ReadLine());
                        Console.Clear();
                        //max waarde
                        Console.WriteLine("Geef een Maximum waarde in");
                        _maxWaarde = int.Parse(Console.ReadLine());
                        Console.Clear();
                        //getal geven
                        _getal = random.Next(_minWaarde, _maxWaarde + 1);
                        Console.WriteLine($"De dobbelsteen geeft {_getal}");
                        _herhalen = false;

                    }
                    //als gebruiker kiest voor 2 sluit dan het programma af
                    else if (_keuze == 2)
                    {
                        Console.WriteLine("Oke, Dag");
                        _herhalen = false;
                        return;
                    }
                    //foutmelding bij if statements
                    else
                    { Console.WriteLine("Er ging iets mis, geef een juiste keuze in"); }
                    if (_getal == 67 )
                    { Console.WriteLine("YANTOOOO 67777777");
                        _herhalen = false;
                    }                
                

                }
                while (_herhalen);
            }
            //foutmelding
            catch { Console.WriteLine("Je gaf een verkeerd keuze in."); }
        }   
    }   
}