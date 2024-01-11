using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersFoodDogs = double.Parse(Console.ReadLine());
            double numbersFoodCats = double.Parse(Console.ReadLine());
            double expenseFoodDogs = numbersFoodDogs * 2.50;
            double expenseFoodCats = numbersFoodCats * 4;
            double sum = expenseFoodCats + expenseFoodDogs;
            Console.WriteLine(sum +  " lv.");

        }
    }
}