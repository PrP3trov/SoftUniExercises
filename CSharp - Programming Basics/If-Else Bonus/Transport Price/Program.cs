using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometri = int.Parse(Console.ReadLine());
            string den = Console.ReadLine();
            if (kilometri < 20)
            {
                if (den == "day")
                {
                    Console.WriteLine($"{0.70 + kilometri * 0.79:F2}");
                }
                else if (den == "night")
                {
                    Console.WriteLine($"{0.70 + kilometri * 0.90:F2}");
                }
            }
            else if (kilometri >= 20 && kilometri < 100)
            {
                if (den == "day")
                {
                    Console.WriteLine($"{kilometri * 0.09:F2}");
                }
                else if (den == "night")
                {
                    Console.WriteLine($"{kilometri * 0.09:F2}");
                }
            }
            else if(kilometri >= 100)
            {
                if (den == "day")
                {
                    Console.WriteLine($"{kilometri * 0.06:F2}");
                }
                else if (den == "night")
                {
                    Console.WriteLine($"{kilometri * 0.06:F2}");
                }
            }
        }
    }
}