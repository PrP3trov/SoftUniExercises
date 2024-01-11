using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double student = 0, standard = 0, kid = 0, biletibr = 0, biletisum = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    Console.WriteLine($"Total tickets: {biletisum}");
                    Console.WriteLine($"{student / biletisum * 100:F2}% student tickets.");
                    Console.WriteLine($"{standard / biletisum * 100:F2}% standard tickets.");
                    Console.WriteLine($"{kid / biletisum * 100:F2}% kids tickets.");
                    break;
                }
                string film = command; 
                double mesta = double.Parse(Console.ReadLine()); 
                double svobodnimesta = mesta;                               
                while (svobodnimesta > 0)
                {
                   string bilet = Console.ReadLine();
                    if(bilet == "End")
                    {
                        break;
                    }
                    svobodnimesta--;
                    if (bilet == "student")
                    {
                        student++;
                        biletibr++;
                    }
                    if (bilet == "standard")
                    {
                      standard++;
                        biletibr++;
                    }
                    if (bilet == "kid")
                    {
                       kid++;
                        biletibr++;
                    }                                     
                }
                Console.WriteLine($"{film} - {(biletibr / mesta) * 100:F2}% full.");
                biletisum += biletibr;
                biletibr = 0;
            }
        }
    }
}
