using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int sezoni = int.Parse(Console.ReadLine());
            int epizodi = int.Parse(Console.ReadLine());
            double epizodBezReklama = double.Parse(Console.ReadLine());
            double reklama = 0.20 * epizodBezReklama;
            double epizodreklama = epizodBezReklama + reklama;
            int dopulnitelnovreme = sezoni * 10;
            double sum = epizodreklama * epizodi * sezoni + dopulnitelnovreme;
            Console.WriteLine($"Total time needed to watch the {serial} series is {Math.Floor(sum)} minutes.");

        }
    }
}
