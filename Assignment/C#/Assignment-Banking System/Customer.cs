using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Xml.Linq;
using service;
using app;

namespace bean
{
    //Task7-Customer class-Attributes-Customer ID,First Name,Last Name,Email Address,Phone Number,Address
    public class Customer
    {
        public long customerId;
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string phoneNumber;
        public string address;

        private static long nextCustomerId = 1001;

        //Implement default constructors and overload the constructor with Customer attributes,
        //generate getter and setter, (print all information of attribute) methods for the attributes.
        public Customer()
        {
            customerId = nextCustomerId++;
            firstName = "Not Set";
            lastName = "Not Set";
            emailAddress = "Not Set";
            phoneNumber = "Not Set";
            address = "Not Set";
        }
        public Customer(string firstName, string lastName, string emailAddress, string phoneNumber, string address)
        {
            customerId = nextCustomerId++;
            this.firstName = firstName;
            this.lastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            this.address = address;
        }
        public long CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                int a = value.IndexOf("@");
                int d = value.LastIndexOf(".");

                if (a > 0 && d > a + 1 && d < value.Length - 1)
                {
                    emailAddress = value;
                }
                else
                {
                    Console.WriteLine("Invalid email address format.");
                }
            }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length == 10 )
                {
                    phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Phone number must be exactly 10 digits.");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Method to print customer info
        public void PrintCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Email: " + emailAddress);
            Console.WriteLine("Phone: " + phoneNumber);
            Console.WriteLine("Address: " + address);
        }
        public string CustomerName
        {
            get { return FirstName + " " + LastName; }
        }
        public override bool Equals(object obj)
        {
            Customer other = obj as Customer;
            if (other != null)
            {
                return this.CustomerId == other.CustomerId;
            }
            return false;
        }
    }
}
