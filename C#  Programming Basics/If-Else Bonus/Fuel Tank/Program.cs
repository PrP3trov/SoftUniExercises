using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoli = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double cenapodaruk = double.Parse(Console.ReadLine());
            double sum = magnoli * 3.25 + zumbuli * 4 + rozi * 3.5 + kaktusi * 8;
            double pechalba = sum - sum * 0.05;
            if(cenapodaruk > pechalba)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(cenapodaruk - pechalba)} leva.");
            }
            else
                Console.WriteLine($"She is left with {Math.Floor(pechalba-cenapodaruk)} leva.");
        }
    }
}