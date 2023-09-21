using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int igrachki = 0;
            int parird = 0;
            int sum = 0;
            int godiniLili = int.Parse(Console.ReadLine());
            double peralnq = double.Parse(Console.ReadLine());
            int cenaIgrachka = int.Parse(Console.ReadLine());
            for (int i = 1; i <= godiniLili; i++)
            {
                if (i % 2 != 0)
                {
                    igrachki++;
                }
                else if (i % 2 == 0)
                {
                    parird++;
                    sum = sum + parird * 10; 
                }
            }
            int sumIgrachki = igrachki * cenaIgrachka;
            int spesteni = (sum + sumIgrachki) - parird;
            if (spesteni >= peralnq)
            {
                Console.WriteLine($"Yes! {(spesteni - peralnq):F2}");
            }
            else Console.WriteLine($"No! {(peralnq - spesteni):F2}");
        }
    }
}
