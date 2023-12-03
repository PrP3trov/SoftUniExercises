namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            if (key == null)
            {
                Console.WriteLine("Error");
            };
            
            while (true)
            {
                string[] command = Console.ReadLine().Split(">>>").ToArray();
                if (command[0] == "Generate")
                {
                    Console.WriteLine($"Your activation key is: {key}");
                }
                else if (command[0] == "Contains")
                {
                    string substring = command[1];
                    bool a = key.Contains(substring);
                    if (a)
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }
                else
                {
                    if (command[1] == "Upper")
                    {
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        string replace = key.Substring(startIndex, endIndex - startIndex);
                        string upper = key.Substring(startIndex, endIndex - startIndex).ToUpper();
                        key = key.Replace(replace, upper);
                        Console.WriteLine(key);

                    }
                    else if (command[1] == "Lower")
                    {
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        string replace = key.Substring(startIndex, endIndex - startIndex);
                        string lower = key.Substring(startIndex, endIndex - startIndex).ToLower();
                        key = key.Replace(replace, lower);
                        Console.WriteLine(key);
                    }
                }
            }
        }
    }
}