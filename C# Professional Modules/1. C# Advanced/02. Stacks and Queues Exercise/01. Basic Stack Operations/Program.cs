int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

string[] secondLine = Console.ReadLine().Split();

Stack<int> stack = new Stack<int>();

foreach (string line in secondLine)
{
    int temp = int.Parse(line);
    stack.Push(temp);
}

for (int i = 0; i < input[1]; i++)
{
    stack.Pop();
}

if (stack.Contains(input[2]))
{
    Console.WriteLine("true");
}
else if (stack.Any())
{
    Console.WriteLine(stack.Min());
}
else
{
    Console.WriteLine(0);
}