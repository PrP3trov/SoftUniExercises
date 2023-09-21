using System;
using System.ComponentModel.Design;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ekskurziq = double.Parse(Console.ReadLine());
            double puzeli = double.Parse(Console.ReadLine());
            double kukli = double.Parse(Console.ReadLine());
            double mecheta = double.Parse(Console.ReadLine());
            double minion = double.Parse(Console.ReadLine());
            double kamionche = double.Parse(Console.ReadLine());
            double sum = puzeli * 2.60 + kukli * 3 + mecheta * 4.10 + minion * 8.20 + kamionche * 2;
            double igrachki = puzeli + kukli + mecheta + minion + kamionche;
            if (igrachki  >= 50)
            {
                sum = sum - sum * 0.25;
            }
            double pechalba = sum - sum * 0.10;
            if ( pechalba >= ekskurziq)
            {
                double ostavashtipari = pechalba - ekskurziq;
                Console.WriteLine($"Yes! {ostavashtipari:F2} lv left.");
            }
            else if (pechalba < ekskurziq)
            {
                double trqt = ekskurziq - pechalba;
                Console.WriteLine($"Not enough money! {trqt:F2} lv needed.");
            }

        } 
        
    }
}
