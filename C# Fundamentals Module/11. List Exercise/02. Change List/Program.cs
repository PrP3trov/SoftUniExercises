using System.Diagnostics;

List<int> result = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] arguments = input.Split();
    if (arguments[0] == "Delete")
    {
        int numberToRemove = int.Parse(arguments[1]);
        result.RemoveAll(x => x == numberToRemove);
    }
    else if (arguments[0] == "Insert")
    {
        int elementToInsert = int.Parse(arguments[1]);
        int position = int.Parse(arguments[2]);
        result.Insert(position, elementToInsert);
    }
}
Console.WriteLine(string.Join(" ", result));