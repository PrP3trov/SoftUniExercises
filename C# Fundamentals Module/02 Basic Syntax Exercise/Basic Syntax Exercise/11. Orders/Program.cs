int orders = int.Parse(Console.ReadLine());
double sum = 0;
double total = 0;
for (int i = 0; i < orders; i++)
{
    double priceCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsules = int.Parse(Console.ReadLine());
    sum = days * capsules * priceCapsule;
    Console.WriteLine($"The price for the coffee is: ${sum:F2}");
    total += sum;
}
Console.WriteLine($"Total: ${total:F2}");