using System;

namespace _02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cena = double.Parse(Console.ReadLine());
            int poslaniq = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kluchodurjatel = int.Parse(Console.ReadLine());
            int karikaturi = int.Parse(Console.ReadLine());
            int kusmeti = int.Parse(Console.ReadLine());
            double pechalba = 0;
            double sum = poslaniq * 0.60 + rozi * 7.20 + kluchodurjatel * 3.60 + karikaturi * 18.20 + kusmeti * 22;
            int artikuli = poslaniq + rozi + kluchodurjatel + karikaturi + kusmeti;
            if(artikuli >= 25)
            {
                sum = sum - sum * 0.35;
            }
            pechalba = sum - sum * 0.10;
            if (pechalba >= cena)
            {
                Console.WriteLine($"Yes! {pechalba - cena:F2} lv left.");
            }
            else Console.WriteLine($"Not enough money! {cena - pechalba:F2} lv needed.");
        }
    }
}
