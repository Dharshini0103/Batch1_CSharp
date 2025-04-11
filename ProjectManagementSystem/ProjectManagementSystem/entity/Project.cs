using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.entity
{
    public class Project
    {
        private int id;
        private string projectName;
        private string description;
        private DateTime start_date;
        private string status;

        public Project() { }

        public Project(int id, string projectname, string description, DateTime start_date, string status)
        {
            this.id = id;
            this.projectName = projectname;
            this.description = description;
            this.start_date = start_date;
            this.status = status;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Projectname
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime Start_date
        {
            get { return start_date; }
            set { start_date = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

