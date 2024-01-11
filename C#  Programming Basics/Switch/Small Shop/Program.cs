using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // coffee water beer sweets peanuts
            string produkt = Console.ReadLine();
            string grad = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());
            switch(grad)
            {
                case "Sofia":
                    {
                        switch (produkt)
                        {
                            case "coffee":
                                Console.WriteLine(0.50 * kolichestvo);
                                break;
                            case "water":
                                Console.WriteLine(0.80 * kolichestvo);
                                break;
                            case "beer":
                                Console.WriteLine(1.20 * kolichestvo);
                                break;
                            case "sweets":
                                Console.WriteLine(1.45 * kolichestvo);
                                break;
                            case "peanuts":
                                Console.WriteLine(1.60 * kolichestvo);
                                break;
                        }
                    }
                    break;
                case "Plovdiv":
                    {
                        switch (produkt)
                        {
                            case "coffee":
                                Console.WriteLine(0.40 * kolichestvo);
                                break;
                            case "water":
                                Console.WriteLine(0.70 * kolichestvo);
                                break;
                            case "beer":
                                Console.WriteLine(1.15 * kolichestvo);
                                break;
                            case "sweets":
                                Console.WriteLine(1.30 * kolichestvo);
                                break;
                            case "peanuts":
                                Console.WriteLine(1.50 * kolichestvo);
                                break;
                        }
                    }
                    break;
                case "Varna":
                    {
                        switch (produkt)
                        {
                            case "coffee":
                                Console.WriteLine(0.45 * kolichestvo);
                                break;
                            case "water":
                                Console.WriteLine(0.70 * kolichestvo);
                                break;
                            case "beer":
                                Console.WriteLine(1.10 * kolichestvo);
                                break;
                            case "sweets":
                                Console.WriteLine(1.35 * kolichestvo);
                                break;
                            case "peanuts":
                                Console.WriteLine(1.55 * kolichestvo);
                                break;
                        }
                    }
                    break;
            }
        }
    }
}