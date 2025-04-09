using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{
    //Question4
    //Donation Class (Abstract):Attributes:DonorName(string) : The name of the donor.Amount(decimal) : The donation amount.
    //Methods:Constructor to initialize DonorName and Amount.Abstract method RecordDonation() to record the donation (to be implemented in derived classes).
    public abstract class DonationClass
    {
        public string DonorName { get; set; }
        public decimal Amount { get; set; }
        public DonationClass(string donorName, decimal amount)
        {
            DonorName = donorName;
            Amount = amount;
        }
        public abstract void RecordDonation();
    }
}
