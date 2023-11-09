using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    enum TaskStatus
    {
        Assigned,
        InProgress,
        Test,
        Completed
    }
    internal class Task
    {
        private string description;
        private DateTime deadline;
        private Employee customer;
        private Employee executor;
        private TaskStatus status;

        public string Description
        {
            get
            {
                return description;
            }
        }
        public DateTime Deadline
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
        public Employee Executor
        {
            get
            {
                return executor;
            }
        }
        public TaskStatus Status
        {
            get
            {
                return status;
            }
        }
        
        public void StartTask(Employee executor)
        {
            status = TaskStatus.InProgress;
            this.executor = executor;
        }
        public void TestTask()
        {
            status = TaskStatus.Test;
        }
        public void CompletedTask()
        {
            status = TaskStatus.Completed;
        }
        public void DelegateTask(Employee executor)
        {
            if (status == TaskStatus.Assigned)
            {
                this.executor = executor;
            } 
        }
        public void RejectTask(Employee executor)
        {
            status = TaskStatus.Assigned;
            executor = null;

        }
        public Task(string description, DateTime deadline, Employee customer, Employee executor, TaskStatus status)
        {
            this.description = description;
            this.deadline = deadline;
            this.customer = customer;
            this.executor = executor;
            this.status = status;
        }
    }
}
