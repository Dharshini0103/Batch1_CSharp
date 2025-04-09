using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Coding_Challenge_PetPals
{

    internal class DBUtil
    {
        static SqlConnection con = null;
        static SqlCommand cmd;
        static SqlDataReader dr;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = DHARSH01\\SQLEXPRESS01;initial catalog = CodingChallengeSQL;integrated security = true;");
            con.Open();
            return con;
        }
        public static void DisplayPets()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("SELECT * FROM Pets WHERE AvailableForAdoption = 1", con);
                dr = cmd.ExecuteReader();

                Console.WriteLine("Available Pets for Adoption:");
                while (dr.Read())
                {
                    Console.WriteLine($"Pet ID: {dr["PetID"]}, Name: {dr["Name"]}, Age: {dr["Age"]}, Breed: {dr["Breed"]}, Type: {dr["Type"]}");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error displaying pets: " + ex.Message);
            }
        }
            public static void RecordDonation()
        {
            try
            {
                con = getConnection();

                Console.WriteLine("Enter Donor Name:");
                string donor = Console.ReadLine();

                Console.WriteLine("Enter Donation Type (Cash/Item):");
                string type = Console.ReadLine();

                decimal? amount = null;
                string item = null;

                if (type.ToLower() == "cash")
                {
                    Console.WriteLine("Enter Donation Amount:");
                    amount = Convert.ToDecimal(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter Donation Item:");
                    item = Console.ReadLine();
                }

                DateTime date = DateTime.Now;

                cmd = new SqlCommand("INSERT INTO Donations (DonorName, DonationType, DonationAmount, DonationItem, DonationDate) VALUES (@name, @type, @amount, @item, @date)", con);
                cmd.Parameters.AddWithValue("@name", donor);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@amount", (object)amount ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@item", (object)item ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@date", date);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "Donation recorded." : "Failed to record donation.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error recording donation: " + ex.Message);
            }

        }
        public static void RecordCashDonation()
        {
            try
            {
                con = getConnection();

                Console.WriteLine("Enter Donor Name:");
                string donorName = Console.ReadLine();

                Console.WriteLine("Enter Donation Amount:");
                decimal donationAmount = Convert.ToDecimal(Console.ReadLine());

                DateTime donationDate = DateTime.Now;

                string query = "INSERT INTO Donations (DonorName, DonationType, DonationAmount, DonationItem, DonationDate) " +
                               "VALUES (@name, 'Cash', @amount, NULL, @date)";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", donorName);
                cmd.Parameters.AddWithValue("@amount", donationAmount);
                cmd.Parameters.AddWithValue("@date", donationDate);

                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine(rows > 0 ? "Cash donation recorded successfully!" : "Failed to record donation.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Donation amount must be a number.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
            
        }
        public static void ManageAdoptionEvents()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("SELECT * FROM AdoptionEvents WHERE EventDate >= GETDATE()", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    Console.WriteLine($"{dr["EventID"]}: {dr["EventName"]} on {dr["EventDate"]} at {dr["Location"]}");
                dr.Close();

                Console.Write("Register? (Y/N): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Write("Name: "); string name = Console.ReadLine();
                    Console.Write("Type: "); string type = Console.ReadLine();
                    Console.Write("EventID: "); int eid = Convert.ToInt32(Console.ReadLine());

                    string q = "INSERT INTO Participants (ParticipantName, ParticipantType, EventID) VALUES (@n, @t, @e)";
                    cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@t", type);
                    cmd.Parameters.AddWithValue("@e", eid);

                    Console.WriteLine(cmd.ExecuteNonQuery() > 0 ? "Registered." : "Failed.");
                }
            }
            catch { Console.WriteLine("Error! Check input or database."); }
            
        }







    }

}

