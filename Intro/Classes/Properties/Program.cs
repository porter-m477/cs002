using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un nuevo Book object
            Book b1 = new Book("Libro Ficción", "Autor Intern", 825);

            // Acceder a un par de propiedades
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            // Setear el ISBN y precio
            b1.ISBN = "100140447938";
            b1.Price = 24.95m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            // Cambiar el nombre y page_count
            b1.Name = "Libro Literatura";
            b1.Pagecount = 652;
            Console.WriteLine(b1.Description);
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Pagecount);
        }
    }
}
