using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 9.1. Удалены методы заполнения полей, добавлены конструкторы в Упражнение 8.1.\n");
            BankAccount bankAccount1 = new BankAccount(100000, BankAccountType.Current);
            bankAccount1.Print();
            BankAccount bankAccount2 = new BankAccount(200000, BankAccountType.Savings);
            bankAccount1.Transfer(bankAccount2, 7000);
            bankAccount1.Print();
            Console.WriteLine("Нажмите Enter, чтобы перейти к следующей задаче.");
            Console.ReadKey();

            Console.WriteLine("\nУпражнение 9.2. Создание класса <BankTransaction>.\n");
            bankAccount1.PrintTransactions();
            Console.WriteLine("Нажмите Enter, чтобы перейти к следующей задаче.");
            Console.ReadKey();


            Console.WriteLine("\nУпражнение 9.3. В классе банковский счет создан метод Dispose, который данные о проводках из очереди записывает в файл.\n");
            bankAccount2.Withdraw(349, bankAccount1.Balance);
            bankAccount2.Dispose();
            Console.WriteLine("Данные о транзакциях были записаны во внешний файл <transactions.txt>\n");



            Console.WriteLine("Д/з 9.1. Добавление новых конструкторов в класс Song из Д/з 8.1.\n");
            List<Song> songs = new List<Song>();
            Song song1 = new Song("Царица", "Anna Asti");
            songs.Add(song1);
            Song song2 = new Song("Каждй раз", "монеточка");
            songs.Add(song2);
            Song song3 = new Song();
            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Первая и вторая песни равны");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни не равны");
            }

        }
    }
}
