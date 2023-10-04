using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double result = Calculation(w, h);
            Console.WriteLine(result);
        }
        static double Calculation(double w, double h)
        {
            
            return w * h;
        }
    }
}
