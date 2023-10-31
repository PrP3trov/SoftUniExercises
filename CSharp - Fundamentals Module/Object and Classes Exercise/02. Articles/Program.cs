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
    public void Edit(string newContent)
    {
        Content = newContent;
    }
    public void ChngeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }
    public void Rename(string newTiltle)
    {
        Tiltle = newTiltle;
    }
    public override string ToString()
    {
        return $"{Tiltle} - {Content}: {Author}";
    }
}
class Program 
{
    static void Main()
    {
        string[] name = Console.ReadLine().Split(", ").ToArray();
        Article nigga = new Article(name[0], name[1], name[2]);
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] command = Console.ReadLine().Split(": ");
            switch (command[0])
            {
                case "Edit":
                    nigga.Edit(command[1]);
                break;
                case "ChangeAuthor":
                    nigga.ChngeAuthor(command[1]);
                    break;
                case "Rename":
                    nigga.Rename(command[1]);
                    break;
            }
        }
        Console.WriteLine(nigga);

    }
}