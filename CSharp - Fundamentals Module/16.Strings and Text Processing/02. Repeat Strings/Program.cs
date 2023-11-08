string[] words = Console.ReadLine().Split().ToArray();
string result = "";
for (int i = 0; i < words.Length; i++)
{
	for (int j = 0; j < words[i].Length; j++)
	{
        result += words[i];
    }
    
}
Console.WriteLine(result);