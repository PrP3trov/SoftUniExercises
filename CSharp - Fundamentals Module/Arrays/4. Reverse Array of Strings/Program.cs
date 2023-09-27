string[] items = Console.ReadLine().Split(' ').ToArray();
for (int i = 0; i < items.Length /2; i++)
{
    string firstelemt = items[i];
    string lastElement = items[items.Length - 1 - i];

    items[i] = lastElement;
    items[items.Length - 1 - i] = firstelemt;
}
Console.WriteLine(string.Join(" ", items));