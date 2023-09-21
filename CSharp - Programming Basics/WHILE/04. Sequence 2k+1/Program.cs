using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int chislo = 1;
            while (chislo <= n)
            {
                Console.WriteLine(chislo);
                chislo = chislo * 2 + 1;
            }
        }
    }
}
