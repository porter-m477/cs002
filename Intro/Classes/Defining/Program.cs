using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Crear new object instances usando el "new" operator
            Book b1 = new Book("Libro name", "autor a", 400);
            Book b2 = new Book("Libro 2", "autor unknown", 800);


            // TODO: Llamar un method en el object
            Console.WriteLine(b1.GetDesc());
            Console.WriteLine(b2.GetDesc());


            // TODO: setear una de las propiedades -- 
            // resultado error
            b1._name = "autor q";

        }
    }
}
