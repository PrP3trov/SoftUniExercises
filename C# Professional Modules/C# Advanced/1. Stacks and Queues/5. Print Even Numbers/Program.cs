namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            string result = "";
            while(queue.Count != 1)
            {
                int curectnum = queue.Dequeue();
                if (curectnum %2 == 0)
                {
                    Console.Write(curectnum + ", ");
                }
            }
            Console.Write(queue.Dequeue());

        }
    }
}