using System.Security.Cryptography.X509Certificates;

Dictionary<string,Dictionary<string, int>> clothes = new();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
    string color = input[0];
    string[] newClothes = input[1].Split(",");
    if (!clothes.ContainsKey(color))
    {
        clothes.Add(color, new Dictionary<string, int>());
    }
    foreach (var item in newClothes)
    {
         if (!clothes[color].ContainsKey(item))
        {
            clothes[color].Add(item, 0);
        }
        clothes[color][item]++;
    }
}
string[] search = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
foreach (var color in clothes)
{
    Console.WriteLine($"{color.Key} clothes:");
    foreach (var item in color.Value)
    {
        Console.Write($"* {item.Key} - {item.Value}");
        if (color.Key == search[0] && item.Key == search[1])
        {
            Console.Write(" (found!)");
        }
        Console.WriteLine();
    }
}
