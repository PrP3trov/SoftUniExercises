using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededNailon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int neededRazreditel = int.Parse(Console.ReadLine());
            int neededHours = int.Parse(Console.ReadLine());
            double sumNailon = (neededNailon + 2) * 1.50;
            double sumBoq = (neededPaint + neededPaint * 0.10) * 14.50;
            double sumRazreditel = neededRazreditel * 5.00;
            double sumTorbichka = 0.40;
            double obshtaSumaMateriali = sumNailon + sumBoq + sumRazreditel + sumTorbichka;
            double sumMaistor = (obshtaSumaMateriali * 30 / 100) * neededHours;
            double krainaSuma = obshtaSumaMateriali + sumMaistor;
            Console.WriteLine(krainaSuma);

        }
    }
}