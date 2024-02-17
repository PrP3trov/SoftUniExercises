namespace _01._Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fuel = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> consumation = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> fuelNeeded = new(Console.ReadLine().Split(" ").Select(int.Parse));
            int altitude = 1;
            int reached = 0;
            while (fuel.Count > 0)
            {
                int result = fuel.Pop() - consumation.Dequeue();
                if (result >= fuelNeeded.Dequeue())
                {              
                    Console.WriteLine($"John has reached: Altitude {altitude}");
                    reached++;
                    altitude++;
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {altitude}");
                    break;
                }
            }
            if ( reached > 0 && reached < 4 ) 
            {
                Console.WriteLine("John failed to reach the top.");
                Console.Write("Reached altitudes: ");
                for (int i = 1; i <= reached-1; i++)
                {
                    Console.Write($"Altitude {i}, ");
                }
                Console.Write($"Altitude {reached}");

            }
            else if (reached == 0)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
            else if (reached == 4)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}