using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples son valores agrupados en C# 7
            (int a, int b) tup1 = (5, 11);
            var tup2 = ("cadena de text", 2.3f);
            var tup3 = ("string1", 1.1f);



            // TODO: los valores dentro del Tuple son movibles
            tup1.b = 20;
            tup2.Item1 = "Cadena nueva";
            tup3.Item2 = 2.2f;
            Console.WriteLine($"{tup1.b}, {tup2.Item1}");
            Console.WriteLine($"{tup3.Item2}");


            // TODO: Functions trabajan con tuples
            (int, int) result = Funcx(4, 12);
            Console.WriteLine($"Suma: {result.Item1}, Multiplicacion:: {result.Item2}");

        }

        // TODO: Functions pueden regresar multiples valores usando tuples

        static (int, int) Funcx(int a, int b)
        {
            return (a + b, a * b);
        }

    }
}
