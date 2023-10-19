int people = int.Parse(Console.ReadLine());
List<int> lift = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int wagons = lift.Count();
int max = 4;
for (int i = 0; i < wagons; i++)
{
    int space = max - lift[i];
    if (lift[i] < 4)
    {
        people -= space;
        if (people < 0)
        {
            lift[i] = 4- Math.Abs(people);
            Console.WriteLine("The lift has empty spots!");
            Console.WriteLine(string.Join(" ",lift));
            return;
        }
        lift[i] = 4;
    }
}
if (people != 0)
{
    Console.WriteLine($"There isn't enough space! {people} people in a queue!");

}
Console.WriteLine(string.Join(" ", lift));