int n = int.Parse(Console.ReadLine());

Dictionary<string,List<decimal>> grades = new Dictionary<string,List<decimal>>();
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();
    string name = command[0];
    decimal grade = decimal.Parse(command[1]);

    if (!grades.ContainsKey(name))
    {
        grades[name] = new List<decimal>();
    }

    grades[name].Add(grade);
}

foreach (var student in grades)
{
    Console.Write($"{student.Key} -> ");

    foreach (var a in student.Value)
    {
        Console.Write($"{a:F2} ");
    }
    Console.Write($"(avg: {student.Value.Average():F2})");
    Console.WriteLine();
}