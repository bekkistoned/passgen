using System;
using System.Text;

class Program
{
     static void Main()
     {
         Console.WriteLine("Random password generator");

         Console.Write("Enter password length: ");
         int passwordLength;

         // Check if the password length is entered correctly
         while (!int.TryParse(Console.ReadLine(), out passwordLength) || passwordLength <= 0)
         {
             Console.WriteLine("Please enter a positive integer.");
             Console.Write("Enter password length: ");
         }

         // Password generation
         string generatedPassword = GenerateRandomPassword(passwordLength);

         Console.WriteLine($"\nGenerated password: {generatedPassword}");

         Console.ReadLine();
     }

     static string GenerateRandomPassword(int length)
     {
         const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+";

         StringBuilder password = new StringBuilder();
         Random random = new Random();

         for (int i = 0; i < length; i++)
         {
             int index = random.Next(chars.Length);
             password.Append(chars[index]);
         }

         return password.ToString();
     }
}
