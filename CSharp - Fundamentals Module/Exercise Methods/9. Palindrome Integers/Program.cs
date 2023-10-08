using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0, y;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                int num = int.Parse(input);                            
                y = num;
                while (num > 0)
                {
                    x = num % 10;
                    sum = (sum * 10) + x;
                    num = num / 10;
                }
                if (y == sum)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
                sum = 0;
            }
        }
    }
}
