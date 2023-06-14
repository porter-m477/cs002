using System;

namespace Passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GENERADO DE PASSWORD ===");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Cantidad de caracteres que debe tener la contraseña:  ");
            
            int longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            NewPassword contra = new NewPassword(longitud, 'y', 'y', 'y');
            Console.WriteLine("-----------------------------");
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 