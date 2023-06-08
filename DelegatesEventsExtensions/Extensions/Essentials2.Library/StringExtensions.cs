using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Library.Extensions
{
    public static class StringExtensions
    {
        public static string Right(string input, int numChars)
        {
            if(string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            //ERROR check length > numChars

            return input.Substring(input.Length - numChars);
        }
    }
}
