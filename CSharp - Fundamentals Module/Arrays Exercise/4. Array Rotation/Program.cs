string[] nums = Console.ReadLine().Split();
int n = int.Parse(Console.ReadLine());
for (int j = 0; j < n; j++)
{
    var lastNum = nums[0];
    for (var i = 0; i < nums.Length - 1; i++)
    {
        nums[i] = nums[i + 1];
    }
    nums[nums.Length - 1] = lastNum;
}
Console.WriteLine("{0}", string.Join(" ", nums));