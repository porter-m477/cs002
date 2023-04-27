using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 59;

            // TODO: if-else 
            if (theVal == 50)
            {
                Console.WriteLine("el valor es 50");
            }
            else if (theVal >= 51 && theVal <= 60)
            {
                Console.WriteLine("el valor esta entre 51 y 60");
            }
            else
            {
                Console.WriteLine("el valor no es 50");
            }


            // -----------------------



            // TODO: Using the ternary operator ?:


            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: metodo abreviado usando ?:
            Console.WriteLine(theVal < 50 ? "el valor es menor" : "el valor es mayor a 50");

        }
    }
}
