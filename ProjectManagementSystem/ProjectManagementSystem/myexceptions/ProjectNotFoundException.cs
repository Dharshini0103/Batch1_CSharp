using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.myexceptions
{
    public class ProjectNotFoundException:Exception
    {
        public ProjectNotFoundException() : base("Project not found.") { }

        public ProjectNotFoundException(string message) : base(message) { }
    }
}
