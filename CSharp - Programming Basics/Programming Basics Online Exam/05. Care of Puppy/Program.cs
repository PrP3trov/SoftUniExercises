using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrana = int.Parse(Console.ReadLine()) * 1000;
            int qde = 0;
            int sumhrana = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Adopted")
                {
                    break;
                }
                qde = int.Parse(command);
                sumhrana += qde;
            }
            if(sumhrana <= hrana)
            {
                Console.WriteLine($"Food is enough! Leftovers: {hrana - sumhrana} grams.");
            }
            else Console.WriteLine($"Food is not enough. You need {sumhrana - hrana} grams more.");
        }
    }
}
