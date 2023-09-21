using System;
using System.Net.Http.Headers;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double cena = 0;
            string destinaciq = "";
            string pochivka = "";
            if ( budget <= 100)
            {
                destinaciq = "Bulgaria";
                switch (season)
                {
                    case "summer": cena = budget * 0.3; pochivka = "Camp"; break;
                    case "winter": cena = budget * 0.7; pochivka = "Hotel"; break;
                }
            }
            else if ( budget <= 1000) 
            {
                destinaciq = "Balkans";
                switch (season)
                {
                    case "summer": cena = budget * 0.4; pochivka = "Camp"; break;
                    case "winter": cena = budget * 0.8;  pochivka = "Hotel"; break;
                }
            }
            else 
            {
                destinaciq = "Europe";
                cena = budget * 0.90;
                pochivka = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destinaciq}");
            Console.WriteLine($"{pochivka} - {cena:F2}");
        }
    }
}
