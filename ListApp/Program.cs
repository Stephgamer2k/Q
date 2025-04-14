namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of objects syntax:
            //List<type> name = new List <Book>{};
            List<Book> books = new List<Book>
            {
                new Book("One Piece", "Oda", "Manga"),
                new Book("Harry Potter", "J.K. Rowling", "Fantasy"),
                new Book("Solo", "The Goat", "Manga"),
                new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy"),
                new Book("Attack on Titan", "Hajime Isayama", "Manga"),
                new Book("Death Note", "Tsugumi Ohba", "Manga")
            };
            //Console.WriteLine("1. Search by Title\n 2. Search by Author\n 3. Search by Genre\n 4. Exit");
            //string choice = Console.ReadLine();
            while(true)
            {
                Console.WriteLine("1. Search by Title\n 2. Search by Author\n 3. Search by Genre\n 4. Exit\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the title of the book to search: ");
                        string searchTitle = Console.ReadLine();

                        Book foundBook = books.Find(book => book.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase));

                        if (foundBook != null)
                        {
                            Console.WriteLine($"Book found: {foundBook.Title} by {foundBook.Author}\n");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the author of the book you want to search for: ");
                        string searchAuthor = Console.ReadLine();

                        List<Book> authorResults = books.FindAll(book => book.Author.Contains(searchAuthor, StringComparison.OrdinalIgnoreCase));

                        if(searchAuthor != null)
                        {
                            Console.WriteLine($"Books Found by {searchAuthor}:");
                            foreach(var book in authorResults)
                            {
                                Console.WriteLine($"{book.Title} by {book.Author}\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No books found for {searchAuthor}");
                        }
                            break;
                    case "3":
                        Console.WriteLine("Enter the genre for the books you are searching for: ");
                        string searchGenre = Console.ReadLine();

                        List<Book> genreReaults = books.FindAll(book => book.Genre.Contains(searchGenre, StringComparison.OrdinalIgnoreCase));

                        if(searchGenre != null)
                        {
                            Console.WriteLine($"Books Found for {searchGenre}");
                            foreach(var book in genreReaults)
                            {
                                Console.WriteLine($"Title: {book.Title}, Genre: {book.Genre}\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No books found for the genre {searchGenre}");
                        }
                            break;
                    case "4":
                        Console.WriteLine("Exiting application....");
                        return;
                        
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;


                }


            }
            
        }
    }
}
/*SUMMARY*/
 
//The .Find method return the first isntance of what matches what you are looking for
//The .FindAll method return everything that has the keyword you searched for