using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resto = decimal.Parse(Console.ReadLine());
            int br = 0;
            while (resto > 0)
            {
                if (resto >= 2m)
                {
                    resto -= 2;
                }
                else if (resto >= 1m)
                {
                    resto -= 1;
                }
               else if (resto >= 0.5m)
                {
                    resto -= 0.5m;
                }
               else if (resto >= 0.2m)
                {
                    resto -= 0.2m;
                }
               else if (resto >= 0.10m)
                {
                    resto -= 0.10m;
                }
              else  if (resto >= 0.05m)
                {
                    resto -= 0.05m;
                }
               else if (resto >= 0.02m)
                {
                    resto -= 0.02m;
                }
                else
                {
                    resto -= 0.01m; 
                }
                br++;
            }
            Console.WriteLine(br);
        }
    }
}
