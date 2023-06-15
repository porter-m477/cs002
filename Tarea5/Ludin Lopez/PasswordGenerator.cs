namespace RandomPasswordGenerator
{
    
    class PasswordGenerator
    {
        public static string GeneratePassword(int length, bool includeNumbers, bool includeSpecialCharacters)
        {
            // Create a random number generator.
            System.Random rng = new System.Random();
            //Random rng = new Random();
            //RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Create a string of all possible characters.
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // If numbers are allowed, add them to the string of possible characters.
            if (includeNumbers)
            {
                characters += "0123456789";
            }

            // If special characters are allowed, add them to the string of possible characters.
            if (includeSpecialCharacters)
            {
                characters += "!@#$%^&*()-_=+<,>.";
            }

            // Generate a random password of the specified length.
            string password = "";
            for (int i = 0; i < length; i++)
            {
                password += characters[rng.Next(0,length)];
            }

            // Return the generated password.
            return password;
        }
    }
}