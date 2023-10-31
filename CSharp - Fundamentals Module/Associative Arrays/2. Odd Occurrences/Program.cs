string[] words = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
var numberOccurrences = new Dictionary<string, int>();
for (int i = 0; i < words.Length; i++)
{
    string currentWord = words[i];
    if (!numberOccurrences.ContainsKey(currentWord))
    {
        numberOccurrences.Add(currentWord, 0);
    }
    numberOccurrences[currentWord]++;
}
foreach(KeyValuePair<string,int> kvp in numberOccurrences)
{
    if (kvp.Value %2 != 0)
    {
        Console.Write($"{kvp.Key} ");
    }
}
