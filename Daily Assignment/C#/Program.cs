using  System;

namespace DailyCode
{
    

    // Base class
    class Employee
    {
        public int Id;
        public string Name;
        public DateTime Dob;
        public double Salary;

        public void GetDetails()
        {
            Console.Write("\nEnter ID: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter DOB : ");
            Dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            Salary = double.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, DOB: {Dob}, Salary: {Salary}");
        }
    }

    // Derived class
    class Manager : Employee
    {
        public double OnsiteAllowance;
        public double Bonus;

        public void GetManagerDetails()
        {
            GetDetails();
            Console.Write("Enter Onsite Allowance: ");
            OnsiteAllowance = double.Parse(Console.ReadLine());
            Console.Write("Enter Bonus: ");
            Bonus = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            double totalSalary = Salary + OnsiteAllowance + Bonus;
            Console.WriteLine($"ID: {Id}, Name: {Name}, DOB: {Dob}, Total Salary: {totalSalary} ");
        }
    }

    class Program
    {
        public static void Main(string[]args)
        {
            Employee emp = new Employee();
            Console.Write("Enter Employee Details:");
            emp.GetDetails();
            emp.Display();

            Manager mgr = new Manager();
            Console.WriteLine("Enter Manager Details:");
            mgr.GetManagerDetails();
            mgr.Display();
            //Assgn-2
            Console.WriteLine("\nCount Function:");
            FunctionCounter.CountFunction();
            FunctionCounter.CountFunction();
            FunctionCounter.CountFunction();
            FunctionCounter.PrintTotalCount();


        }
    }









}
