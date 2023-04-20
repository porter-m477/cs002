using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quarters = { 1, 2, 3, 4 };
            int[] sales = { 100000, 150000, 200000, 225000 };
            double[] intlMixPct = { .386, .413, .421, .457 };
            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic Formatting
            // Console.WriteLine("{0}", str1);

            // TODO: Formatos especificos numericos
            // formato general es {index[,alignment]:[format]}
            // N (Number), G (General), F (Fixed-point), 
            // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
            // C (Currency)


            // TODO: especifica precision numerica


            // TODO: Formateando con espacios y alineamiento

        }
    }
}
