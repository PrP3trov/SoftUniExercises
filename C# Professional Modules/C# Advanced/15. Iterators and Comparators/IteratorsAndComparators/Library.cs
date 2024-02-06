using System.Collections;
using System.Security.Principal;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly List<Book> books;
        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books.OrderBy(b => b, new BookComparator()).ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex = -1;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
