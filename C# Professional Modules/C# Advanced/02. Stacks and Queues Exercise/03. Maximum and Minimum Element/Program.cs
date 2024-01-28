using System.Globalization;

int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (command[0] == 1)
    {
        stack.Push(command[1]);
    }
    else if (command[0] == 2)
    {
        stack.Pop();
    }
    else if (command[0] == 3)
    {
        if (stack.Count != 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (command[0] == 4)
    {
        if (stack.Count!= 0)
        {
            Console.WriteLine(stack.Min());
        }
    }
}
while (stack.Count > 1)
{
    Console.Write(stack.Pop() + ", ");
}
Console.Write(stack.Pop());