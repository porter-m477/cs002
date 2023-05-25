using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un nuevo Book object
            Book b1 = new Book("Libro 1", "Autor A", 825);

            // Acceder a un par de propiedades
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Paginas);
            Console.WriteLine(b1.Autor);

        }
    }
}
