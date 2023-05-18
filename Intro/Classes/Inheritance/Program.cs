using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear records
            Book b1 = new Book("Titulo", "Autor", 825, 39.95m);
            Magazine m1 = new Magazine("Revista", "Time NY", 75, 4.95m);

            Console.WriteLine($"{b1.Name}, {b1.Author}");
            Console.WriteLine($"{m1.Name}, {m1.Publisher}");

            // Logica de validacion para prevenir nombres en blanco
            // b1.Name = "";

            // Call the override functions
            Console.WriteLine(b1.GetDescripcion());
            Console.WriteLine(b1.Price);
            Console.WriteLine(m1.GetDescripcion());
            Console.WriteLine(m1.Price);
        }
    }
}
