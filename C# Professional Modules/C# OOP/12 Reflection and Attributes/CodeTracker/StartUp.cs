namespace AuthorProblem
{
    [Author("Victor")]
    public class StartUp
    {
        [Author("Kekura")]
        static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();

        }
    }
}