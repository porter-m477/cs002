using System;
using System.Text;

// Documentacion: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.replace?view=net-7.0

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = { "goats", "cats", "pigs" };

            // TODO: create a StringBuilder
            StringBuilder sb = new StringBuilder("String inicial.", 200);


            // TODO: print some basic stats about the StringBuilder
            Console.WriteLine($"Capacidad: {sb.Capacity}; Longitud: {sb.Length}");


            // TODO: Add some strings to the builder using Append
            sb.Append("Texto random ");
            sb.Append("Texto secundario ");


            // TODO: AppendLine can append a line ending
            sb.AppendLine();


            // TODO: AppendFormat can be used to append formatted strings
            sb.AppendFormat("Contador estatus {0}", jumpCount);
            sb.AppendLine();


            // TODO: AppendJoin can iterate over a set of values
            sb.Append("Estatus nuevo ");
            sb.AppendJoin(',', animals);


            // TODO: Modify the content using Replace
            sb.Replace("cat", "gato");
            Console.WriteLine($"replace cat {sb.Replace("cat", "gato")}");


            // TODO: Insert content at any index
            sb.Insert(0, "A insertarse ");


            // TODO: Convert to a single string
            Console.WriteLine($"Capacidad {sb.Capacity}; Longitud: {sb.Length}");
            Console.WriteLine(sb.ToString());

        }
    }
}
