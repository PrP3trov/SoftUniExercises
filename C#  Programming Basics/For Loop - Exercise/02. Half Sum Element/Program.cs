using System;

namespace _01._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                sum += chislo;
                if (chislo > max)
                {
                    max = chislo;
                }
            }
            sum = sum - max;
            if (max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((max - sum))}");
            }
        }
    }
}
