using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videokarti = int.Parse(Console.ReadLine());
            int procesori = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double videocena = videokarti * 250;
            double procesorcena = procesori * (0.35 * videocena);
            double ramcena = ram * (0.10 * videocena);
            double sum = videocena + procesorcena + ramcena;
            if (videokarti > procesori)
            {
                 sum = sum - sum * 0.15;
            }
            if (sum <= budget)
            {
                double sotava = budget - sum;
                Console.WriteLine($"You have {sotava:F2} leva left!");
            }
            else if (sum > budget)
            {
                double trq = sum - budget;
                Console.WriteLine($"Not enough money! You need {trq:F2} leva more!");
            }
        }
    }
}
