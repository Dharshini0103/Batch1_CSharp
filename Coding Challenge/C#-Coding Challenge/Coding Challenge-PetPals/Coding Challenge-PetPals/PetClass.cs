using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coding_Challenge_PetPals
{
    //Question1
    //Pet Class:Name(string)-Age(int)-Breed(string) : The breed of the pet.
    //Methods:Constructor to initialize Name, Age, and Breed.Getters and setters for attributes.ToString() method to provide a string representation of the pet.
    public class PetClass
    {
        
        public string Name;
        public int Age;
        public string Breed;
        public PetClass(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string breed
        {
            get { return Breed; }
            set { Breed = value; }
        }
        public override string ToString()
        {
            return $"Pet Name: {name}, Age: {age}, Breed: {breed}";
        }

    }
}
        
    
    


       
