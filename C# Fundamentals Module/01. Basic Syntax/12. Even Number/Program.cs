using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (chislo % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(chislo)}");
                    break;
                }
                else Console.WriteLine("Please write an even number.");
            }
        }
    }
}
