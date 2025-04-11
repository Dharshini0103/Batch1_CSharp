using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.dao;
using ProjectManagementSystem.entity;
using ProjectManagementSystem.myexceptions;
using ProjectManagementSystem.util;



namespace ProjectManagementSystem.app
{
    public class ProjectApp
    {
        public static void Main(string[] args)
        {
            IProjectRepository repo = new ProjectRepositoryImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("==== Project Management System ====");
                Console.WriteLine("1. Create Project");
                Console.WriteLine("2. Create Employee");
                Console.WriteLine("3. Create Task");
                Console.WriteLine("4. Assign Project to Employee");
                Console.WriteLine("5. Assign Task in Project to Employee");
                Console.WriteLine("6. Delete Employee");
                Console.WriteLine("7. Delete Project");
                Console.WriteLine("8. View Tasks for Employee in Project");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");

                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Project proj = new Project();
                        Console.Write("Enter Project Name: ");
                        proj.Projectname = Console.ReadLine();
                        Console.Write("Enter Description: ");
                        proj.Description = Console.ReadLine();
                        Console.Write("Enter Start Date (yyyy-mm-dd): ");
                        proj.Start_date = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter Status: ");
                        proj.Status = Console.ReadLine();
                        repo.CreateProject(proj);
                        break;

                    case 2:
                        Employee emp = new Employee();
                        Console.Write("Enter Name: ");
                        emp.Name = Console.ReadLine();
                        Console.Write("Enter Designation: ");
                        emp.Designation = Console.ReadLine();
                        Console.Write("Enter Gender: ");
                        emp.Gender = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        emp.Salary = float.Parse(Console.ReadLine());
                        Console.Write("Enter Project ID: ");
                        emp.Project_id = int.Parse(Console.ReadLine());
                        repo.CreateEmployee(emp);
                        break;

                    case 3:
                        entity.Task task = new entity.Task();
                        Console.Write("Enter Task Name: ");
                        task.Task_name = Console.ReadLine();
                        Console.Write("Enter Project ID: ");
                        task.Project_id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee ID: ");
                        task.Employee_id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Status: ");
                        task.Status = Console.ReadLine();
                        repo.CreateTask(task);
                        break;

                    case 4:
                        Console.Write("Enter Project ID: ");
                        int pId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee ID: ");
                        int eId = int.Parse(Console.ReadLine());
                        repo.AssignProjectToEmployee(pId, eId);
                        break;

                    case 5:
                        entity.Task assignTask = new entity.Task();
                        Console.Write("Enter Task ID: ");
                        assignTask.Task_id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Project ID: ");
                        assignTask.Project_id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee ID: ");
                        assignTask.Employee_id = int.Parse(Console.ReadLine());
                        repo.AssignTaskInProjectToEmployee(assignTask);
                        break;

                    case 6:
                        Employee deleteEmp = new Employee();
                        Console.Write("Enter Employee ID to delete: ");
                        deleteEmp.Id = int.Parse(Console.ReadLine());
                        repo.DeleteEmployee(deleteEmp);
                        break;

                    case 7:
                        Project deleteProj = new Project();
                        Console.Write("Enter Project ID to delete: ");
                        deleteProj.Id = int.Parse(Console.ReadLine());
                        repo.DeleteProject(deleteProj);
                        break;

                    case 8:
                        entity.Task searchTask = new entity.Task();
                        Console.Write("Enter Employee ID: ");
                        searchTask.Employee_id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Project ID: ");
                        searchTask.Project_id = int.Parse(Console.ReadLine());
                        List<entity.Task> taskList = repo.GetAllTasks(searchTask);
                        foreach (var t in taskList)
                        {
                            Console.WriteLine($"Task ID: {t.Task_id}, Name: {t.Task_name}, Status: {t.Status}");
                        }
                        break;

                    case 9:
                        exit = true;
                        Console.WriteLine("Exiting the application. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }

    }
}
