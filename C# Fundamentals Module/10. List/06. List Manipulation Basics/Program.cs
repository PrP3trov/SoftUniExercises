using System.Globalization;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
while (true)
{
    string line = Console.ReadLine();
    if (line == "end")
    {
        Console.WriteLine(string.Join(" ", numbers));
        break;
    }
    string[] command = line.Split();
    switch (command[0])
    {
        case "Add":
            int numberToAdd = int.Parse(command[1]);
            numbers.Add(numberToAdd);
            break;          
        case "Remove":
            int numberToRemove = int.Parse(command[1]);
            numbers.Remove(numberToRemove);
            break;
        case "RemoveAt": int indexToRemove = int.Parse(command[1]);
            numbers.RemoveAt(indexToRemove);
            break;
        case "Insert":
            int numberToInsert = int.Parse(command[1]);
            int indexToInsert = int.Parse(command[2]);
            numbers.Insert(indexToInsert, numberToInsert);
            break;
    }
}