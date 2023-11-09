using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    /// <summary>
    /// Перечисление, отвечающее за должность сотрудника.
    /// </summary>
    enum Position
    {
        Customer,
        TeamLeader,
        Developer
    }

    internal class Employee
    {
        private string name;
        private Position position;
        private Task task;
        /// <summary>
        /// Свойство для чтения и заполнения поля name.
        /// </summary>
        public string Name {  get; set; }
        /// <summary>
        /// Свойство для чтения и заполнения поля position.
        /// </summary>
        public Position Position { get; set; }
        /// <summary>
        /// Свойство для чтения и заполнения поля task.
        /// </summary>
        public Task Task { get; set; }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
        public Employee(string name, Position position) 
        {
            Name = name;
            Position = position;
        }
    }
}
