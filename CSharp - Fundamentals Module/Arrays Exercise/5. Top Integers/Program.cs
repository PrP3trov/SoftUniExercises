int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < inputArr.Length; i++)
{
    bool isItBigger = true;
    for (int j = i + 1; j < inputArr.Length; j++)
    {
        if (inputArr[i] <= inputArr[j])
        {
            isItBigger = false;
        }
    }

    if (isItBigger)
    {
        Console.Write(inputArr[i] + " ");
    }
}