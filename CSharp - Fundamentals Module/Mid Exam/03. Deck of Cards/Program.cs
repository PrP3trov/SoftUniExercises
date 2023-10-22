List<string> list = Console.ReadLine().Split(", ").ToList();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    if (input[0] == "Add")
    {
        string card = input[1];
        if (list.Contains(card))
        {
            Console.WriteLine("Card is already in the deck");
        }
        else
        {
            list.Add(card);
            Console.WriteLine("Card successfully added");
        }
    }
    if (input[0] == "Remove")
    {
        string card = input[1]; 
        if (list.Contains(card))
        {
            list.Remove(card);
            Console.WriteLine("Card successfully removed");
        }
        else
        {
            Console.WriteLine("Card not found");
        }
    }
    if (input[0] == "Remove At")
    {
        int index = int.Parse(input[1]);
        if (IsNotValidIndex(index, list.Count))
        {
            Console.WriteLine("Index out of range");
        }
        else
        {
            list.RemoveAt(index);
            Console.WriteLine("Card successfully removed");
        }
    }   
    if (input[0] == "Insert")
    {
        int index = int.Parse(input[1]);
        string card = input[2];
        if (IsNotValidIndex(index, list.Count))
        {
            Console.WriteLine("Index out of range");
        }
        else
        {
            if (list.Contains(card))
            {
                Console.WriteLine("Card is already added");
            }
            else
            {
                list.Insert(index, card);
                Console.WriteLine("Card successfully added");
            }
        }
    }
}
Console.WriteLine(string.Join(", " ,list));
static bool IsNotValidIndex(int index, int listCount)
{
    return index < 0 || index >= listCount;
}