using System;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imeserial = Console.ReadLine();
            double serial = double.Parse(Console.ReadLine());
            double pochivka = double.Parse(Console.ReadLine());
            double vremeObqd = pochivka * 1 / 8;
            double vremeOtdih = pochivka * 1 / 4;
            double ostanaVreme = pochivka - vremeObqd - vremeOtdih;
            if(ostanaVreme >= serial)
            {
                Console.WriteLine($"You have enough time to watch {imeserial} and left with {Math.Ceiling(ostanaVreme - serial)} minutes free time.");
            }
            else if (ostanaVreme < serial)
            {
                Console.WriteLine($"You don't have enough time to watch {imeserial}, you need {Math.Ceiling(serial - ostanaVreme)} more minutes.");
            }
        }
    }
}
