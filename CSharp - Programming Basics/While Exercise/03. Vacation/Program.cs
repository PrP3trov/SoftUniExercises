using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paritrq = double.Parse(Console.ReadLine());
            double pariima = double.Parse(Console.ReadLine());
            int brharchi = 0;
            int brdni = 0;
            while (true) 
            {
                brdni++;
                string command = Console.ReadLine();
                if (command == "spend")
                {
                    double chislo = double.Parse(Console.ReadLine());
                    pariima -= chislo;
                    if (pariima <= 0) { pariima = 0; }
                    brharchi++;                  
                }
                if (command == "save")
                {
                    double chislo1 = double.Parse(Console.ReadLine());
                    pariima += chislo1;
                    brharchi = 0;                  
                }
                if(pariima >= paritrq)
                {
                    Console.WriteLine($"You saved the money for {brdni} days.");
                    break;
                }
                if (brharchi == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(brdni);
                    break;
                }
            }

        }
    }
}
