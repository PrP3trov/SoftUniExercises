using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double cqlDvorZelen = meters * 7.61;
            double discount = 0.18 * cqlDvorZelen;
            double finalPrice = cqlDvorZelen - discount;
            Console.WriteLine("The final price is: " + finalPrice + " lv.");
            Console.WriteLine("The discount: " + discount + " lv.");
        }
    }
}