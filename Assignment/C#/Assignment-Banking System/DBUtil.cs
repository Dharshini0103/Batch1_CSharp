using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Assignment_Banking_System
{
    internal class DBUtil
    {
        
        static SqlConnection con = null;
        static SqlCommand cmd;
        static SqlDataReader dr;


        // Static method to get the database connection
        public static SqlConnection GetDBConn()
        {
            
            
            
            try
            {
                
                con = new SqlConnection("data source = DHARSH01\\SQLEXPRESS01;initial catalog = HMBank;integrated security = true;");
                con.Open();
                return con;
                
               
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception occurred while trying to connect to the database.");
                Console.WriteLine("Error: " + ex.Message);
                throw;  
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            
        }
        
        public static void SelectData()
        {
            Console.WriteLine("Task14");
            con = GetDBConn();
            
            cmd = new SqlCommand("select * from Customers where first_name like'%a' ", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1]);
                Console.WriteLine("Customer_ID = " + dr["customer_id"]);
                Console.WriteLine();
                Console.WriteLine("First Name = " + dr["first_name"]);
                Console.WriteLine();
                Console.WriteLine("Last Name = " + dr["last_name"]);
            }
            con.Close();
        }
        public static void InsertData()
        {
            con = GetDBConn();

            Console.Write("Enter Customer ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Account Type (savings/current/zero_balance): ");
            string type = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Initial Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("INSERT INTO Accounts (account_type, balance) VALUES (@type, @bal)", con);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@bal", balance);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                Console.WriteLine("Record added successfully.");
            else
                Console.WriteLine("Unable to add a record.");

            con.Close();
        }



        public static void UpdateData()
        {
            con = GetDBConn();

            Console.Write("Enter Account ID to update: ");
            int accId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("UPDATE Accounts SET balance = @bal WHERE account_id = @accId", con);
            cmd.Parameters.AddWithValue("@bal", balance);
            cmd.Parameters.AddWithValue("@accId", accId);


            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                Console.WriteLine("Record updated successfully.");
            else
                Console.WriteLine("Update failed.");

            con.Close();
        }


    }
}
     
        
    
