using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n  = int.Parse(Console.ReadLine());
            string result = Repeat_String(text,n);
            Console.WriteLine(result);
        }

         static string Repeat_String(string text, int repetition)
        {
            string newtext = string.Empty;
            for (int i = 0; i < repetition; i++)
            {
                newtext += text;
            }
            return newtext;
        }
    }
}
