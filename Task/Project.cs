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
        /// <summary>
        /// Свойство для чтения поля deadline.
        /// </summary>
        private DateTime Deadline 
        { 
            get
            {
                return deadline;
            }
        }
        /// <summary>
        /// Свойство для чтения поля customer.
        /// </summary>
        public Employee Customer 
        { 
            get
            {
                return customer;
            }
        }
        /// <summary>
        /// Свойство для чтения поля teamLead.
        /// </summary>
        public Employee TeamLead 
        { 
            get
            {
                return teamLead;
            }
        }
        /// <summary>
        /// Свойство для чтения поля task.
        /// </summary>
        private List<Task> Tasks 
        { 
            get
            {
                return tasks;
            } 
        }
        /// <summary>
        /// Свойство для чтения поля status.
        /// </summary>
        public ProjectStatus Status
        {
            get
            {
                return status;
            }
        }
        /// <summary>
        /// Метод, который добавляет задачу в список задач tasks.
        /// </summary>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// Метод, который удаляет задачу из списка задач tasks.
        /// </summary>
        public void RemoveTask(Task task)
        {
            tasks.Remove(task); 
        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
        public Project(DateTime deadline, Employee customer, Employee teamLead, string description)
        {
            this.deadline = deadline;
            this.customer = customer;
            this.teamLead = teamLead;
            Description = description;
        }
    }
}
