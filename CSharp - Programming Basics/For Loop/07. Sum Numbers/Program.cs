using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                sum += chislo;
            }
            Console.WriteLine(sum);
        }
    }
}
