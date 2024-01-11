using System;
using System.Xml.Serialization;

class Advertisemet
{
    public string[] Phrases { get; set; }
    public string[] Events { get; set; }
    public string[] Authors { get; set; }
    public string[] Cities { get; set; }
}
class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        Advertisemet nigga = new Advertisemet();
        nigga.Phrases = new []
        {
            "Excellent product.", 
            "Such a great product.", 
            "I always use that product.", 
            "Best product of its category.", 
            "Exceptional product.", 
            "I can't live without this product."
        };
        nigga.Events = new string[]
        {
            "Now I feel good.", 
            "I have succeeded with this product.", 
            "Makes miracles. I am happy of the results!", 
            "I cannot believe but now I feel awesome.", 
            "Try it yourself, I am very satisfied.", 
            "I feel great!"
        };
        nigga.Authors = new string[]
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };
        nigga.Cities = new string[] { 
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" 
        };
        
        Random r = new Random();
        for (int i = 0; i < count; i++)
        {
            int randomIndex = r.Next(nigga.Phrases.Length);
            string phrase = nigga.Phrases[randomIndex];

            randomIndex = r.Next(nigga.Events.Length);
            string events = nigga.Events[randomIndex];

            randomIndex = r.Next(nigga.Authors.Length);
            string author = nigga.Authors[randomIndex];

            randomIndex = r.Next(nigga.Cities.Length);
            string city = nigga.Cities[randomIndex];
            Console.WriteLine($"{phrase} {events} {author} – {city}.");
        }

    }
}
