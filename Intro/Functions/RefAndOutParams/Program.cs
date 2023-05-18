using System;

namespace RefAndOutParams
{
    class Program
    {
        // TODO: El valor de los argumentos no puede ser modificado por la funcion
        // porque estos son una copia del valor original
        static void TestFunc1(int arg1)
        {
            arg1 += 15;
            Console.WriteLine($"{arg1}");
        }

        // TODO: Argumentos pasados como reference pueden ser modificados
        // por la funcion y executados
        static void TestFunc2(ref int arg1)
        {
            arg1 += 15;
            Console.WriteLine($"{arg1}");
        }


        // TODO: El "out" keyword significa que el parametro regresa un valor
        // usado para suplir de data a la misma funcion

        static void Func3(int arg1, int arg2, out int sum, out int product)
        {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }

        static void Main(string[] args)
        {
            int val1 = 8;
            int val2 = 20;

            // Function no modifican argumentos normalmente
            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            // TODO: Usando el "ref" keyword, argumentos pueden ser pasados por referencia
            // lo que permite a la funcion modificarlos
            TestFunc2(ref val1);
            Console.WriteLine($"{val1}");


            // TODO: El "out" keyword puede ser usado para indicar que un argumento
            // regresa un valor y no que es un input
            int a, b;
            Func3(val1, val2, out a, out b);
            Console.WriteLine($"{a}, {b}");


        }
    }
}
