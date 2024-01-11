using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiPileshkoMenu = int.Parse(Console.ReadLine());
            int broiMenuSRiba = int.Parse(Console.ReadLine());
            int broiVeganMenu = int.Parse(Console.ReadLine());
            double cenaPileshkiMenuta = broiPileshkoMenu * 10.35;
            double cenaMenuSRiba = broiMenuSRiba * 12.40;
            double cenaVeganMenu = broiVeganMenu * 8.15;
            double obshtaSumaMenuta = cenaPileshkiMenuta + cenaMenuSRiba + cenaVeganMenu;
            double cenaDesert = obshtaSumaMenuta * 0.2;
            double cenaDostavka = 2.50;
            double obshtaCenaPoruchka = obshtaSumaMenuta + cenaDesert + cenaDostavka;
            Console.WriteLine(obshtaCenaPoruchka);

        }
    }
}