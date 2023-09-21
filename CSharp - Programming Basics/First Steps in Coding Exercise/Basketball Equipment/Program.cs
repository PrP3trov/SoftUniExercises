using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int godishnaTaksaTren = int.Parse(Console.ReadLine());
            double cenaBasketKec = godishnaTaksaTren - godishnaTaksaTren *  0.40;
            double cenaBasketEkip = cenaBasketKec - cenaBasketKec * 0.20;
            double cenaBasketTopka = cenaBasketEkip / 4;
            double cenaBasketAksesoari =  cenaBasketTopka / 5;
            double obshtoEkipirovka = godishnaTaksaTren + cenaBasketKec + cenaBasketEkip + cenaBasketTopka + cenaBasketAksesoari;
            Console.WriteLine(obshtoEkipirovka);
        }
    }
}