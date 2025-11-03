using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raadspelletje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jokke Van Der Straeten
            //3/11/2025
            //ProjectRaadspelletje



            //velden
            Byte _randomgetal = 0;
            Random random = new Random();
            Byte _Gekozengetal = 0;
            //programma

            //intro
            Console.WriteLine("Welkom bij het raadspelletje");
            Console.WriteLine("Druk op een knop om verder te gaan...");
            Console.ReadKey();
            //scherm leegmaken
            try
            {

                Console.Clear();
                //random getal maken
                _randomgetal = Convert.ToByte(random.Next(0, 101));
                for (int i = 0; i < 5; i++)
                {
                    //Vragen van het getal + opslaan
                    Console.WriteLine("Welk getaal raad je?");
                    _Gekozengetal = Byte.Parse(Console.ReadLine());
                    //als getal hoger is
                    if (_Gekozengetal > _randomgetal)
                    { Console.WriteLine("Je gekozen getal was te hoog"); }
                    //als getal lager is 
                    else if (_Gekozengetal < _randomgetal)
                    { Console.WriteLine("Je gekozen getal was te laag"); }
                    //als getal juist is
                    else if (_Gekozengetal == _randomgetal)
                    {
                        Console.WriteLine("Goed Geraden");
                        return;
                    }
                    //als keuzes op zijn
                    else if (i >= 5)
                    {
                        Console.WriteLine("Je Kansen zijn op");
                    }
                    else { Console.WriteLine("Geef een juiste keuze in"); }
                    //als keuzes op zijn
                    
                }
                
                Console.WriteLine("Je hebt geen kansen meer");
            }
            catch { Console.WriteLine("Geef een juist getal in"); }
        }   
    }
}
