using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            for (int i = number2; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i }");
            }
            if (number2 > 10)
            {
                Console.WriteLine($"{number} X {number2} = {number * number2}");
            }
        }
    }
}
