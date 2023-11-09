using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee customer = new Employee("Айгуль", Position.Customer);
            Employee teamLeader = new Employee("Диана", Position.TeamLeader);
            Employee developer1 = new Employee("Самат", Position.Developer);
            Employee developer2 = new Employee("Марат", Position.Developer);
            Employee developer3 = new Employee("Владислав", Position.Developer);
            Employee developer4 = new Employee("Валерий", Position.Developer);
            Employee developer5 = new Employee("Игнатий", Position.Developer);
            Employee developer6 = new Employee("Фархат", Position.Developer);
            Employee developer7 = new Employee("Рустам", Position.Developer);
            Employee developer8 = new Employee("Мердан", Position.Developer);
            Employee developer9 = new Employee("Алина", Position.Developer);

            Project project = new Project(new DateTime(2023, 12, 14), customer, teamLeader, "Разработка мобильного приложения для учета финансов");
            Task task1 = new Task("Анализ рынка", new DateTime(2023, 12, 1), customer, developer1, TaskStatus.Assigned);
            Task task2 = new Task("Проектирование пользовательского интерфейса", new DateTime(2023, 12, 2), customer, developer2, TaskStatus.Assigned);
            Task task3 = new Task("Разработка архитектуры приложения", new DateTime(2023, 12, 3), customer, developer3, TaskStatus.Assigned);
            Task task4 = new Task("Разработка функционала приложения", new DateTime(2023, 12, 4), customer, developer4, TaskStatus.Assigned);
            Task task5 = new Task("Разработка модуля для синхронизации с другими системами", new DateTime(2023, 12, 5), customer, developer5, TaskStatus.Assigned);
            Task task6 = new Task("Тестирование приложения", new DateTime(2023, 12, 6), customer, developer6, TaskStatus.Assigned);
            Task task7 = new Task("Отладка приложения", new DateTime(2023, 12, 7), customer, developer7, TaskStatus.Assigned);
            Task task8 = new Task("Разработка документации", new DateTime(2023, 12, 8), customer, developer8, TaskStatus.Assigned);
            Task task9 = new Task("Разработка стратегии монетизации", new DateTime(2023, 12, 10), customer, developer9, TaskStatus.Assigned);
            Task task10 = new Task("", new DateTime(2023, 11, 30), customer, teamLeader, TaskStatus.Assigned);

            project.AddTask(task1);
            project.AddTask(task2);
            project.AddTask(task3);
            project.AddTask(task4);
            project.AddTask(task5);
            project.AddTask(task6);
            project.AddTask(task7);
            project.AddTask(task8);
            project.AddTask(task9);

            task1.StartTask(developer1);
            task2.StartTask(developer2);
            task3.StartTask(developer3);
            task4.StartTask(developer4);
            task5.StartTask(developer5);
            task6.StartTask(developer6);
            task7.StartTask(developer7);
            task8.StartTask(developer8);
            task9.StartTask(developer9);
            task10.StartTask(teamLeader);



        }
    }
}
