using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumchetno = 0;
            int sumnechetno = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sumnechetno += chislo;
                }
                if (i % 2 == 0)
                {
                    sumchetno += chislo;
                }
            }
            if (sumnechetno == sumchetno) { Console.WriteLine("Yes"); Console.WriteLine($"Sum = {sumchetno}"); }
            else { Console.WriteLine("No"); Console.WriteLine($"Diff = {Math.Abs(sumchetno - sumnechetno)}"); }
        }
    }
}
