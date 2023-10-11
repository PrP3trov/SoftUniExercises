using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = 0;
            if (number % 2 == 0)
            {
                n = 2;
            }
            if (number % 3 == 0)
            {
                n = 3;
            }
            if (number % 6 == 0)
            {
                n = 6;
            }
            if (number % 7 == 0)
            {
                n = 7;
            }
            if (number % 10 == 0)
            {
                n = 10;
            }
            if (n == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else Console.WriteLine($"The number is divisible by {n}");

        }
    }
}
