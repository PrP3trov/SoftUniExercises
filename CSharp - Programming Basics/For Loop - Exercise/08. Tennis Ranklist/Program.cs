using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; double specheli = 0;     
           int turniri = int.Parse(Console.ReadLine());
            int tochki = int.Parse(Console.ReadLine());
            for (int i = 0; i < turniri; i++)
            {
                string mqsto = Console.ReadLine();
                switch (mqsto)
                {
                    case "F": tochki += 1200;
                        sum += 1200;
                        break;
                    case "W":
                        tochki += 2000;
                        sum += 2000;
                        specheli++;
                        break;
                    case "SF":
                        tochki += 720;
                        sum += 720;
                        break;                
                }
            }
            Console.WriteLine($"Final points: {tochki}");
            Console.WriteLine($"Average points: {sum/turniri}");
            Console.WriteLine($"{((specheli / turniri) * 100):F2}%");
        }
    }
}
