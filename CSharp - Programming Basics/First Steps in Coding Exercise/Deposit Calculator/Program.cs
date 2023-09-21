using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int srokDeposit = int.Parse(Console.ReadLine());
            double lihvenProcent = double.Parse(Console.ReadLine());
            double natrupanaLihva = depositSum * lihvenProcent / 100;
            double lihva1mesec = natrupanaLihva / 12;
            double sum = depositSum + srokDeposit * lihva1mesec;
            Console.WriteLine(sum);
        }
    }
}