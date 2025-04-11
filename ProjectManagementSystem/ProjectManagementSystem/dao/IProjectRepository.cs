using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.entity;

namespace ProjectManagementSystem.dao
{
    public interface IProjectRepository
    {
        // 2. Add a new project
        bool CreateProject(Project pj);
        // 1. Add a new employee
        bool CreateEmployee(Employee emp);
        // 3. Add a new task
        bool CreateTask(entity.Task tk);

        // 4. Assign a project to an employee
        bool AssignProjectToEmployee(int projectId, int employeeId);

        // 5. Assign a task in a project to an employee
        bool AssignTaskInProjectToEmployee(entity.Task t);

        // 6. Delete an employee
        bool DeleteEmployee(Employee emp);

        // 7. Delete a project
        bool DeleteProject(Project p);

        // 8. Get all tasks assigned to an employee in a project
        List<entity.Task> GetAllTasks(entity.Task t);
    }
}

