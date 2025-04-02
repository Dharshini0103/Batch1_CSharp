using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAssgn5_2
{
    internal class Student
    {
        string name;
        int rollno;
        int semester;
        string branch;
        string Class1;
        int[] marks = new int[5];
        public Student(string Name,int Rollno,int Semester,string Branch,string class1,int [] Marks)
        {
            this.branch = Branch;
            this.name = Name;   
            this.rollno = Rollno;   
            this.semester = Semester;   
            this.branch = Branch;
            this.Class1 = class1;
            this.marks= Marks;
        }
        public void GetMarks()
        {
            marks[0] = 80;
            marks[1] = 90;
            marks[2] = 85;
            marks[3] = 75;
            marks[4] = 95;
        }
        int s = 0;
        int Average;
        int d = 0;
        
        public void DisplayResult()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                s = s + marks[i];
                if (marks[i] < 35)
                    d = d + 1;
            }
            Average = s / marks.Length;
            if (d > 0 || Average < 50)
                Console.WriteLine("\nFailed");
            else
                Console.WriteLine("\nPassed");
        }
        public void DisplayData()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Roll No: {rollno}");
            Console.WriteLine($"Class: {Class1}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            foreach (int mark in marks) 
                Console.Write(mark + " ");

        }


        
        
    }
}
