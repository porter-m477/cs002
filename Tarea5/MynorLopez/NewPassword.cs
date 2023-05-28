namespace Passwords
{
    class NewPassword
    {
        public NewPassword(int longitud, char mayusculas, char numeros, char simbolos){

            string cadena = "abcdefghijklmnopqurstuvwxyz";
            Random rnd = new Random();
            string contrasenia = "";

            if (mayusculas == 'y')
            {
                cadena += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if(numeros == 'y')
            {
                cadena += "1234567890";
            }

            if(simbolos == 'y')
            {
                cadena += "!#$%&'()*+,-./:;<=>?@[]^_{|}~";
            }

            for (int i = 0; i < longitud; i++)
            {
                contrasenia += cadena[rnd.Next(0, cadena.Length)];   
            }
            // Console.WriteLine($"Cadena: {cadena}");
            Console.WriteLine($"Contraseña: {contrasenia}");
        }

    }

}