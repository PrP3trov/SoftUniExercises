int n = int.Parse(Console.ReadLine());
List<string> result = new List<string>();
for (int i = 0; i < n; i++)
{
    string produckt  = Console.ReadLine();
    result.Add(produckt);
}
result.Sort();
for (int i = 0; i < result.Count; i++)
{
    Console.WriteLine($"{i+1}.{result[i]}");
}