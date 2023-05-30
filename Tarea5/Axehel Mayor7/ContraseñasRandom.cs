namespace ContraseñasRandom
{
    class NewPassword
    {
        private static Random random = new Random();  // Genererar contraseñas random
        
        public static string GeneratePassword(int length, int numVariables)  // parametros de longitud y no.variables

        {
            string lowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";      //
            string uppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";      //
            string numberCharacters = "1234567890";                         //
            string symbolCharacters = "!#$%&'()*+,-./:;<=>?@[]^_{|}~";      // Caracteres validos
            
            string validCharacters = "";    // almacena los caracteres validos y seleccionados
            
            if (numVariables >= 1)
            {
                validCharacters += lowercaseCharacters;   // no. var >=1 imprime minusculas
            }
            
            if (numVariables >= 2)  
            {
                validCharacters += uppercaseCharacters;  // no. var >=2 imprime minus + may
            }
            
            if (numVariables >= 3)
            {
                validCharacters += numberCharacters;    // no. var >=3 imprime minus + may + number
            }
            
            if (numVariables >= 4)
            {
                validCharacters += symbolCharacters; // no. var >=4 imprime minus + may + number + sym
            }
            
            char[] password = new char[length];
            
            for (int i = 0; i < length; i++)
            {
                password[i] = validCharacters[random.Next(0, validCharacters.Length)];
            }
            
            return new string(password);
        }
        
        public static void Main(string[] args)
        {
            int length = 5;
            int numVariables = 2; // Número de variables para la contraseña
            
            string password = GeneratePassword(length, numVariables);
            Console.WriteLine($"Contraseña: {password}");
        }
    }
}
