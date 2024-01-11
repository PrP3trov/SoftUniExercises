using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string gorivo = Console.ReadLine();
            double litriima = double.Parse(Console.ReadLine());
            if (gorivo == "Diesel" || gorivo == "Gasoline" || gorivo == "Gas")
            {
                if (litriima >= 25)
                {
                    Console.WriteLine($"You have enough {gorivo.ToLower()}.");
                }
                else if (litriima < 25)
                {
                    Console.WriteLine($"Fill your tank with {gorivo.ToLower()}!");
                }
            }
            else Console.WriteLine("Invalid fuel!");
        }
    }
}