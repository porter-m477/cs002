using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 10;

            // TODO: The switch statement
            switch (theVal)
            {
                case 50:
                    Console.WriteLine("el valor es 50");
                    break;
                case 51:
                    Console.WriteLine("el valor es 51");
                    break;
                case 52:
                case 53:
                case 54:
                case 55:
                    Console.WriteLine("el valor esta entre 52 - 55");
                    break;
                default:
                    Console.WriteLine("el valor esta fuera de rango");
                    break;
            }

        }
    }
}
