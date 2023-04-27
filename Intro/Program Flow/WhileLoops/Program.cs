using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";

            // TODO: while loop se ejecuta mientras la condicion sea true
            // Console.WriteLine("Basic while() loop:");
            while (inputStr != "salir")
            {
                inputStr = Console.ReadLine();
                Console.WriteLine("entraste: {0}", inputStr);
            }

            // Console.WriteLine();

            // TODO: do-while loop siempre se ejecuta por lo menos una vez
            // Console.WriteLine("do-while() loop:");
            // do
            // {
            //     inputStr = Console.ReadLine();
            //     Console.WriteLine("escribiste: {0}", inputStr);

            // } while (inputStr != "salir");

            // Console.WriteLine();
        }
    }
}
