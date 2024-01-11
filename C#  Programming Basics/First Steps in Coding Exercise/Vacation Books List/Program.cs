using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int brPageInBook = int.Parse(Console.ReadLine());
           int pagersPerHour = int.Parse(Console.ReadLine());
            int brDaysNeeded = int.Parse(Console.ReadLine());
            int timePerBookNeeded = brPageInBook / pagersPerHour;
            int timeNeeded = timePerBookNeeded / brDaysNeeded;
            Console.WriteLine(timeNeeded);
        }
    }
}