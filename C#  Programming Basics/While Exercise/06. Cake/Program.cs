using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shirina = int.Parse(Console.ReadLine());
            int duljina = int.Parse(Console.ReadLine());
            int parcheta = shirina * duljina;
            int vzema = 0;
            while (true)
            {         
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{parcheta} pieces are left.");
                    break;
                }
                else
                {
                    vzema = int.Parse(command);
                    parcheta = parcheta - vzema;
                    if (parcheta < 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(parcheta)} pieces more.");
                        break;
                    }
                }
            }
        }
    }
}
