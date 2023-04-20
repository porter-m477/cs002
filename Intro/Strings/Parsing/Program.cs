using System;
using System.Globalization;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            // Parse es la funcion que trata de convertir un string en numero
            // pueden aparecer excepciones, necesitamos manejarlas
            int targetNum = 0;
            try
            {
                // TODO: Intentar con data type integer


                // TODO: Usar Parse con float number


                // TODO: Usar Parse con thousands marker


                // TODO: Usar Parse con thousands marker y decimal


                // TODO: Usar con bool


                // TODO: Usar floating point numbers

            }
            catch
            {
                Console.Write("Conversion failed");
            }

            // TODO: El TryParse es similar pero maneja exceptions por nosotros
            bool succeeded = false;

            if (succeeded)
            {
                Console.WriteLine($"{targetNum}");
            }
        }
    }
}
