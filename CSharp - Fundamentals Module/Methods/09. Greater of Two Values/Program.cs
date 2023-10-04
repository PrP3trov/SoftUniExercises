using System;
using System.Collections.Generic;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string result = GetMax(a,b);
                Console.WriteLine(result);

            }
            else if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
        }

        private static char GetMax(char a, char b)
        {
            return a > b ? a:b;
        }
        static int GetMax(int a, int b)
        {
            return a > b ? a :b;
        }
        static string GetMax (string a, string b)
        {
            string result = string.Empty;
            int comparison = a.CompareTo(b);
            if (comparison > 0)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
    }
}
