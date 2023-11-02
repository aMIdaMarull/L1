namespace Lab1
{
    internal class Program
    {

        private static (List<Author>, List<PublishingHouse>, List<Book>) Init()
        {
            var author1 = new Author(1, "John", "Doe");
            var author2 = new Author(2, "Jane", "Smith");
            var author3 = new Author(3, "Michael", "Johnson");
            var author4 = new Author(4, "Emily", "Brown");
            var author5 = new Author(5, "David", "Williams");
            var author6 = new Author(6, "Olivia", "Davis");
            var author7 = new Author(7, "James", "Miller");

            var authors = new List<Author>() { author1, author2, author3, author4, author5, author6, author7 };

            var publisher1 = new PublishingHouse(1, "Horizon Press");
            var publisher2 = new PublishingHouse(2, "Noble Publications");
            var publisher3 = new PublishingHouse(3, "Starlight Books");
            var publisher4 = new PublishingHouse(4, "Grand Central Publishing");
            var publisher5 = new PublishingHouse(5, "Beacon House Books");
            var publisher6 = new PublishingHouse(6, "Moonstone Publishers");
            var publisher7 = new PublishingHouse(7, "Sunflower Press");

            var publishers = new List<PublishingHouse>() { publisher1, publisher2, publisher3, publisher4,
                publisher5, publisher6, publisher7 };

            var book1 = new Book(1, "The Lost World", 19.99, new List<Author> { author1 }, new DateOnly(1954, 1, 15), publisher1, new List<string> { "ABC12345", "XYZ78900" });
            var book2 = new Book(2, "A Tale of Two Cities", 24.95, new List<Author> { author2 }, new DateOnly(1965, 4, 30), publisher2, new List<string> { "DEF45678" });
            var book3 = new Book(3, "The Catcher in the Rye", 14.50, new List<Author> { author3 }, new DateOnly(1978, 8, 10), publisher3, new List<string> { "GHI12345", "OPQ67890" });
            var book4 = new Book(4, "To Kill a Mockingbird", 29.99, new List<Author> { author4 }, new DateOnly(1983, 12, 5), publisher4, new List<string> { "JKL23456", "RST34567", "UVW45678" });
            var book5 = new Book(5, "Pride and Prejudice", 9.99, new List<Author> { author5 }, new DateOnly(1992, 6, 20), publisher5, new List<string> { "XYZ56789" });
            var book6 = new Book(6, "The Great Gatsby", 39.95, new List<Author> { author6 }, new DateOnly(2005, 9, 8), publisher6, new List<string> { "ABC23456", "XYZ78901" });
            var book7 = new Book(7, "Moby-Dick", 12.99, new List<Author> { author7 }, new DateOnly(2010, 3, 17), publisher7, new List<string> { "DEF34567", "LMN89012" });
            var book8 = new Book(8, "Harry Potter", 17.50, new List<Author> { author1, author5 }, new DateOnly(2015, 7, 22), publisher1, new List<string> { "GHI45678", "OPQ90123" });
            var book9 = new Book(9, "The Hobbit", 22.75, new List<Author> { author3, author4 }, new DateOnly(2020, 11, 12), publisher2, new List<string> { "JKL56789", "RST01234" });
            var book10 = new Book(10, "1984", 8.49, new List<Author> { author2, author7 }, new DateOnly(2023, 2, 28), publisher3, new List<string> { "UVW67890", "XYZ01234" });
            var book11 = new Book(11, "The Da Vinci Code", 15.99, new List<Author> { author1 }, new DateOnly(2003, 3, 18), publisher4, new List<string> { "ABC98765" });
            var book12 = new Book(12, "Brave New World", 12.75, new List<Author> { author5 }, new DateOnly(1932, 7, 14), publisher5, new List<string> { "XYZ34567" });
            var book13 = new Book(13, "The Lord of the Rings", 29.99, new List<Author> { author6 }, new DateOnly(1954, 7, 29), publisher6, new List<string> { "DEF23456", "LMN78901" });
            var book14 = new Book(14, "Crime and Punishment", 18.49, new List<Author> { author6, author1 }, new DateOnly(1866, 1, 14), publisher7, new List<string> { "GHI67890" });
            var book15 = new Book(15, "The Shining", 21.99, new List<Author> { author5, author2 }, new DateOnly(1977, 1, 28), publisher1, new List<string> { "OPQ23456" });
            var book16 = new Book(16, "One Hundred Years of Solitude", 16.95, new List<Author> { author3, author4 }, new DateOnly(1967, 5, 30), publisher2, new List<string> { "RST67890" });
            var book17 = new Book(17, "The Odyssey", 13.75, new List<Author> { author1, author7, author5 }, new DateOnly(2008, 4, 23), publisher3, new List<string> { "UVW12345" });
            var book18 = new Book(18, "The Road", 11.99, new List<Author> { author6, author2, author4 }, new DateOnly(2006, 9, 26), publisher4, new List<string> { "JKL90123" });
            var book19 = new Book(19, "The Hunger Games", 14.50, new List<Author> { author3 }, new DateOnly(2008, 9, 14), publisher5, new List<string> { "GHI56789" });
            var book20 = new Book(20, "The Alchemist", 12.99, new List<Author> { author5 }, new DateOnly(1988, 8, 15), publisher6, new List<string> { "XYZ01234" });

            var books = new List<Book>() { book1, book2, book3, book4, book5, book6, book7, book8, book9, book10,
            book11, book12, book13, book14, book15, book16, book17, book18, book19, book20 };

            return (authors, publishers, books);
        }

        static void Main(string[] args)
        {
            var authors = new List<Author>();
            var publishers = new List<PublishingHouse>();
            var books = new List<Book>();

            (authors, publishers, books) = Init();

            Console.WriteLine("1) - display all books");
            Console.WriteLine();

            var q1 = from x in books
                     select x;

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("2) - display all authors whose name begins with the letter J");
            Console.WriteLine();

            var q2 = from a in authors
                     where a.FirstName.StartsWith('J')
                     select a.FirstName + " " + a.LastName;

            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            Console.WriteLine("3) - display all books published by Noble Publications, ordered by price descending");
            Console.WriteLine();

            var q3 = from b in books
                     where b.Publisher.Name == "Noble Publications"
                     orderby b.Price descending
                     select b;

            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("4) - display count of books  by author's id");
            Console.WriteLine();

            var q4 = from book in books
                     from author in book.Authors
                     group book by author.Id into authorGroup
                     select new
                     {
                         AuthorId = authorGroup.Key,
                         BookCount = authorGroup.Count()
                     };

            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            Console.WriteLine("5) - display book count for each publisher ");
            Console.WriteLine();

            var q5 = from book in books
                     join pb in publishers on book.Publisher.Id equals pb.Id
                     group book by new { pb.Id, pb.Name } into publisherGroup
                     select new
                     {
                         Publisher = publisherGroup.Key.Name,
                         BookCount = publisherGroup.Count()
                     };

            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("6) - list all books published before 1980, ordered by publication date ");
            Console.WriteLine();

            var q6 = books.Where(b => b.PublicationDate.Year < 1980).OrderBy(b => b.PublicationDate)
                .Select(b => "Title: " + b.Title.PadRight(32) + "Published: " + b.PublicationDate.ToString().PadRight(45));

            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("7) - display number of copies for each book published by Horizon Press");
            Console.WriteLine();

            var q7 = books.Where(b => b.Publisher.Name == "Horizon Press")
                .Select(b => "Title: " + b.Title + ", Count: " + b.InventoryNumbers.Count);

            foreach (var item in q7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("8) - display books that have more than 1 author ordered by title");
            Console.WriteLine();

            var q8 = books.Where(b => b.Authors.Count > 1).OrderBy(b => b.Title)
                .Select(b => "Title: " + b.Title.PadRight(32) + "number of authors: " + b.Authors.Count.ToString().PadRight(20));

            foreach (var item in q8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("9) - display average book price for each author");
            Console.WriteLine();

            var q9 = from book in books
                     from author in book.Authors
                     group book by new { author.Id, author.FirstName, author.LastName } into authorGroup
                     select new
                     {
                         AuthorId = authorGroup.Key.Id,
                         AuthorName = $"{authorGroup.Key.FirstName} {authorGroup.Key.LastName}",
                         AverageBookPrice = authorGroup.Average(book => book.Price)
                     };

            foreach (var item in q9)
            {
                Console.WriteLine($"Author ID: {item.AuthorId}, Author Name: {item.AuthorName}, " +
                    $"Average Book Price: {item.AverageBookPrice:F3}");
            }
            Console.WriteLine();

            Console.WriteLine("10) - display books with Inventory number containing 90");
            Console.WriteLine();

            var q10 = books.Where(x => x.InventoryNumbers.Any(y => y.Contains("90"))).OrderBy(x => x.Title);

            foreach (var item in q10)
            {
                Console.WriteLine(item);
                foreach (var inv in item.InventoryNumbers)
                {
                    Console.WriteLine(inv);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("11) - display all authors ordered by name's first letter then by surname's first letter");
            Console.WriteLine();

            var q11 = authors.OrderBy(x => x.FirstName.FirstOrDefault()).ThenBy(x => x.LastName.FirstOrDefault())
                .Select(x => x.FirstName.PadRight(7) + " " + x.LastName);

            foreach (var item in q11)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("12) - display sum of book prices for each publisher");
            Console.WriteLine();

            var q12 = books.GroupBy(x => x.Publisher.Id).Select(g => new
            {
                Publisher = g.First().Publisher.Name,
                total = Math.Round(g.Sum(b => b.Price), 2)
            });

            foreach (var item in q12)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("13) - display all books with author's name starts on J");
            Console.WriteLine();

            var q13 = books.Where(x => x.Authors.Any(y => y.FirstName.StartsWith("J"))).OrderBy(x => x.Title);

            foreach (var item in q13)
            {
                Console.WriteLine(item);
                Console.WriteLine("Authors: ");
                foreach (var auth in item.Authors)
                {
                    Console.WriteLine(auth.FirstName + " " + auth.LastName);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("14) - display inventory numbers of all books in library");
            Console.WriteLine();

            var q14 = books.SelectMany(x => x.InventoryNumbers).OrderBy(y => y).ToList();

            foreach (var item in q14)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("15) - display books published in the last 20 years order by publication date");
            Console.WriteLine();

            var q15 = books.Where(x => x.PublicationDate > DateOnly.FromDateTime(DateTime.Now.AddYears(-20)))
                .OrderBy(x => x.PublicationDate);

            foreach (var item in q15)
            {
                Console.WriteLine("Title: " + item.Title.PadRight(20) + 
                    " Date: " + item.PublicationDate.ToString().PadRight(40));
            }
            Console.WriteLine();

            Console.WriteLine("16) - display most expensive book");
            Console.WriteLine();

            var q16 = books.OrderByDescending(x => x.Price).FirstOrDefault();

            Console.WriteLine(q16);
            Console.WriteLine();

            Console.WriteLine("17) - display number of joint books for each author ");
            Console.WriteLine();

            var q17 = books
                .SelectMany(book => book.Authors)
                .Distinct()
                .Select(author => new
                {
                    AuthorName = $"{author.FirstName} {author.LastName}",
                    CollaborationCount = books
                        .Count(book => book.Authors.Any(a => a.Id == author.Id) && book.Authors.Count > 1)
                });

            foreach (var authorInfo in q17)
            {
                Console.WriteLine($"Author: {authorInfo.AuthorName.PadRight(20)} " +
                    $"Collaboration Count: {authorInfo.CollaborationCount.ToString().PadRight(20)}");
            }
            Console.WriteLine();


            Console.WriteLine("18) - display last publication date for each author ");
            Console.WriteLine();

            var q18 = books
                .SelectMany(book => book.Authors)
                .Distinct()
                .Select(author => new
                {
                    AuthorName = $"{author.FirstName} {author.LastName}",
                    LastPublicationDate = books
                            .Where(book => book.Authors.Any(a => a.Id == author.Id))
                            .Max(book => book.PublicationDate)
                });

            foreach (var item in q18)
            {
                Console.WriteLine($"Author: {item.AuthorName.PadRight(20)} " +
                    $"Last Publication Date: {item.LastPublicationDate.ToString().PadRight(20)}");
            }
            Console.WriteLine();

            Console.WriteLine("19) - display publisher with highest average book price");
            Console.WriteLine();

            var q19 = books
                .GroupBy(x => x.Publisher.Id)
                .Select(g => new
                {
                    PublisherId = g.Key,
                    PublisherName = g.First().Publisher.Name,
                    AveragePrice = g.Average(x => x.Price)
                })
                .OrderByDescending(p => p.AveragePrice)
                .FirstOrDefault();

            Console.WriteLine($"Publisher ID: {q19.PublisherId}");
            Console.WriteLine($"Publisher Name: {q19.PublisherName}");
            Console.WriteLine($"Average Price: {q19.AveragePrice:F2}");

            Console.WriteLine();

            Console.WriteLine("20) - display books that are in the library only in 1 copy, ordered by title");
            Console.WriteLine();

            var q20 = books.Where(x => x.InventoryNumbers.Count == 1).OrderBy(x => x.Title);

            foreach (var item in q20)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }
}