using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{   //Question2
    //Dog Class(Inherits from Pet):Additional Attributes:DogBreed(string) : The specific breed of the dog.
    //Additional Methods:Constructor to initialize DogBreed.Getters and setters for DogBreed.
    public class DogClass:PetClass
    {
        public string dogBreed;
        public DogClass(string name, int age, string breed, string dogBreed)
            : base(name, age, breed)
        {
            this.dogBreed = dogBreed;
        }
        public string DogBreed
        {
            get { return dogBreed; }
            set { dogBreed = value; }
        }


    }
}
