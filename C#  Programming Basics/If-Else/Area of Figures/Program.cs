using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double lice =a * a;
                string formattedNumber = lice.ToString("0.000");
                Console.WriteLine(formattedNumber);
            }
            else if (figure == "rectangle")
            {
                double a =double.Parse(Console.ReadLine());
                double b =double.Parse(Console.ReadLine());
                double lice1 = a * b;
                string formattedNumber1 = lice1.ToString("0.000");
                Console.WriteLine(formattedNumber1);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double lice2 = (Math.PI * (r * r));
                string formattedNumber2 = lice2.ToString("0.000");
                Console.WriteLine(formattedNumber2);
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double lice3 = ((a * h) / 2 );
                string formattedNumber3 = lice3.ToString("0.000");
                Console.WriteLine(formattedNumber3);
            }
        }
    }
}