using System;
using System.Transactions;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int boriPaketiHimikalki = int.Parse(Console.ReadLine());
            int broiPaketiMarkeri = int.Parse(Console.ReadLine());
            int litriPreparat = int.Parse(Console.ReadLine());
            double procentNamalenie = double.Parse(Console.ReadLine());
            double cenaHimikalki = boriPaketiHimikalki * 5.80;
            double cenaMarkeri = broiPaketiMarkeri * 7.20;
            double cenaPreparat = litriPreparat * 1.20;
            double cenaVsichkiMateriali = cenaHimikalki + cenaMarkeri + cenaPreparat;
            double namalenie = procentNamalenie / 100;
            double cenaSNamalenie = cenaVsichkiMateriali - (cenaVsichkiMateriali * namalenie);
            Console.WriteLine(cenaSNamalenie);

        }
    }
}
