// Program.cs

class Program
{
    static void Main()
    {
        // Create books
        var book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-3-16-148410-0");
        var book2 = new Book("To Kill a Mockingbird", "Harper Lee", "978-0-06-112008-4");

        // Create patrons
        var patron1 = new Patron("Alice", "P001");
        var patron2 = new Patron("Bob", "P002");

        // Create a library manager
        var libraryManager = new LibraryManager();

        // Add books and patrons to the library manager
        libraryManager.AddBook(book1);
        libraryManager.AddBook(book2);
        libraryManager.AddPatron(patron1);
        libraryManager.AddPatron(patron2);

        // Display library information
        libraryManager.DisplayBooks();
        libraryManager.DisplayPatrons();
    }
}
