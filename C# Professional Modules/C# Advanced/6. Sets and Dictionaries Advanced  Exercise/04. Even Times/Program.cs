List<int> numbers = new List<int>();
Dictionary<int,int> count = new Dictionary<int,int>();
int n  = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    numbers.Add(input);
          
}
foreach (int input in numbers)
{
    if (!count.ContainsKey(input))
    {
        count[input] = 0;
    }
    count[input]++;
}
foreach (var item in count)
{
    if (item.Value %2 == 0)
    {
        Console.WriteLine(item.Key);
    }
}