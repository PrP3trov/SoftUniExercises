List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();    
List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList(); 
List<int> result = new List<int>();
int longerList = Math.Max(first.Count, second.Count);
for (int i= 0; i < longerList; i++)
{
    if (i < first.Count)
    {
        result.Add(first[i]);
    }
    if (i < second.Count)
    {
        result.Add(second[i]);
    }
}

Console.WriteLine(string.Join(" ", result));