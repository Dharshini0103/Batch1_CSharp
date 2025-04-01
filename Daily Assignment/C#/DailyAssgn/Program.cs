using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace DailyAssgn4
{


    // Base class
    class Employee
    {
        public int ID;
        public string Name;
        public DateOnly DOB;
        public int Salary;
        public Employee(int id, string name, DateOnly dob, int salary)
        {
            ID = id;
            Name = name;
            DOB = dob;
            Salary = salary;
        }
        public virtual void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, DOB: {DOB}, Salary: {Salary}");

        }
    }
    class Manager : Employee
    {
        public int On_Site_Allowance;
        public int Bonus;
        public Manager(int id, string name, DateOnly dob, int salary, int OnSiteAllowance, int bonus) : base(id, name, dob, salary)
        {
            On_Site_Allowance = OnSiteAllowance;
            Bonus = bonus;
        }
        public override void Display()
        {
            int totalSalary = Salary + On_Site_Allowance + Bonus;
            Console.WriteLine($"ID: {ID}, Name: {Name}, DOB: {DOB}, Total Salary: {totalSalary}");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Create classes employee and manager. An employee will have attributes/fields viz. id, name, dob, salary. A manager will extend/ derive from an employee.He will additionally have onsite_allowance and bonus as attributes.Compute the salary of an employee and manager
            Employee emp = new Employee(101, "Dharshini", new DateOnly(2003, 9, 01), 50000);
            Manager mgr = new Manager(102, "Harini", new DateOnly(2003, 10, 2), 70000, 5000, 10000);
            emp.Display();
            mgr.Display();

            // you are a s/w developer in ABC Consultancy firm. You need to check how many times a function is called. For this you have been asked to create a function called CountFunction(). create the function the satisfy the no.of times it is being called
            Console.WriteLine();
            Counter.CountFunction();
            Counter.CountFunction();
            Counter.CountFunction();
            Counter.Display();

        }
    }
}













