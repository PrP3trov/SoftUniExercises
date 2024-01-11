using System;
using System.Threading;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int ribari = int.Parse(Console.ReadLine());
            int cenaKorab = 0;
            switch (season)
            {
                case "Spring":
                    {
                        cenaKorab = 3000;
                        if (ribari <= 6)
                        {
                            double cena = cenaKorab - cenaKorab * 0.10;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                        }
                        else if (ribari >= 7 && ribari <= 11)
                        {
                            double cena = cenaKorab - cenaKorab * 0.15;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }

                        }
                        else
                        {
                            double cena = cenaKorab - cenaKorab * 0.25;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                        }
                    }
                    break;
                case "Summer":
                    {
                        cenaKorab = 4200;
                        if (ribari <= 6)
                        {
                            double cena = cenaKorab - cenaKorab * 0.10;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                        }
                        else if (ribari >= 7 && ribari <= 11)
                        {
                            double cena = cenaKorab - cenaKorab * 0.15;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }

                        }
                        else
                        {
                            double cena = cenaKorab - cenaKorab * 0.25;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                        }
                    }
                    break;
                case "Autumn":
                    {
                        cenaKorab = 4200;
                        if (ribari <= 6)
                        {
                            double cena = cenaKorab - cenaKorab * 0.10;
                            if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                            else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                        }
                        else if (ribari >= 7 && ribari <= 11)
                        {
                            double cena = cenaKorab - cenaKorab * 0.15;
                            if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                            else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                        }
                        else
                        {
                            double cena = cenaKorab - cenaKorab * 0.25;
                            if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                            else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                        }
            
                    }
                    break;
                case "Winter":
                    {
                        cenaKorab = 2600;
                        if (ribari <= 6)
                        {
                            double cena = cenaKorab - cenaKorab * 0.10;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                        }
                        else if (ribari >= 7 && ribari <= 11)
                        {
                            double cena = cenaKorab - cenaKorab * 0.15;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else { Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); }
                            }

                        }
                        else
                        {
                            double cena = cenaKorab - cenaKorab * 0.25;
                            if (ribari % 2 == 0)
                            {
                                cena = cena - cena * 0.05;
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else  Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); 
                            }
                            else
                            {
                                if (budget > cena) { Console.WriteLine($"Yes! You have {(budget - cena):F2} leva left."); }
                                else  Console.WriteLine($"Not enough money! You need {(cena - budget):F2} leva."); 
                            }
                        }
                    }
                    break;
            }
        }   } 
}
