using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double sum = SumFirstTwoIntegers(num1, num2);
            double sum2 = FinallSuM(num3, sum);
            Console.WriteLine(sum2);
        }

        private static double FinallSuM(double num3, double sum)
        {
            return sum - num3;
        }

        private static double SumFirstTwoIntegers(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
