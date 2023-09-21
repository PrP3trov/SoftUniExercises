using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo = 0;
            double min = double.MaxValue;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    Console.WriteLine(min);
                    break;
                }
                else
                {
                    chislo = int.Parse(command);
                    if (chislo < min)
                    {
                        min = chislo;
                    }
                }
            }
        }
    }
}
