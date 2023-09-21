using System;

namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            string pomeshtenie = Console.ReadLine();
            string ocenka = Console.ReadLine();
            double cenaNoshtuvka = 0;
            int noshtuvki = dni - 1;

            switch (pomeshtenie)
            {
                case "room for one person":
                    {
                        cenaNoshtuvka = 18;
                        double cena = noshtuvki * cenaNoshtuvka;
                        if (ocenka == "positive") { Console.WriteLine($"{(cena + cena * 0.25):F2}");}
                        else { Console.WriteLine($"{(cena - cena * 0.10):F2}"); }

                    }
                    break;
                case "apartment":
                    {
                        cenaNoshtuvka = 25;
                        double cena = noshtuvki * cenaNoshtuvka;
                        if (noshtuvki < 10)
                        {
                            cena = cena -  cena* 0.30;
                            if (ocenka == "positive") { Console.WriteLine($"{(cena + cena * 0.25):F2}"); }
                            else { Console.WriteLine($"{(cena + cena * 0.10):F2}"); }
                        }
                        else if (noshtuvki >=10 && noshtuvki <= 15)
                        {
                            cena = cena - cena * 0.35;
                            if (ocenka == "positive") { Console.WriteLine($"{(cena + cena * 0.25):F2}"); }
                            else { Console.WriteLine($"{(cena - cena * 0.10):F2}"); }
                        }
                        else
                        {
                            cena = cena - cena * 0.5;
                            if (ocenka == "positive") { Console.WriteLine($"{(cena + cena * 0.25):F2}"); }
                            else { Console.WriteLine($"{(cena - cena * 0.10):F2}"); }
                        }
                    }
                    break;
                case "president apartment":
                    {
                        cenaNoshtuvka = 35;
                        double cena = noshtuvki * cenaNoshtuvka;
                        if (noshtuvki < 10)
                        {
                            cena = cena - cena * 0.10;
                            if (ocenka == "positive") { Console.WriteLine($"{(cena + cena * 0.25):F2}"); }
                            else { Console.WriteLine($"{(cena - cena * 0.10):F2}"); }
                        }
                        else if (noshtuvki >= 10 && noshtuvki <= 15)
                        {
                            cena = cena - cena * 0.15;
                            if (ocenka == "positive") { Console.WriteLine($"{(cena + cena * 0.25):F2}"); }
                            else { Console.WriteLine($"{(cena - cena * 0.10):F2}"); }
                        }
                        else
                        {
                            cena = cena - cena * 0.20;
                            if (ocenka == "positive") { Console.WriteLine($"{(cena + cena * 0.25):F2}");}
                            else{ Console.WriteLine($"{(cena - cena * 0.10):F2}"); }
                        }
                    }
                    break;

            }


        }
    }
}
