// Patron.cs

using System;

public class Patron
{
    public string Name { get; set; }
    public string MemberID { get; set; }

    public Patron(string name, string memberID)
    {
        Name = name;
        MemberID = memberID;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Member ID: {MemberID}");
    }
}
