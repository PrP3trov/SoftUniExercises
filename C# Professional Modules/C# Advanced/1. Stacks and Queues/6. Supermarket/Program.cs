namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine($"{queue.Count()} people remaining.");
                    break;
                }
                else if (command == "Paid")
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}