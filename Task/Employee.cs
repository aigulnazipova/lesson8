using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    enum Position
    {
        Customer,
        TeamLeader,
        Developer
    }

    internal class Employee
    {
        private string Name {  get; set; }
        private Position Position { get; set; }
        private Task Task { get; set; }
        public Employee(string name, Position position) 
        {
            Name = name;
            Position = position;
        }
    }
}
