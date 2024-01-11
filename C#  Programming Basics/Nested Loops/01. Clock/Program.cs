using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int x = 0; x < 60; x++)
                {
                    Console.WriteLine($"{i}:{x}");
                }
            }
        }
    }
}
