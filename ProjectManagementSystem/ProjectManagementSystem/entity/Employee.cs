using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.entity
{
    public class Employee
    {
        private int id;
        private string name;
        private string designation;
        private string gender;
        private double salary;
        private int project_id;

        public Employee() { }

        public Employee(int id, string name, string designation, string gender, double salary, int project_id)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            this.gender = gender;
            this.salary = salary;
            this.project_id = project_id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }
    }
}
