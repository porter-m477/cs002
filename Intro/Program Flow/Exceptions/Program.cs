using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10000;
            int y = 10;
            int result;

            // TODO: try-catch expressions para capturar errores
            try
            {
                if (x > 1000)
                {
                    throw new ArgumentOutOfRangeException("x", "x tiene que ser menor a 1000");
                }
                result = x / y;
                Console.WriteLine("El resultado es: {0}", result);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error de matematicas codigo");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Esta parte siempre se ejecuta");
            }

        }
    }
}
