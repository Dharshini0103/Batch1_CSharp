using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Coding_Challenge_PetPals.Exceptionhandling;

namespace Coding_Challenge_PetPals
{
    internal class Checking
    {
        //In the Pet Adoption Platform, when adding a new pet to a shelter, the age of the pet should be a positive integer. Write a program that prompts the user to input the age of a pet.
        //Implement exception handling to ensure that the input is a positive integer. If the input is not valid, catch the exception and display an error message. If the input is valid, add the pet to the shelter.
        public static void CheckPetAge(int age)
        {
            if (age <= 0)
            {
                throw new InvalidPetAgeHandling("Pet age must be a positive integer.");
            }
        }
        //In the Pet Adoption Platform, when displaying the list of available pets in a shelter, it's important to handle situations where a pet's properties (e.g., Name, Age) might be null.
        //Implement exception handling to catch null reference exceptions when accessing properties of pets in the shelter and display a message indicating that the information is missing.

        public static void CheckPetProperties(PetClass pet)
        {
            if (pet.Name == null || pet.Breed == null)
            {
                throw new NullReferenceExceptionHandling("Pet has null properties (Name or Breed is missing).");
            }
        }
        //Suppose the Pet Adoption Platform allows users to make cash donations to shelters. Write a program that prompts the user to enter the donation amount. Implement exception handling to catch situations where the donation amount is less than a minimum allowed amount (e.g., $10).
        //If the donation amount is insufficient, catch the exception and display an error message.
        //Otherwise, process the donation.
        public static void CheckDonationAmount(decimal amount)
        {
            if (amount < 10)
            {
                throw new InsufficientFundsException("Minimum donation amount is 10.");
            }
        }
        //In the Pet Adoption Platform, there might be scenarios where the program needs to read data from a file (e.g., a list of pets in a shelter).
        //Write a program that attempts to read data from a file. Implement exception handling to catch any file-related exceptions (e.g., FileNotFoundException) and display an error message if the file is not found or cannot be read.
        public static void ReadPetDataFromFile(string file)
        {
            try
            {
                string[] lines = File.ReadAllLines(file);
                Console.WriteLine("Pets in the list:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File read error: {ex.Message}");
            }
        }

    }
}

