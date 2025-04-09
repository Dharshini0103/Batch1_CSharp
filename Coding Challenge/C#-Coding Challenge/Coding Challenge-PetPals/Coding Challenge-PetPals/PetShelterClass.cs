using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{
    //Question3
    //PetShelter Class:Attributes:availablePets(List of Pet) : A list to store available pets for adoption.
    //Methods:AddPet(Pet pet) : Adds a pet to the list of available pets.RemovePet(Pet pet) : Removes a pet from the list of available pets.ListAvailablePets() : Lists all available pets in the shelter.
    internal class PetShelterClass
    {
        private List<PetClass> availablePets = new List<PetClass>();

        // Method to add a pet to the list
        public void AddPet(PetClass pet)
        {
            availablePets.Add(pet);
            Console.WriteLine($"Pet '{pet.Name}' added to the shelter.");
        }

        // Method to remove a pet from the list
        public void RemovePet(PetClass pet)
        {
            if (availablePets.Remove(pet))
            {
                Console.WriteLine($"Pet '{pet.Name}' removed from the shelter.");
            }
            else
            {
                Console.WriteLine($"Pet '{pet.Name}' not found in the shelter.");
            }
        }

        // Method to list all available pets
        public void ListAvailablePets()
        {
            if (availablePets.Count == 0)
            {
                Console.WriteLine("No pets available for adoption.");
                return;
            }
            Console.WriteLine("Available Pets in Shelter:");
            foreach (PetClass pet in availablePets)
            {
                Console.WriteLine($"Available pets are:{pet.ToString()}");
            }

        }
    }
}
