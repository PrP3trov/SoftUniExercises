class Article
{
    public Article(string tiltle, string content, string author)
    {
        Tiltle = tiltle;
        Content = content;
        Author = author;
    }

    public string Tiltle { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public override string ToString()
    {
        return $"{Tiltle} - {Content}: {Author}";
    }
}
class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        List<Article> niggas = new List<Article>();
        for (int i = 0; i < count; i++)
        {
            string[] name = Console.ReadLine().Split(", ").ToArray();
            Article nigga = new Article(name[0], name[1], name[2]);
            niggas.Add(nigga);
        }
        foreach (Article nigga in niggas)
        {
            Console.WriteLine(nigga);
        }
    }
}