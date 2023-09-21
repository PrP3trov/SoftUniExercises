using System;
using System.Diagnostics.CodeAnalysis;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int musala = 0; int Monblan = 0; int Kilimandjaro = 0; int K2 = 0; int Everest = 0;
            int broigrupi = int.Parse(Console.ReadLine());
            for (int i = 0; i < broigrupi; i++)
            {
                int grupa = int.Parse(Console.ReadLine());
                sum += grupa;
                if (grupa <= 5)
                {
                    musala += grupa;
                }
                else if (grupa >= 6 && grupa <= 12)
                {
                    Monblan += grupa;
                }
                else if (grupa >= 13 && grupa <= 25)
                {
                    Kilimandjaro += grupa;
                }
                else if (grupa >= 26 && grupa <= 40)
                {
                    K2 += grupa;
                }
                else Everest += grupa;
            }
            Console.WriteLine($"{(musala / sum * 100):F2}%");
            Console.WriteLine($"{(Monblan / sum * 100):F2}%");
            Console.WriteLine($"{(Kilimandjaro / sum * 100):F2}%");
            Console.WriteLine($"{(K2 / sum * 100):F2}%");
            Console.WriteLine($"{(Everest / sum * 100):F2}%");
        }
    }
}
