using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coding_Challenge_PetPals
{
    //Question5
    //IAdoptable Interface/Abstract Class:Methods:Adopt() : An abstract method to handle the adoption process.
    internal interface IAdoptable_Interface
    {
        public abstract void Adopt();
    }
}
