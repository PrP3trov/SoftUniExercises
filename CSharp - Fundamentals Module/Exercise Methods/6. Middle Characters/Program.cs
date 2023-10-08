using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            ChechingMiddle(word);
        }

        private static void ChechingMiddle(string word)
        {
            if (word.Length % 2 == 0)
            {
                int a = word.Length / 2;
                Console.WriteLine($"{word[a - 1]}" + $"{word[a]}");
            }
            else
            {
                int b = word.Length / 2;
                Console.WriteLine(word[b]);
            }
        }
    }
}
