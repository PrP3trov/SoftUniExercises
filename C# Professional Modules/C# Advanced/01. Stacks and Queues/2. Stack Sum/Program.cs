using System.Threading.Channels;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0].ToLower() == "end")
                {
                    Console.WriteLine($"Sum: {stack.Sum()}");
                    break;
                }
                else if (command[0].ToLower() == "add")
                {
                    int firstNum = int.Parse(command[1]);
                    int secondNum = int.Parse(command[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (command[0].ToLower() == "remove")
                {
                    int removeCount = int.Parse(command[1]);
                    if (stack.Count >= removeCount)
                    {
                        for (int i = 0; i < removeCount; i++)
                        {
                            stack.Pop();
                        }
                    }
                }              
            }
            
        }
    }
}