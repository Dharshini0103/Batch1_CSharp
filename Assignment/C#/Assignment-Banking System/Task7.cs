using app;
using bean;
namespace Assignment_Banking_System
{

    internal class Task7
    {
        public static void Task7Run()
        {
            Bank bank = new Bank();
            Console.WriteLine("Task7");
            //Implement default constructors and overload the constructor with Customer attributes, generate getter and setter, (print all information of attribute) methods for the attributes.
            Customer customer = new Customer("Dharshini", "V M", "dharshini@mail.com", "9876543210", "Chennai");
            Console.WriteLine("\n--- Customer Details ---");
            Console.WriteLine("Customer ID   : " + customer.CustomerId);
            Console.WriteLine("First Name    : " + customer.FirstName);
            Console.WriteLine("Last Name     : " + customer.LastName);
            Console.WriteLine("Email Address : " + customer.EmailAddress);
            Console.WriteLine("Phone Number  : " + customer.PhoneNumber);
            Console.WriteLine("Address       : " + customer.Address);
            Console.Write("Enter Account Number to Deposit: ");



            Account account = new Account();
            long acc_no=long.Parse(Console.ReadLine());
            bank.Withdraw(acc_no, 5000f);
            bank.Deposit(acc_no, 5000f);


            
        }
    }
}

