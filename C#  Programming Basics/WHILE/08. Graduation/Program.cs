using System;
using System.Dynamic;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = Console.ReadLine();
            int klas = 0;
            int skusan = 0;
            double ocenki = 0;
            double sum = 0;
            while (true)
            {
                double ocenka = double.Parse(Console.ReadLine());
                ocenki++;
                sum += ocenka;
                if (ocenka >= 4.00)
                {
                    klas++;
                }
                if(ocenka < 4.00)
                {
                    skusan++;
                }
                if (skusan > 1)
                {
                    Console.WriteLine($"{ime} has been excluded at {klas +1} grade");
                    break;
                }
                if (klas == 12)
                {
                    Console.WriteLine($"{ime} graduated. Average grade: {sum / ocenki :F2}");
                    break;
                }              
            }          
        }
    }
}
