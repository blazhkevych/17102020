using System;
using System.Collections.Generic;
using System.Text;

namespace _17102020
{
    class Student
    {
        private static int Count;
        private readonly int Id;
        public string FirstName;
        public string LastName;
        private double salary;
        private readonly DateTime Birthday;

        static Student() // статичний конструктор(ініціалізує статичні поля нашого класу), викликається як тільки виникає взаємодія з класом
        {
            Count = 1;
        }

        public Student(string LastName, string FirstName, DateTime Birthday, double salary = 500) // дефолтний конструктор
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Birthday = Birthday;
            this.salary = salary;
            Id = Count++;
        }

        public Student(string LastName, string FirstName) :
            this(LastName, FirstName, DateTime.Now, 159) // виклик конструктора класу
        {
            //this.LastName = LastName;
            //this.FirstName = FirstName;
            //Birthday = DateTime.Now;
            //salary = 159;
            //Id = Count++;
        }

        public Student() : this("No name", "No name", DateTime.Now, 0) { } // виклик конструктора класу

        public void Print()
        {
            //Console.WriteLine($"| {Id,3:d3} |{LastName,15} |{FirstName,15} | " +
            //    $"{Birthday.ToShortDateString()} | {salary,10} |");
            Console.WriteLine(this);
        }

        public override string ToString() // перегрузка
        {
            return $"| {Id,3:d3} |{LastName,15} |{FirstName,15} | " +
                $"{Birthday.ToShortDateString()} | {salary,10} |";
        }

    }
}
