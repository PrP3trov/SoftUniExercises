using System.Text;

string input = Console.ReadLine();
string result = ProcessExplasions(input);
Console.WriteLine(result);

string ProcessExplasions(string? input)
{
   StringBuilder resultBuilder = new StringBuilder();
    int strength = 0;
	for (int i = 0; i < input.Length; i++)
	{
		if (input[i] == '>')
		{
			strength += int.Parse(input[i + 1].ToString());
			resultBuilder.Append(input[i]);
		}
		else if (strength == 0)
		{
			resultBuilder.Append(input[i]);
		}
		else
		{
			strength--;
		}
	}
	return resultBuilder.ToString();
}