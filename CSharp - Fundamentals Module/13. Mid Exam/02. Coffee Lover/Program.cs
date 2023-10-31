using System;
using System.Diagnostics.Contracts;

List<string> coffees = Console.ReadLine().Split(" ").ToList();
int commands = int.Parse(Console.ReadLine());
for (int i = 0; i < commands; i++)
{  
    string[] arguments = Console.ReadLine().Split();
    if (arguments[0] == "Include")
    {
        string coffee = arguments[1];
        coffees.Add(coffee);
    }
    if (arguments[0] =="Remove")
    {
        int index = int.Parse(arguments[2]);
        if (IsNotValidIndex(index, coffees.Count))
        {

        }
        else
        {
            if (arguments[1] == "first")
            {
                coffees.RemoveRange(0, index);
            }
            else if (arguments[1] =="last")
            {
                if (index == 1)
                {
                    coffees.RemoveAt(coffees.Count-1);
                }
                else
                {
                    coffees.RemoveRange(coffees.Count - index, index);

                }
            }
        }

    }
    if (arguments[0] == "Prefer")
    {
        int index1 = int.Parse(arguments[1]);
        int index2 = int.Parse(arguments[2]);
        if (IsNotValidIndex1(index1, coffees.Count) || IsNotValidIndex1(index2, coffees.Count))
        {

        }
        else
        {
            string swap1 = coffees[index1];
            coffees[index1] = coffees[index2];
            coffees[index2] = swap1;
        }
    }
    if (arguments[0]== "Reverse")
    {
        coffees.Reverse();
    }
}
Console.WriteLine("Coffees:");
Console.WriteLine(string.Join(" ", coffees));
static bool IsNotValidIndex(int index, int coffeesCount)
{
    return coffeesCount <= index;
}
static bool IsNotValidIndex1(int index1, int coffeesCount)
{
    return index1 < 0 || index1 >= coffeesCount;
}