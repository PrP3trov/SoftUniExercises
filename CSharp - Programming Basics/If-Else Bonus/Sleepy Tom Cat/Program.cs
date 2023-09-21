using System;

namespace Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pochivniDni = int.Parse(Console.ReadLine());
            int rabotniDni = 365 - pochivniDni;
            int vremeIgra = rabotniDni * 63 + pochivniDni * 127;
            if (vremeIgra > 30000) 
            {
                int razlikaNorma = vremeIgra - 30000;
                int chasove = razlikaNorma / 60;
                int minuti = razlikaNorma % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{chasove} hours and {minuti} minutes more for play");
            }
            else if (vremeIgra < 30000)
            {
                int razlikaNorma = 30000 - vremeIgra;
                int chasove = razlikaNorma / 60;
                int minuti = razlikaNorma % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{chasove} hours and {minuti} minutes less for play");
            }
        }
    }
}
