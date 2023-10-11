using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string operatorS = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a,b,operatorS));
        }
        static double Calculate (double a, double b, string opreratoS)
        {
            double result = 0;
            switch (opreratoS)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }
            return result;
        }
    }
}
