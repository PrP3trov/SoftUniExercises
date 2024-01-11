using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int chislo = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(chislo);
                sum += chislo;
                chislo += 2;               
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
