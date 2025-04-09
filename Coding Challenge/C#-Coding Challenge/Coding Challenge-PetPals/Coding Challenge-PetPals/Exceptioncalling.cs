using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Coding_Challenge_PetPals.Exceptionhandling;

namespace Coding_Challenge_PetPals
{
    internal class Exceptioncalling
    {
        public static void exception()
        {
            //1. Pet age
            try
            {
                Console.Write("Enter pet age: ");
                int age = int.Parse(Console.ReadLine());
                Checking.CheckPetAge(age);
                Console.WriteLine("Pet age is valid.");
            }
            catch (InvalidPetAgeHandling ex)
            {
                Console.WriteLine($"Pet age check failed: {ex.Message}");
            }

            // 2. Calling Null Property Check
            try
            {
                Console.Write("Enter pet name: ");
                string name = Console.ReadLine();

                Console.Write("Enter pet age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter pet breed: ");
                string breed = Console.ReadLine();
                PetClass pet = new PetClass(name, age, breed);
                
                Checking.CheckPetProperties(pet);
                Console.WriteLine("Pet properties are valid.");
            }
            catch (NullReferenceExceptionHandling ex)
            {
                Console.WriteLine($"Null property check failed: {ex.Message}");
            }

            // 3. Donation Amount Check
            try
            {
                Console.Write("Enter donation amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                Checking.CheckDonationAmount(amount);
                Console.WriteLine("Donation successful!");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Donation failed: {ex.Message}");
            }

            // 4. File Reading
            try
            {
                Console.Write("Enter file name to read pet data: ");
                string fileName = Console.ReadLine();
                Checking.ReadPetDataFromFile(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
    

