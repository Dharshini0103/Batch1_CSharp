namespace Coding_Challenge_PetPals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //DBConnectivity

            
                Console.WriteLine("PetPals");
                Exceptioncalling.exception();
                while (true)
                {
                    Console.WriteLine("\n--- Pet Adoption Platform ---");
                    Console.WriteLine("1. Record Cash Donation");
                    Console.WriteLine("2. Manage Adoption Events");
                    Console.WriteLine("3. Display Pets");
                    Console.WriteLine("4. Record Any Donation");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            DBUtil.RecordCashDonation();
                            break;

                        case "2":
                            DBUtil.ManageAdoptionEvents();
                            break;

                        case "3":
                            DBUtil.DisplayPets();
                            break;

                        case "4":
                            DBUtil.RecordDonation();
                            break;

                        case "5":
                            return; // Exit the app

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }




                }




           
        }
    }
}

