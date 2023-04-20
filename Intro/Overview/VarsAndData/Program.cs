using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de variables y como se declaran
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Tipo de variable string, a collection of characters
            string str = "a string";

            // Declaracion implicita de variable
            var x = 10;
            var z = "Hello!";

            // Declaracion de un array de vals
            int[] vals = new int[5];
            string[] strs = { "uno", "dos", "tres" };

            // Print todos los vals en forma de string
            // Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i, c, b, str, f, d, x, z);


            // "null" significa "no value"
            // object obj = null;
            // Console.WriteLine(obj);

            // Implicit conversion between types
            long bignum;
            bignum = i;

            // Explicit conversions
            float i_to_f = (float)i;
            Console.WriteLine("{0}", i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine("{0}", f_to_i);

        }
    }
}
