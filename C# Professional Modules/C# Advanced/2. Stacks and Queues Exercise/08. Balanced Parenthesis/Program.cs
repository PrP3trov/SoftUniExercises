char[] input = Console.ReadLine().ToCharArray();
if (input.Length %2 != 0)
{
    Console.WriteLine("NO");
    return;
}
Stack<char> stack = new Stack<char>();
foreach (char c in input)
{
    if ("{[(".Contains(c))
    {
        stack.Push(c);
    }
    else if (c == ')' && stack.Peek() == '(')
    {
        stack.Pop();
    }
    else if (c == ']' && stack.Peek() == '[')
    {
        stack.Pop();
    }
    else if (c == '}' && stack.Peek() == '{')
    {
        stack.Pop();
    }
}
Console.WriteLine(stack.Any() ? "NO" : "YES");
