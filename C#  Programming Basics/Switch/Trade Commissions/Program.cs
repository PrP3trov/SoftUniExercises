using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double prodajbi = double.Parse(Console.ReadLine());
            switch (city)
            {
                case "Sofia":
                    if (prodajbi >= 0 && prodajbi <= 500)
                    {
                        Console.WriteLine($"{0.05 * prodajbi:F2}");
                    }
                    else if (prodajbi > 500 && prodajbi <= 1000)
                    {
                        Console.WriteLine($"{0.07 * prodajbi:F2}");
                    }
                    else if (prodajbi > 1000 && prodajbi <= 10000)
                    {
                        Console.WriteLine($"{0.08 * prodajbi:F2}");
                    }
                    else if (prodajbi > 10000)
                    {
                        Console.WriteLine($"{0.12 * prodajbi:F2}");
                    }
                    else if (prodajbi < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (prodajbi >= 0 && prodajbi <= 500)
                    {
                        Console.WriteLine($"{0.045 * prodajbi:F2}");
                    }
                    else if (prodajbi > 500 && prodajbi <= 1000)
                    {
                        Console.WriteLine($"{0.075 * prodajbi:F2}");
                    }
                    else if (prodajbi > 1000 && prodajbi <= 10000)
                    {
                        Console.WriteLine($"{0.10 * prodajbi:F2}");
                    }
                    else if (prodajbi > 10000)
                    {
                        Console.WriteLine($"{0.13 * prodajbi:F2}");
                    }
                    else if (prodajbi < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (prodajbi >= 0 && prodajbi <= 500)
                    {
                        Console.WriteLine($"{5.5/100 * prodajbi:F2}");
                    }
                    else if (prodajbi > 500 && prodajbi <= 1000)
                    {
                        Console.WriteLine($"{0.08 * prodajbi:F2}");
                    }
                    else if (prodajbi > 1000 && prodajbi <= 10000)
                    {
                        Console.WriteLine($"{0.12 * prodajbi:F2}");
                    }
                    else if (prodajbi > 10000)
                        {
                        Console.WriteLine($"{0.145 * prodajbi:F2}"); 
                    }
                    else if (prodajbi < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
 
        }
    }
}