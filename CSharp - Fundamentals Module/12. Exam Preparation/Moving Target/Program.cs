using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;

List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] arguments = input.Split();
    if (arguments[0] == "Shoot")
    {
        int index = int.Parse(arguments[1]);
        int power = int.Parse(arguments[2]);
        if (MentodiTotev(index, list))
        {
            list[index] -= power;

            if (list[index] <= 0)
            {
                list.RemoveAt(index);
            }
        }
    }
    if (arguments[0] == "Strike")
    {
        int index = int.Parse(arguments[1]); 
        int radius = int.Parse(arguments[2]); 
        if (MentodiTotev(index,list) && MentodiTotev(index + radius,list) && MentodiTotev(index - radius,list))
        {
            for (int i = 1; i <= radius; i++)
            {
                list.RemoveAt(index + i);
            }
            list.RemoveAt(index);
            for (int i = 1; i <= radius; i++)
            {
                list.RemoveAt(index - i);
            }
        }
        else 
        {
            Console.WriteLine("Strike missed!");
        }
    }
    if (arguments[0] == "Add")
    {
        int index = int.Parse(arguments[1]);
        int value = int.Parse(arguments[2]);
        if (MentodiTotev(index,list))
        {
            list.Insert(index, value);
        }
        else
        {
            Console.WriteLine("Invalid placement!");
        }
    }
}
Console.WriteLine(string.Join("|",list));

static bool MentodiTotev(int index, List<int> list)
{
    return index >= 0 && index < list.Count;
}