using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            while (true)
            {
                string b = Console.ReadLine();
                if (b == "Start")
                {
                    while (true)
                    {
                        string a = Console.ReadLine();
                        if(a == "End")
                        {
                            Console.WriteLine($"Change: {sum:F2}");
                            break;
                        }
                        if (a != "Nuts" && a != "Water" && a != "Crisps" && a != "Soda" && a!= "Coke")
                        {
                            Console.WriteLine("Invalid product");
                        }
                       switch (a)
                        {
                            case "Nuts":
                                if (sum >= 2)
                                {
                                    sum -= 2;
                                    Console.WriteLine($"Purchased {a.ToLower()}");
                                }
                                else Console.WriteLine("Sorry, not enough money");
                                break;
                            case "Water":
                                if (sum >= 0.7)
                                {
                                    sum -= 0.7;
                                    Console.WriteLine($"Purchased {a.ToLower()}");
                                }
                                else Console.WriteLine("Sorry, not enough money");
                                break;
                            case "Crisps":
                                if (sum >= 1.5)
                                {
                                    sum -= 1.5;
                                    Console.WriteLine($"Purchased {a.ToLower()}");
                                }
                                else Console.WriteLine("Sorry, not enough money");
                                break;
                            case "Soda":
                                if (sum >= 0.8)
                                {
                                    sum -= 0.8;
                                    Console.WriteLine($"Purchased {a.ToLower()}");
                                }
                                else Console.WriteLine("Sorry, not enough money");
                                break;
                            case "Coke":
                                if (sum >= 1)
                                {
                                    sum -= 1;
                                    Console.WriteLine($"Purchased {a.ToLower()}");
                                }
                                else Console.WriteLine("Sorry, not enough money");
                                break;
                        }
                    }
                    break;
                }
                double n = double.Parse(b);
                if (n != 0.1 && n != 0.2 && n != 0.5 &&  n != 1 &&  n != 2)
                {
                    Console.WriteLine($"Cannot accept {n}");
                }
                else sum += n;

            }
        }
    }
}
