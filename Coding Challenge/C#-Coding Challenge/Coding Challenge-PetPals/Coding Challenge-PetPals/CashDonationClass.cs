using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{
    //CashDonation Class (Derived from Donation):Additional Attributes:DonationDate(DateTime) : The date of the cash donation.
    //Additional Methods:Constructor to initialize DonationDate.Implementation of RecordDonation() to record a cash donation.
    public class CashDonationClass:DonationClass
    {
        public DateTime DonationDate;
        public CashDonationClass(string donorName, decimal amount, DateTime donationDate)
       : base(donorName, amount)
        {
            DonationDate = donationDate;
        }

        public override void RecordDonation()
        {
            Console.WriteLine($"Cash Donation Records:");
            Console.WriteLine($"Donor: {DonorName}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Date: {DonationDate.ToString()}");
        }
    }
}
