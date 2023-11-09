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

        /// <summary>
        /// Метод, меняет статус задачи на В работе.
        /// </summary>
        public void StartTask(Employee executor)
        {
            status = TaskStatus.InProgress;
            this.executor = executor;
        }
        /// <summary>
        /// Метод, меняет статус задачи на На проверке.
        /// </summary>
        public void TestTask()
        {
            status = TaskStatus.Test;
        }
        /// <summary>
        /// Метод, меняет статус задачи на Завершена.
        /// </summary>
        public void CompletedTask()
        {
            status = TaskStatus.Completed;
        }
        /// <summary>
        /// Метод, меняет статус задачи на Назначена.
        /// </summary>
        public void DelegateTask(Employee executor)
        {
            if (status == TaskStatus.Assigned)
            {
                this.executor = executor;
            } 
        }
        /// <summary>
        /// Метод, который меняет статус задачи на Отклоненa.
        /// </summary>
        public void RejectTask(Employee executor)
        {
            status = TaskStatus.Assigned;
            executor = null;

        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
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
