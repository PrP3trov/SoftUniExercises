using System;
using System.Diagnostics.CodeAnalysis;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = Console.ReadLine();
            double tochkiAkademiq = double.Parse(Console.ReadLine());
            int ocenqvashti = int.Parse(Console.ReadLine());
            for (int i = 0; i < ocenqvashti; i++)
            {
                string imeocenqva = Console.ReadLine();
                double davatochki = double.Parse(Console.ReadLine());
                tochkiAkademiq = tochkiAkademiq + ((imeocenqva.Length * davatochki) / 2); 
                if (tochkiAkademiq >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {ime} got a nominee for leading role with {tochkiAkademiq:F1}!");
                    break;
                }
            }
            if (tochkiAkademiq < 1250.5)
            {
                Console.WriteLine($"Sorry, {ime} you need {(1250.5 - tochkiAkademiq):F1} more!");
            }
            
        }
    }
}
