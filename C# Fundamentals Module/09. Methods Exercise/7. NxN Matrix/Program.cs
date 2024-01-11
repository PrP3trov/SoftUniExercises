using System;

namespace _7._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NxN();
        }
        static void NxN()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
