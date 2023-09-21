using System;

namespace _02._Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int min = int.Parse(Console.ReadLine());
           int sec = int.Parse(Console.ReadLine());
           double ulei = double.Parse(Console.ReadLine());
           int sec100m = int.Parse(Console.ReadLine());
            int kontrolasec = min * 60 + sec;
            double namalenoVreme = (ulei / 120) * 2.5;
            double vremeMarin = (ulei / 100) * sec100m - namalenoVreme;
            if (vremeMarin <= kontrolasec)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {vremeMarin:F3}.");
            }
            else Console.WriteLine($"No, Marin failed! He was {vremeMarin - kontrolasec:F3} second slower.");

        }
    }
}
