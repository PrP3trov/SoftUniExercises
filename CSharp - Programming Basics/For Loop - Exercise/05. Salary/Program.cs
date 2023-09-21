using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabove = int.Parse(Console.ReadLine());
            int zaplata = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tabove; i++)
            {
                string tab = Console.ReadLine();
                if (tab == "Facebook")
                {
                    zaplata -= 150;
                }
                else if (tab == "Instagram")
                {
                    zaplata -= 100;
                }
                else if (tab == "Reddit")
                {
                    zaplata -= 50;
                }
                if (zaplata <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (zaplata > 0) { Console.WriteLine(zaplata); } 
            

        }
    }
}
