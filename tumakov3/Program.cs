using System;

namespace MyApp
{
    internal class Program
    {
        enum Bank //упражнение 3.1
        {
            BankAccFirst,
            BankAcctSecond
        }
        struct BankAccount  //упражнение 3.2
        {
            public int number;
            public string type;
            public float balance;

            public void Print()  
            {
                Console.WriteLine($"Номер карты: {number}, тип карты: {type}, баланс карты: {balance}");
            }

        }
        enum University // домашнее задание 3.1
        {
            KSU,
            KAI,
            KHTI

        }
        struct Worker
        {
            public string name;
            public University place;

            public void Print()
            {
                Console.WriteLine($"работник - {name}, ВУЗ - {place}");
            }
        }
        static void Main(string[] args) 
        {
            //упражнение 3.1
            Console.WriteLine("упражнение 3.1");
            Bank now = Bank.BankAccFirst;
            Console.WriteLine($"{now}");

            //упражнение 3.2
            Console.WriteLine("упражнение 3.2");
            BankAccount card = new BankAccount();
            card.number = 88885555;
            card.type = "кредитная";
            card.balance = 1111.15f; 
            card.Print();

            //домашнее задание 3.1
            Console.WriteLine("домашнее задание 3.1");
            Worker worker = new Worker();
            worker.name = "Иван Петров";
            worker.place = University.KAI;
            worker.Print();
            

       


        }



    }
}