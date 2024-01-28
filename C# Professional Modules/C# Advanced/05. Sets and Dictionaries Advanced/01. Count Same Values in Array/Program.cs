using System.Transactions;

double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

var count = new Dictionary<double, int>();

foreach (var item in input)
{
    if (count.ContainsKey(item))
    {
        count[item]++;
    }
    else
    {
        count[item] = 1; 
    }
}
foreach (var item in count)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}