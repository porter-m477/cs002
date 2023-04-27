using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// documentation: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
        static void Main(string[] args)
        {
            /// <summary>
            /// This property always returns a value &lt; 1.
            /// example of documentation
            /// </summary>
            Console.WriteLine("Hello World!");

        }
    }
}
