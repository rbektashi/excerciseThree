using System;

namespace exerciseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Update your variable to tell the user that you are going to help them create a password and ask them to enter any phrase
            string createPassword = "Let's create your password! Please enter any phrase :)";
            Console.WriteLine(createPassword);


            //• Store that word in a string variable
            string passPhrase = Console.ReadLine();

            //• Ask the user to enter any number greater than 9, store that input in a string variable
            string userNumber = "Enter any number, greater than 9";
            Console.WriteLine(userNumber);
            userNumber = Console.ReadLine();
            //• Create a variable to store the password

            // Use the following requirements to create the password
            //Remove any spaces from the input
            string removeTrim = passPhrase.Replace(" ", "");

            // Replace the letter a with the number 2
            string replaceA = passPhrase.Replace('a', '2');

            // Replace the letter o with the number 0
            string replaceO = passPhrase.Replace('o', '0');

            // Replace the letter i with an exclamation mark
            string replaceI = passPhrase.Replace('i', '!');

            // Add the last digit of the number to the beginning of the password
            string addLastNumber = userNumber.Remove(0, 1);

            // Add the first digit of the number to the end of the password
            string addFirsttNumber = userNumber.Remove(1, 1);


           

            // In a single message, use string interpolation to display the original phrase, number, and the newly
            //created password to the user
  
            string newPassword = addLastNumber + removeTrim + replaceA + replaceI + addFirsttNumber;

            Console.WriteLine($" We took your phrase {passPhrase} and your number {userNumber} to create your new password {newPassword}");



        }

    }
}
