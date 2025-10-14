using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokkeV_09WIllekeurigGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jokke Van Der Straeten
            //10/10/2025
            //Project09_WillekeurigGetal

            //velden
            Random _rdm = new Random();
            

            int _Getal1 = 0;
            int _Getal2 = 0;
            //Programma
            _Getal1 = _rdm.Next(11);
            _Getal2 = _rdm.Next(11);

            Console.WriteLine($"{_Getal1} is je eerste getal,{_Getal2} is je tweede getal");


        }
    }
}
