using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumOcenki = 0;
            int n = int.Parse(Console.ReadLine());
            double brOcenki = 0;
            double ocenkiVsSum = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {ocenkiVsSum / brOcenki:F2}.");
                    break;
                }           
                string prezentaciq = command;
                for (int i = 0; i < n; i++)
                {
                    double ocenka = double.Parse(Console.ReadLine());
                    brOcenki++;
                    sumOcenki += ocenka;
                    ocenkiVsSum += ocenka;
                }
                Console.WriteLine($"{prezentaciq} - {sumOcenki / n:F2}.");
                sumOcenki = 0;
            }
        }
    }
}
