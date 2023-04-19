using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 10;
            int result;

            // TODO: try-catch expressions para capturar errores
            result = x / y;
            Console.WriteLine("El resultado es: {0}", result);
        }
    }
}
