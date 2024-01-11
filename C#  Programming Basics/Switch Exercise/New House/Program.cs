using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vidCvete = Console.ReadLine();
            int broiCvetq = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            switch (vidCvete)
            {
                case "Roses":
                    {
                        double cena = broiCvetq * 5; 
                        if (broiCvetq > 80) 
                        {
                            cena = cena - cena * 0.10; 
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");

                        }
                        else 
                        {
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else 
                            {
                                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");
                            }
                        }
                    }
                    break;
                case "Dahlias":
                    {
                        double cena = broiCvetq * 3.80; 
                        if (broiCvetq > 90) 
                        {
                            cena = cena - cena * 0.15;
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else 
                            {
                                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");
                            }
                        }
                        else 
                        {
                       
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else 
                            {
                                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");
                            }
                        }
                    }
                    break;
                case "Tulips":
                    {
                        double cena = broiCvetq * 2.80; 
                        if (broiCvetq > 80) 
                        {
                            cena = cena - cena * 0.15;
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else 
                            {
                                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");
                            }

                        }
                        else 
                        {
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else 
                            {
                                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");
                            }
                        }
                    }
                    break;
                case "Narcissus":
                    {
                        double cena = broiCvetq * 3;
                        if (broiCvetq < 120) 
                        {
                            cena = cena + cena * 0.15;
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else 
                            {
                                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");
                            }

                        }
                        else 
                        {
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else 
                            {
                                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left.");
                            }
                        }
                    }
                    break;
                case "Gladiolus":
                    {
                        double cena = broiCvetq * 2.50; 
                        if (broiCvetq < 80)
                        {
                            cena = cena + cena * 0.20;
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else  Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left."); 

                        }
                        else 
                        {
                            if (cena > budget)
                            {
                                Console.WriteLine($"Not enough money, you need {(cena - budget):F2} leva more.");
                            }
                            else   Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvete} and {(budget - cena):F2} leva left."); 
                        }
                    }
                    break;
            }
        }
    }
}
