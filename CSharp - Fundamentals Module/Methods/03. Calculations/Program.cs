using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string method = Console.ReadLine();
            if (method == "multiply")
            {
                Multiply();
            }
            else if (method == "subtract")
            {
                Subtract();
            }
            else if (method == "divide")
            {
                Divide();
            }
            else
            {
                Add();
            }
        }
        static void Add()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        static void Multiply()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine(result);
        }
        static void Subtract()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 - num2;
            Console.WriteLine(result);
        }
        static void Divide()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine(result);
        }

    }
}  

