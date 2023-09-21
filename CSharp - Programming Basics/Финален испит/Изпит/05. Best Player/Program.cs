using System;
using System.Linq;
using System.Net.WebSockets;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MinNumber = 0;
            string bestplayerIMe = "";
            string igrach = "";
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    Console.WriteLine($"{bestplayerIMe} is the best player!");
                    if (MinNumber >= 3)
                    {
                        Console.WriteLine($"He has scored {MinNumber} goals and made a hat-trick !!!");
                    }
                    else Console.WriteLine($"He has scored {MinNumber} goals.");
                    break;
                }
                igrach = command;
                int golove = int.Parse(Console.ReadLine());
                if (golove >= 10)
                {
                    Console.WriteLine($"{igrach} is the best player!");
                    Console.WriteLine($"He has scored {golove} goals and made a hat-trick !!!");
                    break;
                }
                if (golove  > MinNumber)
                {
                    bestplayerIMe = igrach;
                    MinNumber = golove;
                }

            }
        }
    }
}
