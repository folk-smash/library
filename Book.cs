// Book.cs

using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
    }
}
