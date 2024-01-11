using System;

namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradus = int.Parse(Console.ReadLine());
            string vreme = Console.ReadLine();
            if (gradus >= 10 && gradus <= 18)
            {
                if (vreme == "Morning")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (vreme == "Afternoon")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if (vreme == "Evening")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (gradus > 18 && gradus <= 24)
            {
                if (vreme == "Morning")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if (vreme == "Afternoon")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your T-Shirt and Sandals.");
                }
                else if (vreme == "Evening")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (gradus >=25)
            {
                if (vreme == "Morning")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your T-Shirt and Sandals.");
                }
                else if (vreme == "Afternoon")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Swim Suit and Barefoot.");
                }
                else if (vreme == "Evening")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
