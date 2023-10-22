using System.Runtime.InteropServices;

int cities = int.Parse(Console.ReadLine());
double sum = 0;
bool specialEvent = true;
for (int i = 1; i <= cities; i++)
{
    string city = Console.ReadLine();
    double income = double.Parse(Console.ReadLine());
    double expens = double.Parse(Console.ReadLine());
    if (i % 3 == 0)
    {
        if (i % 5 == 0)
        { 
           specialEvent = false;
        }
        if (specialEvent)
        {
            Console.WriteLine($"In {city} Burger Bus earned {income - (expens + expens * 0.5):F2} leva.");
            sum += income - (expens + expens * 0.5);
        }
        else
        {
            income = income - income * 0.1;
            Console.WriteLine($"In {city} Burger Bus earned {income - expens:F2} leva.");
            sum += income - expens;
        }
    }
    else if (i % 5 == 0)
    {
   
            income = income - income * 0.1;
            Console.WriteLine($"In {city} Burger Bus earned {income - expens:F2} leva.");
            sum += income - expens;
        
    }
    else
    {
        Console.WriteLine($"In {city} Burger Bus earned {income - expens:F2} leva.");
        sum += income - expens;
    } 
}
Console.WriteLine($"Burger Bus total profit: {sum:F2} leva.");
