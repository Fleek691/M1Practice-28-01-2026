using System;
using LMS;

namespace LMSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryUtility library = new LibraryUtility();

            // 1️⃣ Add books
            library.AddBook("1984", "George Orwell", "Fiction", 1949);
            library.AddBook("Animal Farm", "George Orwell", "Fiction", 1945);
            library.AddBook("Sapiens", "Yuval Noah Harari", "Non-Fiction", 2011);
            library.AddBook("The Da Vinci Code", "Dan Brown", "Mystery", 2003);

            // 2️⃣ Display total books count
            Console.WriteLine("Total Books: " + library.GetTotalBooksCount());
            Console.WriteLine();

            // 3️⃣ Display books grouped by genre
            Console.WriteLine("Books Grouped By Genre:");
            var groupedBooks = library.GroupBooksByGenre();

            foreach (var genre in groupedBooks)
            {
                Console.WriteLine($"Genre: {genre.Key}");
                foreach (var book in genre.Value)
                {
                    Console.WriteLine($"  - {book.Title} by {book.Author} ({book.PublicationYear})");
                }
                Console.WriteLine();
            }

            // 4️⃣ Search books by author
            Console.WriteLine("Books by George Orwell:");
            var orwellBooks = library.GetBookByAuthor("George Orwell");

            foreach (var book in orwellBooks)
            {
                Console.WriteLine($"- {book.Title} ({book.PublicationYear})");
            }

            Console.ReadLine();
        }
    }
}
