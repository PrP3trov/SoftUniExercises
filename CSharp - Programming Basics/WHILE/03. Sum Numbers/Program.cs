using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            int sum = 0;
            while(sum < chislo)
            {
                int chislo1 = int.Parse(Console.ReadLine());
                sum += chislo1;
            }
            Console.WriteLine(sum);
        }
    }
}
