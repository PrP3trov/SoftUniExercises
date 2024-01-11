using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0; double p2 = 0; double p3 = 0; double p4 = 0; double p5 = 0;
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double chislo = double.Parse(Console.ReadLine());
                if (chislo < 200)
                {
                    p1++;
                }
                else if (chislo >= 200 && chislo <= 399)
                {
                    p2++;
                }
                else if (chislo >= 400 && chislo <= 599)
                {
                    p3++;
                }
                else if (chislo >= 600 && chislo <= 799)
                {
                    p4++;
                }
                else p5++;
            }
            Console.WriteLine($"{((p1 / n) * 100):F2}%");
            Console.WriteLine($"{((p2 / n) * 100):F2}%");
            Console.WriteLine($"{((p3 / n) * 100):F2}%");
            Console.WriteLine($"{((p4 / n) * 100):F2}%");
            Console.WriteLine($"{((p5 / n) * 100):F2}%");
        }
    }
}
