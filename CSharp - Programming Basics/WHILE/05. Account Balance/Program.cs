using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money < 0.0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine("Increase: {0:F2}", money);
                sum += money;
            }

            Console.WriteLine("Total: {0:F2}", sum);
        }
    }
}
