while (true)
{
    string word = Console.ReadLine();
    char[] stringArray = word.ToCharArray();
    Array.Reverse(stringArray);
    string reversed = new string(stringArray);
    if (word == "end")
    {
        break;
    }
    else
    {
        Console.WriteLine($"{word} = {reversed}");
    }
}