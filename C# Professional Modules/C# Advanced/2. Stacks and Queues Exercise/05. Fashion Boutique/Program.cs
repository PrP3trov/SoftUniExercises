int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rack = int.Parse(Console.ReadLine());
int currectRack = rack;
int sum = 0;
int rackCount = 1;
Stack<int> stack = new Stack<int>(clothes);
while (stack.Any())
{
    if (stack.Peek() <= currectRack)
    {
        currectRack -= stack.Pop();
    }
    else
    {
        rackCount++;
        currectRack = rack;
    }
}
Console.WriteLine(rackCount);