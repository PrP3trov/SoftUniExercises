using System.Threading.Channels;

Stack<char> stack = new Stack<char>();
string input = Console.ReadLine();
foreach (var item in input)
{
    stack.Push(item);
}
while (stack.Count != 0) { 
    Console.Write(stack.Pop());}

