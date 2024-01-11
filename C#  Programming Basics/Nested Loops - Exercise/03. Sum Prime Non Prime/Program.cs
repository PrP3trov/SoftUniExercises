using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumprosto = 0 , sumslojon = 0 ;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {sumprosto}");
                    Console.WriteLine($"Sum of all non prime numbers is: {sumslojon}");
                    break;
                }
                int chislo = int.Parse(command);
                if (chislo <0 ) 
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isNumberPrime = true;
                for (int i = 2; i < chislo; i++)
                {
                    if (chislo % i == 0)
                    {
                        //ne e prosto
                        isNumberPrime = false;
                        break;
                    }
                }
                if (isNumberPrime)
                {
                    sumprosto += chislo;
                    
                }
                else
                {
                    sumslojon += chislo;
                }
            }
        }
    }
}
