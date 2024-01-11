using System.Globalization;

string[] songs = Console.ReadLine().Split(", ");
Queue<string> queue = new Queue<string>(songs);

while (queue.Any())
{
    string[] command = Console.ReadLine().Split();
    if (command[0] == "Play")
    {
        queue.Dequeue();
    }
    else if (command[0] == "Show")
    {
        Console.WriteLine(string.Join(", ",queue));
    }
    else if (command[0] == "Add")
    {
        string songName = string.Join(" ", command.Skip(1));
        if (!queue.Contains(songName))
        {
            queue.Enqueue(songName);
        }
        else
        {
            Console.WriteLine($"{songName} is already contained!");
        }
    }
}
Console.WriteLine("No more songs!");