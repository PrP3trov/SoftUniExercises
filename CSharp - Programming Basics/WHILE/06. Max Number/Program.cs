using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo = 0;
            double max = double.MinValue;
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    Console.WriteLine(max);
                    break;
                }
                else
                {
                    chislo = int.Parse(command);
                    
                    if (chislo > max)
                    {
                        max = chislo;
                    }
                }
            }
        }
    }
}
