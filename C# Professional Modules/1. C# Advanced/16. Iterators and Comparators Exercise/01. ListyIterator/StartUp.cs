namespace _1._ListyIterator
{
    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            ListyIterator<string> listy = new(input.Skip(1).ToList());
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Print":
                        try
                        {
                            listy.Print();
                        }
                        catch(InvalidOperationException ioe)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }                      
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                }
            }
        }
    }
}