using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int shirinaProstranstvo = int.Parse(Console.ReadLine());
            int duljinaProstranstvo = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int mqstoIma = shirinaProstranstvo * duljinaProstranstvo * h;
            int sum = 0;
            int kashon = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    Console.WriteLine($"{mqstoIma - sum} Cubic meters left.");
                    break;
                }
                else
                {
                    kashon = int.Parse(command);
                    sum += kashon;
                    if (sum >= mqstoIma)
                    {
                        Console.WriteLine($"No more free space! You need {sum - mqstoIma} Cubic meters more.");
                        break;
                    }
                }
            }
        }
    }
}
