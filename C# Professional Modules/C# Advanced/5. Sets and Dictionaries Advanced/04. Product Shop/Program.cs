Dictionary<string, Dictionary<string, double>> dictionary = new Dictionary<string, Dictionary<string, double>>();

string end = Console.ReadLine();
while (end != "Revision")
{
    string[] command = end.Split(", ");
    string store = command[0];
    string product = command[1];
    double priceProduct = double.Parse(command[2]);
     
    if (!dictionary.ContainsKey(store))
    {
        dictionary.Add(store, new Dictionary<string, double>());
    }

    if (!dictionary[store].ContainsKey(product))
    {
        dictionary[store].Add(product, 0);
    }

    dictionary[store][product] = priceProduct;

    end = Console.ReadLine();
}
dictionary = dictionary.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
foreach (var (store,products) in dictionary)
{
    Console.WriteLine($"{store}->");

    foreach (var (product,price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}