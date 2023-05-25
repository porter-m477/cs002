using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace RandomPasswordGenerator
{
    
    

    class ConsoleUI:PasswordGenerator
    {
        public static void Main()
        {
            //PasswordGenerator gpass = new PasswordGenerator();
            // Prompt the user for the number of characters.
            Console.WriteLine("How many characters should the password be?");
            int length = Convert.ToInt32(Console.ReadLine());

            // Prompt the user whether to include numbers.
            Console.WriteLine("Do you want to include numbers in the password? (Y/N)");
            string includeNumbers = Console.ReadLine();

            // Prompt the user whether to include special characters.
            Console.WriteLine("Do you want to include special characters in the password? (Y/N)");
            string includeSpecialCharacters = Console.ReadLine();

            // Generate a random password and display it to the user.
            bool numbers = includeNumbers.ToLower() == "y";
            bool specialCharacters = includeSpecialCharacters.ToLower() == "y";
            string password =  GeneratePassword(length, numbers, specialCharacters);//gpass.GeneratePassword(length, numbers, specialCharacters);
            Console.WriteLine("Your password is: " + password);
            
        }
    }


}