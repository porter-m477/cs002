using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] { 3, 4, 5 };
            string str = "Cadena de texto";

            // TODO: for loop basico
            // Console.WriteLine("Un for loop basico:");
            // for (int i = 0; i < myVal; i++)
            // {
            //     Console.WriteLine("i es actualmente {0}", i);
            // }

            // Console.WriteLine();

            // TODO: foreach-in loop puede ser utilizado con secuencias
            // Console.WriteLine("Un foreach loop:");
            // foreach (int i in nums)
            // {
            //     Console.WriteLine("i es actualmente {0}", i);
            // }


            // TODO: count the number of o's in the string
            var count = 0;
            foreach (char c in str)
            {
                if (c == 'a')
                {
                    count++;

                }
            }
            Console.WriteLine("resultado de chars {0}", count);

        }
    }
}
