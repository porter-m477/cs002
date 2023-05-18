using System;

namespace Defining
{
    // clases necesitan nombres unicos dentro del namespace
    public class Book
    {
        // TODO: classes tienen variables member, or "fields" to hold data
        string _name;
        string _autor;
        int _pagecount;


        // TODO: classes tinen uno o mas constructores
        public Book(string name, string autor, int pages)
        {
            _name = name;
            _autor = autor;
            _pagecount = pages;
        }


        // TODO: metodos usados para operar sobre class y data
        public string GetDesc()
        {
            return $"{_name} por {_autor}";
        }

    }
}
