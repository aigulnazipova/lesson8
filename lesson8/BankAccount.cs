using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson8
{
    enum BankAccountType
    {
        Current,
        Savings
    }
    internal class BankAccount : IDisposable
    {
        private int _accountNumber;
        private decimal balance;
        private BankAccountType type;
        private static int lastAccountNumber = 0;
        private Queue<BankTransaction> transactions;
        /// <summary>
        /// Свойство для чтения поля _accountNumber.
        /// </summary>
        public int GetAccountNumber
        {
            get
            {
                return _accountNumber;  
            }   
        }
        /// <summary>
        /// Свойство для чтения поля balance.
        /// </summary>
        public decimal Balance
        { 
            get 
            { 
                return balance; 
            } 
        }
        /// <summary>
        /// Свойство для чтения поля type.
        /// </summary>
        public BankAccountType Type
        {
            get
            {
                return type;
            }
        }
        /// <summary>
        /// Данный метод генерирует номер счета.
        /// </summary>
        private static int GenerateAccountNumber()
        {
            lastAccountNumber++;
            return lastAccountNumber;
        }
        /// <summary>
        /// Данный метод выводит на консоль информацию о банковском аккаунте.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Номер счета: {GenerateAccountNumber()}\nБаланс: {balance} руб.\nТип счета: {type}");
        }
        /// <summary>
        /// Данный метод обеспечивает внесение введенной суммы на банковский счет.
        /// </summary>
        public void Deposit(decimal amount, decimal balance)
        {
            if (amount > 0)
            {
                balance += amount;
                BankTransaction transaction = new BankTransaction(amount);
                transactions.Enqueue(transaction);
                Console.WriteLine($"Внесено на счет: {amount} руб. Баланс после операций: {balance} руб.\n");
            }
            else
            {
                Console.WriteLine("Нельзя внести отрицательную сумму!");
            }

        }
        /// <summary>
        /// Данный метод обеспечивает снятие введенной суммы с банковского счета.
        /// </summary>
        public void Withdraw(decimal amount, decimal balance)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                BankTransaction transaction = new BankTransaction(-amount);
                transactions.Enqueue(transaction);
                Console.WriteLine($"Снято со счета: {amount} руб. Баланс после операций: {balance} руб.\n");
            }
            else
            {
                Console.WriteLine($"Невозможно снять сумму, недостаточно средств на счете! Баланс: {balance}\n");
            }
        }
        /// <summary>
        /// Данный метод обеспечивает перевод введенной суммы с одного банковского счета на другой.
        /// </summary>
        public void Transfer(BankAccount reciever, int sum)
        {
            if (sum < 0)
            {
                throw new ArgumentException("Сумма перевода не может быть отрицательной");
            }
            if (balance < sum)
            {
                throw new InvalidOperationException("На счете недостаточно средств!");
            }
            Withdraw(sum, balance);
            reciever.Deposit(sum, balance);
        }
        /// <summary>
        /// Данный метод записывает данные о транзакции в файл.
        /// </summary>
        public void Dispose()
        {
            string fileName = "transactions.txt";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (BankTransaction transaction in transactions)
                {
                    writer.WriteLine($"{transaction.TransactionTime},{transaction.Amount}");
                }
            }

            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Данный метод выводит информацию о транзакциях банковского счета.
        /// </summary>
        public void PrintTransactions()
        {
            foreach (BankTransaction transaction in transactions)
            {
                Console.WriteLine($"Время транзакции: {transaction.TransactionTime}\nСумма: {transaction.Amount} руб.");
            }
        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
        public BankAccount(decimal balance)
        {
            this.balance = balance;
            _accountNumber = GenerateAccountNumber();
            this.type = BankAccountType.Current;
            this.transactions = new Queue<BankTransaction>();
        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
        public BankAccount(BankAccountType type)
        {
            this.type = type;
            _accountNumber = GenerateAccountNumber();
            this.balance = 0;
            this.transactions = new Queue<BankTransaction>();
        }
        /// <summary>
        /// Конструктор, который создает новый экземпляр класса и заполняет его данными.
        /// </summary>
        public BankAccount(decimal balance, BankAccountType type)
        {
            _accountNumber = GenerateAccountNumber();
            this.balance = balance;
            this.type = type;
            this.transactions = new Queue<BankTransaction>();
        }
    }
}
