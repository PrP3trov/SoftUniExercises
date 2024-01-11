using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string day = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch(plod)
                    {
                        case "banana":
                            Console.WriteLine($"{2.50 * kolichestvo:F2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{1.20 * kolichestvo:F2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{0.85 * kolichestvo:F2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{1.45 * kolichestvo:F2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{2.70 * kolichestvo:F2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{5.50 * kolichestvo:F2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{3.85 * kolichestvo:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                 case "Sunday":
                    switch (plod)
                    {
                        case "banana":
                            Console.WriteLine($"{2.70 * kolichestvo:F2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{1.25 * kolichestvo:F2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{0.90 * kolichestvo:F2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{1.60 * kolichestvo:F2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{3.00 * kolichestvo:F2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{5.60 * kolichestvo:F2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{4.20 * kolichestvo:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;


            }
        }
    }
}