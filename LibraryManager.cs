// LibraryManager.cs

using System;
using System.Collections.Generic;

public class LibraryManager
{
    private List<Book> books;
    private List<Patron> patrons;

    public LibraryManager()
    {
        books = new List<Book>();
        patrons = new List<Patron>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddPatron(Patron patron)
    {
        patrons.Add(patron);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Library Books:");
        foreach (var book in books)
        {
            book.Display();
        }
    }

    public void DisplayPatrons()
    {
        Console.WriteLine("Library Patrons:");
        foreach (var patron in patrons)
        {
            patron.Display();
        }
    }
}
