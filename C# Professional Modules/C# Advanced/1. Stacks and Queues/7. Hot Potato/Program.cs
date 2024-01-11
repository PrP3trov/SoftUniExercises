namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());
            int toss = 1;
            while (queue.Count != 1)
            {
                string childPotato = queue.Dequeue();
                if (toss == n)
                {
                    Console.WriteLine($"Removed {childPotato}");
                    toss = 0;
                }
                else
                {
                    queue.Enqueue(childPotato);

                }
                toss++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}