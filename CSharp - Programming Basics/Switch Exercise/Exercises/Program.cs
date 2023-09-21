using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vidprojekciq = Console.ReadLine();
            int redove = int.Parse(Console.ReadLine());
            int koloni = int.Parse(Console.ReadLine());
            switch (vidprojekciq)
            {
                case "Premiere":
                    Console.WriteLine($"{(redove * koloni * 12.00):F2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(redove * koloni * 7.50):F2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(redove * koloni * 5.00):F2} leva");
                    break;
            }
        }
    }
}
