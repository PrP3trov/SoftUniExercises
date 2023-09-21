using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kozunaci = int.Parse(Console.ReadLine());
            int ocenka = 0, sumtochki = 0 , MaxTochkiPekar = 0;
            string pekarPecheli = " ";
            for (int i = 0; i < kozunaci; i++)
            {
                string pekar = Console.ReadLine();
                while (true)
                {
                    string comamnd = Console.ReadLine();
                    if (comamnd == "Stop")
                    {
                        Console.WriteLine($"{pekar} has {sumtochki} points.");
                        if (sumtochki > MaxTochkiPekar)
                        {
                            Console.WriteLine($"{pekar} is the new number 1!");
                            pekarPecheli = pekar;
                            MaxTochkiPekar = sumtochki;
                        }                                      
                        break;
                    }
                    ocenka = int.Parse(comamnd);
                    sumtochki += ocenka;
                }
                sumtochki = 0;
            }
            Console.WriteLine($"{pekarPecheli} won competition with {MaxTochkiPekar} points!");
        }
    }
}
