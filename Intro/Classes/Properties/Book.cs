using System;

namespace Properties
{
    // classes tienen nobres unicos dentro de los namespace
    class Book
    {
        // classes con variables de instancia
        private string _name;
        private string _author;
        private int _pagecount;

        // classes con uno o mas constructores
        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // TODO: usar Properties para implementar acceso a datos internos

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        // TODO: Forma abreviada de escribirlos utilizando el operador => 
        // para crear propiedades "expression-bodied" 
        public string Autor
        {
            get => _author;
            set => _author = value;
        }
        public int Paginas
        {
            get => _pagecount;
            set => _pagecount = value;
        }


    }
}
