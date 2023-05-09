using System;

namespace StringRep
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; }

        public Book(string name, string author, int pages)
        {
            Name = name;
            Author = author;
            PageCount = pages;
        }

        // TODO: el metodo ToString genera una represenacion de string object


        // TODO: ToString puede ser overloaded para producir diferentes tipos de formatos

    }
}