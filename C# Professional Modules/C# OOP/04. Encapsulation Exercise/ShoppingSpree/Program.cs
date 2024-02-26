namespace ShoppingSpree
{
    public class Program
    {
        static void Main()
        {
            char[] delims = new[] { ';', '=' };
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            var peopleData = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);
            var productData = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < peopleData.Length; i+= 2)
                {
                    people.Add(new Person(peopleData[i], int.Parse(peopleData[i + 1])));
                }
                for (int i = 0; i < productData.Length; i+=2)
                {
                    products.Add(new Product(productData[i], int.Parse(productData[i+1])));
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            string command;
            while((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var person = people.Find(p => p.Name == tokens[0]);
                var product = products.Find(p => p.Name == tokens[1]);
                try
                {
                    if (person != null && product != null)
                    {
                        person.AddProduct(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (person.Bag.Count == 0)
                {
                    Console.Write("Nothing bought");
                    break;
                }
                Console.WriteLine(string.Join(", ",person.Bag.Select(i => i.Name)));
            }
        }
    }
}