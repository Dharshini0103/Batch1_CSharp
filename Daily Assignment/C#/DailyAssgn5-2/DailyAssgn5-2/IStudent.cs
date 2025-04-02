using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAssgn5_2
{
    internal interface IStudent
    {
        
            int StudentId { get; }
            string Name { get; }
            double Fees { get; }
            void ShowDetails();
        
    }

    class Dayscholar : IStudent
    {
        public int StudentId { get; }
        public string Name { get; }
        public double Fees { get; }

        public Dayscholar(int id, string name, double fees)
        {
            StudentId = id;
            Name = name;
            Fees = fees;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar - ID: {StudentId}, Name: {Name}, Fees: {Fees}");
        }
    }

    class Resident : IStudent
    {
        public int StudentId { get; }
        public string Name { get; }
        public double Fees { get; }

        public Resident(int id, string name, double tuition, double hostel)
        {
            StudentId = id;
            Name = name;
            Fees = tuition + hostel;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Resident - ID: {StudentId}, Name: {Name}, Total Fees: {Fees}");
        }
    }
}

