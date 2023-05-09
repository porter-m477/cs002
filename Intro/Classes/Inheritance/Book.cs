using System;

namespace Inheritance
{
    // TODO: Declarar "Book" como subclass de Publication
    class Book
    {
        private string _author;
        private int _pagecount;
        private decimal _price;

        // base() keyword usada para inicializar el base class
        public Book(string name, string author, int pagecount, decimal price)
        {
            _author = author;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        // TODO: override keyword usada para sobrepasar un base class method

    }
}