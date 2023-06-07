using System.Collections.Generic;
using System.Linq;
using LibraryByAuthor;
using System;


public class Library
{
    private List<Book> booksByAuthor;
    private List<Book> booksByTitle;

    public Library()
    {
        booksByAuthor = new List<Book>();
        booksByTitle = new List<Book>();
    }

    public void AddBookByAuthor(Book book)
    {
        booksByAuthor.Add(book);
    }

    public void AddBookByTitle(Book book)
    {
        booksByTitle.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return booksByAuthor.Where(b => b.Author == author).ToList();
    }

    public List<Book> SearchByTitle(string title)
    {
        return booksByTitle.Where(b => b.Title == title).ToList();
    }
}

