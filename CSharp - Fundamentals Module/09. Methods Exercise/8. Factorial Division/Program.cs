using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double sum1 = num1;
            double sum2 = num2;
            sum1 = FirstFactirial(num1, sum1);
            sum2 = SecondFactorial(num2, sum2);
            Console.WriteLine($"{sum1 / sum2:F2}");
        }

        private static double SecondFactorial(double num2, double sum2)
        {
            for (double i = num2 - 1; i > 0; i--)
            {
                sum2 = sum2 * i;
            }

            return sum2;
        }

        private static double FirstFactirial(double num1, double sum1)
        {
            for (double i = num1 - 1; i > 0; i--)
            {
                sum1 = sum1 * i;
            }

            return sum1;
        }
    }
}
