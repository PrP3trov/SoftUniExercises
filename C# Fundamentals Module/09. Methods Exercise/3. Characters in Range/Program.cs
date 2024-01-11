using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            Chechking(a, b);
            Console.WriteLine(Chechking(a,b));
        }

        private static string Chechking(char a, char b)
        {
            int start = (int)a;
            int end = (int)b;
            string result = "";
            if (end < start)
            {
                start = (int)b;
                end = (int)a;
            }
            for (int i = start + 1; i < end; i++)
            {
                char letter = Convert.ToChar(i);
                result += letter + " ";
            }
            return result;
        }
    }
}
