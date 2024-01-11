string[] StringArrays = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
List<string> symbols = ExtractSymbols(StringArrays);
Console.WriteLine(string.Join(" ",symbols));

static List<string> ExtractSymbols(string[] stringArrays)
{
    List<string> result = new List<string>();
    for (int i = stringArrays.Length - 1; i >=0; i--)
    {
        string sequence = stringArrays[i];
        string[] array = sequence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        result.AddRange(array);
    }
    return result;
}