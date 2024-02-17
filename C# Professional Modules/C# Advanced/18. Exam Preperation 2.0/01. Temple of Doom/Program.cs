namespace _01._Temple_of_Doom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            List<int> challenges = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            while (true)
            {
                int result = tools.Peek() * substances.Peek();
                if (challenges.Contains(result))
                {
                    challenges.Remove(result);
                    tools.Dequeue();
                    substances.Pop();
                    if (challenges.Count == 0)
                    {
                        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
                        break;
                    }
                }
                else
                {
                    int temp = tools.Dequeue();
                    temp++;
                    tools.Enqueue(temp);
                    int temp2 = substances.Pop();
                    temp2--;
                    substances.Push(temp2);
                    if (substances.Peek() == 0)
                    {
                        substances.Pop();
                    }

                    if (substances.Count != 0 && tools.Count != 0) continue;
                    if (challenges.Count <= 0) continue;
                    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
                    break;
                }

            }
            if (tools.Any())
            {
                Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            }
            if (substances.Any())
            {
                Console.WriteLine($"Substances: {string.Join(", ", substances)}");
            }
            if (challenges.Any())
            {
                Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
            }
        }
    }
}