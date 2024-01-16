List<int> largestThreeNum = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();
Console.WriteLine(string.Join(" ",largestThreeNum));