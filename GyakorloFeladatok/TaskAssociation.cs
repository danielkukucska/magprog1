using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks
{
    class TaskAssociation
    {
        public string taskName;
        public ITask solution;
        public TaskAssociation(string taskName, ITask solution)
        {
            this.taskName = taskName;
            this.solution = solution;
        }
    }
}
