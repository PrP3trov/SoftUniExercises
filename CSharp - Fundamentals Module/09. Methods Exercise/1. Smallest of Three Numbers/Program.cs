using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double min = 0;
            min = CheckingMinNum(num1, num2, num3, min);
            Console.WriteLine(min);
        }

        private static double CheckingMinNum(double num1, double num2, double num3, double min)
        {
            if (num1 < num2 && num1 < num3)
            {
                min = num1;
                return min;
            }
            else if (num2 < num3 && num2 < num1)
            {
                min = num2;
                return min;
            }
            else 
            return min = num3;
        }
    }
}
