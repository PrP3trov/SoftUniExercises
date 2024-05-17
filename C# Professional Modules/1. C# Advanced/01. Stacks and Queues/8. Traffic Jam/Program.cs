namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"{count} cars passed the crossroads.");
                    break;
                }
                else if (command == "green")
                {                                   
                        for (int i = 0; i < n; i++)
                        {
                            if (queue.Count > 0)
                            {
                                Console.WriteLine($"{queue.Dequeue()} passed!");
                                count++;
                            }
                                
                        }                    
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            
        }
    }
    
}