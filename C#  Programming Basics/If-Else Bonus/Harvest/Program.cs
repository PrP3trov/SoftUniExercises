using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metraLoze = int.Parse(Console.ReadLine());
            double grozdeKVMetur = double.Parse(Console.ReadLine());
            int trqvino = int.Parse(Console.ReadLine());
            int rabotnici = int.Parse(Console.ReadLine());
            double obshtoGrozde = metraLoze * grozdeKVMetur; 
            double vino = 0.40 * obshtoGrozde / 2.5; 
            if (vino >= trqvino)
            {
                double ostava = vino - trqvino;
                double vinoNaChovek = ostava / rabotnici;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vino)} liters.");
                Console.WriteLine($"{Math.Ceiling(ostava)} liters left -> {Math.Ceiling(vinoNaChovek)} liters per person.");
            }
            else
            {
                double nestiga = trqvino - vino;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(nestiga)} liters wine needed.");

            }

        }
    }
}
