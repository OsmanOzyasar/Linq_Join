

using Linq_Join;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Authors> authors = new List<Authors>()
            {
                new Authors {Name = "George Orwell", AuthorId = 1},
                new Authors {Name = "Stefan Zweig", AuthorId = 2},
                new Authors {Name = "Haruki Murakami", AuthorId = 3},
            };

            List<Books> books = new List<Books>()
            {
                new Books { Title = "1984", AuthorId = 1, BookId = 1},
                new Books {Title = "Satranç", AuthorId = 2, BookId = 2},
                new Books {Title = "Olağanüstü Bir Gece", AuthorId = 2,BookId = 3},
                new Books {Title = "İmkansızın Şarkısı", AuthorId = 3, BookId = 4}
            };

            var joinedBooks = from book in books
                              join author in authors on book.AuthorId equals author.AuthorId
                              select new
                              {
                                  AuthorName = author.Name,
                                  BookTitle = book.Title
                              };

            foreach (var book in joinedBooks)
            {
                Console.WriteLine($"{book.BookTitle} yazarı -> {book.AuthorName}");
            }
        }
    }
}