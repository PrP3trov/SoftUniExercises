namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.IdentityModel.Protocols;
    using System.Globalization;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            // DbInitializer.ResetDatabase(db);

            using var db = new BookShopContext();
            Console.WriteLine(RemoveBooks(db));
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            if(!Enum.TryParse(command, true, out AgeRestriction ageRestriction))
            {
                return String.Empty;
            }

            var titles = context.Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            return string.Join(Environment.NewLine, titles);
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 5000 && b.EditionType == EditionType.Gold)
                .Select(b => new { b.Title, b.BookId })
                .OrderBy(b => b.BookId)
                .ToArray();
            
            return string.Join(Environment.NewLine,books.Select(b => b.Title));

        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    Title = b.Title,
                    Price = b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            return string.Join(Environment.NewLine,books.Select(a => $"{a.Title} - ${a.Price:f2}"));
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year != year)
                .Select(b => new { b.Title, b.BookId })
                .OrderBy(b => b.BookId)
                .ToArray();


            return string.Join(Environment.NewLine, books.Select(b => b.Title));
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] category = input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var books = context.BooksCategories
                .Where(bc => category.Contains(bc.Category.Name.ToLower()))
                .Select(bc => bc.Book.Title)
                .OrderBy(b => b)
                .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime dt = DateTime.ParseExact(date, "dd-MM-yyyy", 
                CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(b => b.ReleaseDate < dt)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}")
                .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors.
                Where(a => a.FirstName.EndsWith(input))
                .Select(a => $"{a.FirstName} {a.LastName}")
                .ToArray()
                .OrderBy(a => a);

            return string.Join(Environment.NewLine,authors);
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            string correctInput = input.ToLower();

            var books = context.Books
                .Where(b => b.Title.ToLower().Contains(correctInput))
                .Select(b => b.Title)
                .OrderBy(b =>b)
                .ToArray();
            
            return string.Join(Environment.NewLine, books);

        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var correctImput = input.ToLower();
            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(correctImput))
                .Select(b => new
                {
                    b.Title,
                    b.Author.FirstName,
                    b.Author.LastName,
                    b.BookId
                })
                .OrderBy(b => b.BookId)
                .ToArray();

            return string.Join(Environment.NewLine, books.Select(b => $"{b.Title} ({b.FirstName} {b.LastName})"));
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var booksCount = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .ToArray()
                .Count();

            return booksCount;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorsBook = context.Authors
                .Select(a => new
                {
                    a.FirstName,
                    a.LastName,
                   Copies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.Copies)
                .ToArray();

            return string.Join(Environment.NewLine,authorsBook.Select(a => $"{a.FirstName} {a.LastName} - {a.Copies}"));
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categoriesByProfit = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Profit = c.CategoryBooks.Sum(cb => cb.Book.Price * cb.Book.Copies)
                })
                .OrderByDescending(c => c.Profit)
                .ThenBy(c => c.Name)
                .ToArray();
;
            return string.Join(Environment.NewLine, categoriesByProfit.Select(a => $"{a.Name} ${a.Profit:f2}"));
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var recentBooksByCategory = context.Categories
                .Select(c => new
                {
                    c.Name,
                    MostRecentBooks = c.CategoryBooks
                        .OrderByDescending(b => b.Book.ReleaseDate)
                        .Take(3)
                        .Select(b => $"{b.Book.Title} ({b.Book.ReleaseDate.Value.Year})")
                }).ToArray()
                .OrderBy(c => c.Name)
                .ToArray();

            var sb = new StringBuilder();

            foreach (var c in recentBooksByCategory)
            {
                sb.AppendLine($"--{c.Name}");
                foreach (var b in c.MostRecentBooks)
                {
                    sb.AppendLine(b);
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
           var books =  context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToArray();

            foreach (var b in books)
            {
                b.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var booksToDelete = context.Books
                .Where(b => b.Copies < 4200)
                .ToArray();

            context.RemoveRange(booksToDelete);
            context.SaveChanges();

            return booksToDelete.Length;
        }
    }

}


