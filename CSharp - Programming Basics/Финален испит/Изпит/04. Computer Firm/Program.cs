using System;

namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int komputri = int.Parse(Console.ReadLine());
            int reiting = 0;
            double vuzmojniprodajbi = 0;
            double prodajbi = 0;
            int brprodajbi = 0;
            double sumreiting = 0;
            for (int i = 0; i < komputri; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                reiting = chislo % 10;
                vuzmojniprodajbi = chislo / 10;
                if (reiting <= 2)
                {
                    vuzmojniprodajbi = vuzmojniprodajbi * 0;
                    prodajbi += 0;
                    sumreiting += reiting;
                }
                else if (reiting == 3)
                {
                    vuzmojniprodajbi = vuzmojniprodajbi * 0.50;
                    brprodajbi++;
                    prodajbi += vuzmojniprodajbi;
                    sumreiting += reiting;
                }
                else if (reiting == 4)
                {
                    vuzmojniprodajbi = vuzmojniprodajbi * 0.70;
                    prodajbi += vuzmojniprodajbi;
                    brprodajbi++;
                    sumreiting += reiting;
                }
                else if (reiting == 5)
                {
                    vuzmojniprodajbi = vuzmojniprodajbi * 0.85;
                    prodajbi += vuzmojniprodajbi;
                    brprodajbi++;
                    sumreiting += reiting;

                }
                else if (reiting == 6)
                {
                    vuzmojniprodajbi = vuzmojniprodajbi;
                    prodajbi += vuzmojniprodajbi;
                    brprodajbi++;
                    sumreiting += reiting;

                }
            }
            Console.WriteLine($"{prodajbi:F2}");
            Console.WriteLine($"{sumreiting / komputri:F2}");
        }
    }
}
