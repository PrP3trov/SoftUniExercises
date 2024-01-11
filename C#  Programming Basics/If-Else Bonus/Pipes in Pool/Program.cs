using System;

namespace Pipes_in_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double purvatruba = P1 * h;
            double vtoratruba = P2 * h;
            double obshtotrubi = purvatruba + vtoratruba;
            if (obshtotrubi <= V) 
            {
                double zapulnen = (obshtotrubi / V) * 100;
                double purva = P1 * h / obshtotrubi * 100;
                double vtora = P2 * h / obshtotrubi * 100;
                Console.WriteLine($"The pool is {zapulnen}% full. Pipe 1: {purva:F2}%. Pipe 2: {vtora:F2}%.");
            }
            else
                Console.WriteLine($"For {h:F2} hours the pool overflows with {(obshtotrubi - V):F2} liters.");
        }
    }
}
