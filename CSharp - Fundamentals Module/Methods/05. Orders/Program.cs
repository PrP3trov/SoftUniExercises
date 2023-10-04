using System;
using System.Net.NetworkInformation;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sum = 0, price = 0;
            CheckingProduct(product, quantity, ref sum, ref price);
        }

        private static void CheckingProduct(string product, int quantity, ref double sum, ref double price)
        {
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    sum += price * quantity;
                    break;
                case "water":
                    price = 1.00;
                    sum += price * quantity;
                    break;
                case "coke":
                    price = 1.40;
                    sum += price * quantity;
                    break;
                case "snacks":
                    price = 2.00;
                    sum += price * quantity;
                    break;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
