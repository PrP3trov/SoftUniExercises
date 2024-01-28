int n = int.Parse(Console.ReadLine());
Queue<int[]> queue = new Queue<int[]>();
for (int i = 0; i < n; i++)
{
    int[] pumpData = Console.ReadLine().Split().Select(int.Parse).ToArray();
    queue.Enqueue(pumpData);
}

int position = 0;
while (true)
{
    int fuel = 0;

    foreach (var pump in queue)
    {
        fuel += pump[0] - pump[1];
        if (fuel < 0)
        {
            position++;
            queue.Enqueue(queue.Dequeue());
            break;
        }
    }
    if (fuel >= 0)
    {
        break;
    }

}
Console.WriteLine(position);