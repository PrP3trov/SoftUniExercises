using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brLoshiOcenki = 0;
            int brOcenki = 0;
            double sumOceki = 0;
            int brZadachi = 0;
            string last = "";
           int nezadovolitleOcenki = int.Parse(Console.ReadLine());
            while (true)
            {
                string imeZadacha = Console.ReadLine();
                if (imeZadacha == "Enough")
                {
                    Console.WriteLine($"Average score: {(sumOceki / brOcenki):F2}");
                    Console.WriteLine($"Number of problems: {brZadachi}");
                    Console.WriteLine($"Last problem: {last}");
                    break;
                }         
                last = imeZadacha;
                brOcenki++;
                brZadachi++;
                int ocenka = int.Parse(Console.ReadLine());
                sumOceki += ocenka;

                if (ocenka <=4)
                {
                    brLoshiOcenki++;
                }
                if (brLoshiOcenki == nezadovolitleOcenki)
                {
                    Console.WriteLine($"You need a break, {brLoshiOcenki} poor grades.");
                    break;
                }
            }
        }
    }
}
