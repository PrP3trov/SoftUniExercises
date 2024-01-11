using System;

namespace _01._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            for (int i = 0; i <= n; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
