using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lqva = 0, dqsna = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                lqva += chislo;
            }
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                dqsna += chislo;
            }
            if (lqva == dqsna) { Console.WriteLine($"Yes, sum = {lqva}"); }
            else Console.WriteLine($"No, diff = {Math.Abs((lqva - dqsna))}");
        }
    }
}
