namespace Problem_1___String_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Translate")
                {
                    char replace = char.Parse(command[1]);
                    char replacement = char.Parse(command[2]);
                    input = input.Replace(replace, replacement);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Includes")
                {
                    string check = command[1];
                    if (input.Contains(check))
                    {
                        Console.WriteLine("True");
                    }
                    else Console.WriteLine("False");
                }
                else if (command[0] == "Start")
                {
                    string substtring = command[1];
                    if (input.StartsWith(substtring))
                    {
                        Console.WriteLine("True");
                    }
                    else Console.WriteLine("False");
                }
                else if (command[0] == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command[0] == "FindIndex")
                {
                    char charachter = char.Parse(command[1]);
                    int num = input.LastIndexOf(charachter);
                    Console.WriteLine(num);

                }
                else if (command[0] == "Remove")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    input  = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }

            }
        }
    }
}