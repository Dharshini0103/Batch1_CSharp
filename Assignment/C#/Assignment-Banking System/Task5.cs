using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Banking_System
{
    internal class Task5
        //Write a program that prompts the user to create a password for their bank account.Implement if conditions to validate the password according to these rules:
        //The password must be at least 8 characters long.It must contain at least one uppercase letter.
        //It must contain at least one digit.Display appropriate messages to indicate whether their password is valid or not.
    {
        public static void PasswordCreation()
        {
            Console.WriteLine("Task5");
            Console.Write("Enter the Account Number: ");
            double Account_No=double.Parse(Console.ReadLine());
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            if (IsValidPassword(password))
                Console.WriteLine("Valid Password");
            else Console.WriteLine("Invalid Password");

        }
        public static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;
            bool upper = false;
            bool digit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    upper = true;
                }
                if (char.IsDigit(c))
                {
                    digit = true;
                }
            }
            return upper && digit;
        }
        


    }
}
