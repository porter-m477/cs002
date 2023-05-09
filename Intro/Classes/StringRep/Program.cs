using System;

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: las classes en C# heredan del Object, lo que quiere decir
            // que cada clase hereda el metodo ToString() 


            // TODO: si no hace override al metodo, el comportamiento por defecto solo imprime
            // el nombre de la class y el namespace


            // TODO: usar el metodo ToString en el Book class
            Book b1 = new Book("Titulo Libro", "Autor Desconocido", 825);

        }
    }
}
