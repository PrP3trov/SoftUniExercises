int food = int.Parse(Console.ReadLine());
int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(orders);
if (queue.Any())
{
    Console.WriteLine(queue.Max());
}
int n = queue.Count;
for (int i = 0; i < n; i++)
{
    if (food >= queue.Peek())
    {
        food -= queue.Dequeue();
    }
}

if (!queue.Any())
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine("Orders left: " + string.Join(" ", queue));
}