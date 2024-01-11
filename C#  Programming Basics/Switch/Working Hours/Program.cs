using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int chas = int.Parse(Console.ReadLine());
            string den = Console.ReadLine();
            switch (den)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if(chas >=10 && chas <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else Console.WriteLine("closed");
                    break;
                default:
                    Console.WriteLine("closed");
                    break;

            }
        }
    }
}