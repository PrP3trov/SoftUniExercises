HashSet<int> elements = new HashSet<int>();
HashSet<int> elements1 = new HashSet<int>();
HashSet<int> result = new HashSet<int>();
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0];
int m = input[1];
for (int i = 0; i < n; i++)
{
    elements.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < m; i++)
{
    elements1.Add(int.Parse(Console.ReadLine()));
}
foreach (int elemt in elements)
{
    foreach (int elemt1 in elements1)
    {
        if (elemt == elemt1)
        {
            result.Add(elemt);
        }
    }
}
Console.WriteLine(string.Join(" ", result));