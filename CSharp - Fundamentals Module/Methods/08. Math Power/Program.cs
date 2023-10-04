using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basenum = Basenum();
            double power = Power();
            Console.WriteLine(Math.Pow(basenum,power));
        }
        static double Power()
        {
            double powernum = double.Parse(Console.ReadLine());
            return powernum;
        }
         static double Basenum()
        {
            double basenum = double.Parse(Console.ReadLine());
            return basenum;
        }
    }
}
