using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.entity
{
    public class Task
    {
        private int task_id;
        private string task_name;
        private int project_id;
        private int employee_id;
        private string status;

        public Task() { }

        public Task(int task_id, string task_name, int project_id, int employee_id, string status)
        {
            this.task_id = task_id;
            this.task_name = task_name;
            this.project_id = project_id;
            this.employee_id = employee_id;
            this.status = status;
        }

        public int Task_id
        {
            get { return task_id; }
            set { task_id = value; }
        }

        public string Task_name
        {
            get { return task_name; }
            set { task_name = value; }
        }

        public int Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }

        public int Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

