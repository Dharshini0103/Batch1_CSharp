using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{
    //Question6
    
    internal class Exceptionhandling
    {
        public class InvalidPetAgeHandling : Exception
        {
            public InvalidPetAgeHandling(string message):base(message)  { }
        }
        public class NullReferenceExceptionHandling : Exception
        {
            public NullReferenceExceptionHandling(string message) : base(message) { }
        }
        public class InsufficientFundsException : Exception
        {
            public InsufficientFundsException(string message) : base(message) { }
        }
        public class FileHandlingException : Exception
        {
            public FileHandlingException(string message) : base(message) { }
        }


    }
}
