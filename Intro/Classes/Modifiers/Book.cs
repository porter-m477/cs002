using System;

namespace Modifiers
{
    // modifiers controlan como las propiedades y metodos son accesados
    class Book
    {
        // TODO: "public" members y metodos pueden ser accesados por cualquier codigo
        // Nota: esta *NO* es la forma correcta de exponer datos internos
        public string _name;

        // TODO: "protected" members pueden acceder al class y derivadas de de esta
        public string _author;

        // TODO: "private" es el default y puede ser accedida solo atravez de codigo
        // dentro de su misma class
        private int _pagecount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}, {_pagecount} pages";
        }

        // TODO: Member variables pueden ser accesadas via metodos

        public string GetName()
        {
            return _name;
        }
        public void SetName(string s)
        {
            _name = s;
        }
        public void SetAutor(string s)
        {
            _author = s;
        }
        public void SetPages(int p)
        {
            _pagecount = p;
        }

    }
}
