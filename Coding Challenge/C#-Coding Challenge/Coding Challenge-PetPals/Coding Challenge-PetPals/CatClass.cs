using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{
    //Cat Class (Inherits from Pet):Additional Attributes:CatColor(string) : The color of the cat.
    //Additional Methods:Constructor to initialize CatColor.Getters and setters for CatColor.
    public class CatClass:PetClass
    {
        public string catColor;

        
        public CatClass(string name, int age, string breed, string catColor)
            : base(name, age, breed)
        {
            this.catColor = catColor;
        }
        public string CatColor
        {
            get { return catColor; }
            set { catColor = value; }
        }
    }
}
