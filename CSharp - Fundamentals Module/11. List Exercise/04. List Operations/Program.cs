using System;

List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;
while ((input = Console.ReadLine()) != "End")
{ 
    string[] arguments = input.Split();
    if (arguments[0]== "Add")
    {
        int numberAdd = int.Parse(arguments[1]);
        list.Add(numberAdd);
    }
    else if (arguments[0] == "Insert")
    {
        int elementToInsert = int.Parse(arguments[1]);
        int index = int.Parse(arguments[2]);
        if (IsNotValidIndex(index, list.Count))
        {
            Console.WriteLine("Invalid index");
        }
        else
        {

            list.Insert(index, elementToInsert);
        }
    }
    else if (arguments[0] == "Remove")
    {
        int index = int.Parse(arguments[1]);
        if (IsNotValidIndex(index, list.Count))
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            list.RemoveAt(index);

        }
    }
    else if (arguments[0] == "Shift")
    {
        int count = int.Parse(arguments[2]);
        count %= list.Count;

        if (arguments[1] == "left")
        {
            List<int> shiftedPart = list.GetRange(0,count);
            list.RemoveRange(0, count);
            list.InsertRange(list.Count, shiftedPart);
        }
        else if (arguments[1] == "right")
        {
            List<int> shiftedPart = list.GetRange(list.Count - count, count);
            list.RemoveRange(list.Count - count, count);
            list.InsertRange(0, shiftedPart);
        }
    }
}
Console.WriteLine(string.Join(" ", list));

static bool IsNotValidIndex(int index, int listCount)
{
    return index < 0 || index >= listCount;
}