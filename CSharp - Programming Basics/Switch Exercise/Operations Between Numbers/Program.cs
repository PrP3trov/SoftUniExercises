using System;

namespace Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N1 = int.Parse(Console.ReadLine());
            double N2 = int.Parse(Console.ReadLine());
            string operatorA = Console.ReadLine();
            double rezult = 0;
            
            switch (operatorA)
            { 
                
                case "+": rezult = N1 + N2;
                    if (rezult % 2 == 0) { Console.WriteLine($"{N1} + {N2} = {rezult} - even"); }
                    else Console.WriteLine($"{N1} + {N2} = {rezult} - odd");
                    break;
                case "-": rezult = N1 - N2;
                    if (rezult % 2 == 0) { Console.WriteLine($"{N1} - {N2} = {rezult} - even"); }
                    else Console.WriteLine($"{N1} - {N2} = {rezult} - odd");
                    break;
                case "*": rezult = N1 * N2;
                    if (rezult % 2 == 0) { Console.WriteLine($"{N1} * {N2} = {rezult} - even"); }
                    else Console.WriteLine($"{N1} * {N2} = {rezult} - odd");
                    break;
                case "/": if (N2 == 0) { Console.WriteLine($"Cannot divide {N1} by zero"); }
                    else
                    {
                        rezult = N1 / N2;
                        Console.WriteLine($"{N1} / {N2} = {rezult:F2}");
                    }
                    break;
                case "%": if (N2 == 0) { Console.WriteLine($"Cannot divide {N1} by zero"); }
                    else
                    {
                        rezult = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {rezult}");
                    }
                    break;
            }

        }
    }
}
