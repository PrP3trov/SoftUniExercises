using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int kghrana = int.Parse(Console.ReadLine());
            double kuchehrana = double.Parse(Console.ReadLine());
            double kotkahrana = double.Parse(Console.ReadLine());
            double kostenurkahrana = double.Parse(Console.ReadLine());
            double kuchetrq = dni * kuchehrana;
            double kotkatrq = dni * kotkahrana;
            double kostenurkatrq = kostenurkahrana   * dni / 1000;
            double sumhrana = kuchetrq + kotkatrq + kostenurkatrq;
            if ( sumhrana <= kghrana)
            {
                Console.WriteLine($"{Math.Floor(kghrana - sumhrana)} kilos of food left.");
            }
            else
                Console.WriteLine($"{Math.Ceiling(sumhrana - kghrana)} more kilos of food are needed.");
        }
    }
}