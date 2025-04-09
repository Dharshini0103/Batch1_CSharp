using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{
    //ItemDonation Class (Derived from Donation):Additional Attributes-ItemType(string) : The type of item donated(e.g., food, toys).
    //Additional Methods:Constructor to initialize ItemType.Implementation of RecordDonation() to record an item donation.
    public class ItemDonationClass:DonationClass
    {
        public string ItemType;
        public ItemDonationClass(string donorName, decimal amount, string itemType)
            : base(donorName, amount)
        {
            ItemType = itemType;
        }

        public override void RecordDonation()
        {
            Console.WriteLine($"Item Donation Recorded:");
            Console.WriteLine($"Donor: {DonorName}");
            Console.WriteLine($"Estimated Value: ₹{Amount}");
            Console.WriteLine($"Item Type: {ItemType}");
        }
    }
}
