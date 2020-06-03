using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_7_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that will recognize invalid inputs using regular expressions. The program will validate different kinds of input.
            //Welcome the user:
            Console.WriteLine("Welcome to our Input Validater!");
            bool runningProgram = true;

            while (runningProgram)
            {
                IsValidName();
                IsValidEmail();
                IsValidPhoneNumber();
                IsValidDate();

                bool runningProgramAgain = true;

                while (runningProgramAgain)
                {
                    Console.Write("Would you like to run the program again? (yes/no): ");
                    string runAgainChoice = Console.ReadLine().ToLower();

                    if (runAgainChoice == "n" || runAgainChoice == "no")
                    {
                        runningProgramAgain = false;
                        runningProgram = false;
                    }
                    else if (runAgainChoice == "y" || runAgainChoice == "yes")
                    {
                        runningProgramAgain = false;
                        runningProgram = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I didn't detect a yes or no response. Please enter yes or no");
                        runningProgramAgain = true;
                        runningProgram = false;
                    }
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
        //Write a method that will validate names.
        //Names can only have alphabets, they should start with a capital letter, and they have a maximum length of 30. 
        public static void IsValidName()
        {
            bool runningNames = true;

            while (runningNames)
            {
                Console.WriteLine("Please Enter Your First Name: ");
                string userInput = Console.ReadLine();

                if (Regex.IsMatch(userInput, "([A-Z][a-z]{1,30})"))
                {
                    Console.Write($"Hello, {userInput}");
                    Console.WriteLine("\n");
                    runningNames = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, that is not a valid name. Please start with a capital letter.");
                }
            }
        }
        //Write a method that will validate emails.   
        //An email should be in the following format:   
        //{combination of alphanumeric characters, with a length between 5 and 30, and there are no special characters}
        //@{combination of alphanumeric characters, with a length between 5 and 10, and there are no special characters}
        //.{domain can be a combination of alphanumeric characters with a length of two or three}
        public static void IsValidEmail()
        {
            bool runningEmails = true;

            while (runningEmails)
            {
                Console.WriteLine("Please Enter Your Email Address: ");
                string userEmail = Console.ReadLine().ToLower();

                if (Regex.IsMatch(userEmail, @"(.{5,30}@.{2,4}.\w{2,3})"))
                {
                    Console.Write($"Got it! Your Email address is {userEmail}");
                    Console.WriteLine("\n");
                    runningEmails = false;
                }
                else
                {
                    Console.Write("I'm sorry, that is not a valid email. Please use the following format:");
                    Console.WriteLine("youremail@yourdomain.com");
                }
            }
        }
        //Write a method that will validate phone numbers.   
        //A phone number should be in the following format:   
        //{area code of 3 digits} - {3 digits} - {4 digits}
        public static void IsValidPhoneNumber()
        {
            bool runningPhones = true;

            while (runningPhones)
            {
                Console.WriteLine("Please Enter Your Phone Number: ");
                string userPhone = Console.ReadLine();

                if (Regex.IsMatch(userPhone, "(^([0-9]{3})-([0-9]{3})-([0-9]{4})$)"))
                {
                    Console.Write($"Captured! Your phone number is {userPhone}");
                    Console.WriteLine("\n");
                    runningPhones = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, that is not a valid phone number. Please use the following format:");
                    Console.WriteLine("123-123-1234");
                }
            }
        }
        //Write a method that will validate date based on the following format: (dd/mm/yyyy)
        public static void IsValidDate()
        {
            bool runningDates = true;

            while (runningDates)
            {
                Console.WriteLine("Please Enter Your Birthdate:");
                string userBirthdate = Console.ReadLine();

                if (Regex.IsMatch(userBirthdate, "((0[1-9]|1[0-9]|2[0-9]|3[0-1]){1}/{1}(0[1-9]|1[0-2]){1}/{1}([0-9]){4}$)"))
                {
                    Console.Write($"Thanks! We've got your birthday as {userBirthdate}");
                    Console.WriteLine("\n");
                    runningDates = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, that is not a valid date entry. Please use the following format:");
                    Console.WriteLine("01/02/2003");
                }
            }
        }
    }
}
