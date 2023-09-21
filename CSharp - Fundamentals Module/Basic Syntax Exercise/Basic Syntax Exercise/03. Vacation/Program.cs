using System;
using System.Xml.Schema;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double sum = 0;
            switch(typeGroup)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            sum = people * 8.45;
                            break;
                        case "Saturday":
                            sum = people * 9.80;
                            break;
                        case "Sunday":
                            sum = people * 10.46;
                            break;
                    }
                    if (people >= 30) { sum = sum - sum * 0.15;}
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            sum = people * 10.90;
                            break;
                        case "Saturday":
                            sum = people * 15.60;
                            break;
                        case "Sunday":
                            sum = people * 16;
                            break;
                    }
                    if (people >= 100)
                    {
                        switch (day)
                        {
                            case "Friday":
                                sum = people * 10.90 - 10 * 10.90;
                                break;
                            case "Saturday":
                                sum = people * 15.60 - 10 * 15.60;
                                break;
                            case "Sunday":
                                sum = people * 16 - 10 * 16;
                                break;
                        }
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            sum = people * 15;
                            break;
                        case "Saturday":
                            sum = people * 20;
                            break;
                        case "Sunday":
                            sum = people * 22.50;
                            break;
                    }
                    if (people >= 10 && people <= 20) { sum = sum - sum * 0.05; }
                    break;
            }
            Console.WriteLine($"Total price: {sum:F2}");
        }
    }
}
