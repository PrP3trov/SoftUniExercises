using System;

namespace _01._Christmas_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rolki = int.Parse(Console.ReadLine());
            int plat = int.Parse(Console.ReadLine());
            double lepilo = double.Parse(Console.ReadLine());
            double namalenie = double.Parse(Console.ReadLine());
            double sum = rolki * 5.80 + plat * 7.20 + lepilo * 1.20;
            double sum1 = sum - (sum * namalenie/100);
            Console.WriteLine($"{sum1:F3}");
        }
    }
}
