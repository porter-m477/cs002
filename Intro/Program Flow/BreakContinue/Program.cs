using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };

            Console.WriteLine("Como usar break y continue :");
            foreach (int val in values)
            {
                // TODO: el continue statement se salta el resto del loop 
                // hacia la siguiente iteracion (siesque hay una siguiente)
                if (val >= 20 && val <= 30)
                {
                    continue;
                }


                // print
                Console.WriteLine($"val es {val}");

                // TODO: el break statement detiene el loop y sale
                // if (val >= 40)
                // {
                //     break;
                // }

            }
        }
    }
}
