int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(secondLine);
for (int i = 0; i < firstLine[1]; i++)
{
    queue.Dequeue();
}
if (!queue.Any())
{
    Console.WriteLine(0);
}
else if (queue.Contains(firstLine[2]))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}