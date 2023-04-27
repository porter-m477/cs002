using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de strings para los ejercicios
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "This is a string";
            string[] strs = { "one", "two", "three", "four" };

            // TODO: Propiedad Length 
            Console.WriteLine(str1.Length);


            // TODO: Acceder a characters individuales
            Console.WriteLine(str1[14]);


            // TODO: recorre un string como si fuese una secuencia
            foreach (char c in str1)
            {
                Console.Write(c);
                if (c == 'b')
                {
                    Console.WriteLine();
                    break;
                }
            }

            // TODO: Concatenacion de un string    
            outstr = String.Concat(strs);
            Console.WriteLine(outstr);


            // TODO: Uniendo strings con Join
            outstr = String.Join('.', strs);
            Console.WriteLine(outstr);

            outstr = String.Join("---", strs);
            Console.WriteLine(outstr);


            // TODO: Comparacion entre strings
            // Comparacion entre orden de los caracteres
            int result = String.Compare(str2, "THIS is a STRING");
            Console.WriteLine(result);

            // TODO: Equals retorna un Boolean
            bool equals = str2.Equals(str3);
            Console.WriteLine(equals);


            // TODO: String index, search y replace
            // https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0
            Console.WriteLine(str1.IndexOf('e'));
            Console.WriteLine(str1.IndexOf("brown"));

            Console.WriteLine(str1.LastIndexOf('e'));
            Console.WriteLine(str1.LastIndexOf("the"));

            outstr = str1.Replace("brown", "green");
            Console.WriteLine(outstr);
            Console.WriteLine(outstr.IndexOf("brown"));

        }
    }
}
