using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    enum ProjectStatus
    {
        Project,
        Execution,
        Closed
    }
    internal class Project
    {
        
        private DateTime deadline;
        private Employee customer;
        private Employee teamLead;
        private List<Task> tasks;
        private ProjectStatus status;
        private string Description { get; set; }
        private DateTime Deadline 
        { 
            get
            {
                return deadline;
            }
        }
        public Employee Customer 
        { 
            get
            {
                return customer;
            }
        }
        public Employee TeamLead 
        { 
            get
            {
                return teamLead;
            }
        }
        private List<Task> Tasks 
        { 
            get
            {
                return tasks;
            } 
        }
        
        public ProjectStatus Status
        {
            get
            {
                return status;
            }
        }
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(Task task)
        {
            tasks.Remove(task); 
        }
        public Project(DateTime deadline, Employee customer, Employee teamLead, string description)
        {
            this.deadline = deadline;
            this.customer = customer;
            this.teamLead = teamLead;
            Description = description;
        }
    }
}
