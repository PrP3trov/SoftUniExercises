using System;
using System.Xml;

namespace Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            double statisti = double.Parse(Console.ReadLine());
            double cenaedinstatistObleklo = double.Parse(Console.ReadLine());
            double dekor = 0.10 * budged;
            double obleklo = statisti * cenaedinstatistObleklo;
            if (statisti > 150)
            {
                obleklo = obleklo  - obleklo* 0.10;
            }
            double sum = obleklo + dekor;
            if ( sum <= budged)
            {
                double ostava = budged - sum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {ostava:F2} leva left." );
            }
            else if (sum > budged)
            {
                double trqbva = sum - budged;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {trqbva:F2} leva more.");
            }
        }
    }
}
