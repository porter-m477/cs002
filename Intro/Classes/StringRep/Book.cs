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
        public override string ToString()
        {
            return $"Libro: {Name} por {Author}";
        }


        // TODO: ToString puede ser overloaded para producir diferentes tipos de formatos
        public string ToString(char format)
        {
            if (format == 'B')
            {
                return $"Libro: {Name}:{Author}";
            }
            if (format == 'F')
            {
                return $"Libro: {Name} by {Author} tiene {PageCount} paginas";
            }
            return ToString();
        }

    }
}