using System;

namespace Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            int bonus1 = 0;
            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 100 && number < 1000)
            {
                bonus = number * 0.20;
            }
            else 
            { 
                bonus = number * 0.10; 
            }
            if (number % 2 == 0)
            {
                bonus1 = 1;
            }
            else if (number % 10 == 5)
            {
                bonus1 = 2;
            }
            Console.WriteLine(bonus + bonus1);
            Console.WriteLine(number + bonus + bonus1);
        }
    }
}
