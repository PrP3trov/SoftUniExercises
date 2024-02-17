namespace _01._Chicken_Snack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> money = new(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> priceFoood = new(Console.ReadLine().Split().Select(int.Parse));
            int ate = 0;
            while (money.Count > 0 && priceFoood.Count > 0)
            {

                if (money.Peek() == priceFoood.Peek())
                {
                    money.Pop();
                    priceFoood.Dequeue();
                    ate++;
                }
                else if (money.Peek() > priceFoood.Peek())
                {
                    int change = money.Peek() - priceFoood.Peek();
                    money.Pop();
                    if (money.Count > 0)
                    {
                        int push = money.Pop();
                        money.Push(change + push);
                    }

                    priceFoood.Dequeue();
                    ate++;
                }
                else if (money.Peek() < priceFoood.Peek())
                {
                    money.Pop();
                    priceFoood.Dequeue();
                }
            }

            if (ate >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {ate} foods.");
            }
            else if (ate != 0)
            {
                if (ate == 1)
                {
                    Console.WriteLine($"Henry ate: {ate} food.");
                }
                else
                {
                    Console.WriteLine($"Henry ate: {ate} foods.");
                }
            }
            else if (ate == 0)
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}