using System;

// Link documentation https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: las classes en C# heredan del Object, lo que quiere decir
            // que cada clase hereda el método ToString() 
            int x = 1000;
            Console.WriteLine(x.ToString());


            // TODO: si no hace override al metodo, el comportamiento por defecto solo imprime
            // el nombre de la class y el namespace
            // object a = new object();
            // Console.WriteLine(a.ToString());


            // TODO: usar el metodo ToString en el Book class
            Book b1 = new Book("Titulo Libro", "Autor Desconocido", 825);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1);

            Console.WriteLine(b1.ToString('B'));
            Console.WriteLine(b1.ToString('F'));

        }
    }
}
