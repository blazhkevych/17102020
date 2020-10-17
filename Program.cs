using System;
using System.Linq;
using System.Text;

namespace _17102020
{
    class Program
    {
        static void TestStudent()
        {
            Student Ivan = new Student("Ivanenko", "Ivan", new DateTime(1996, 10, 25), 639);
            Student Petro = new Student("Petrenko", "Petro", new DateTime(2003, 3, 22), 869);
            Student Inna = new Student("Klymenko", "Inna");
            Student Anna = new Student();
            //Ivan.Print();
            //Petro.Print();
            //Inna.Print();
            //Anna.Print();
            Console.WriteLine(Ivan);
            Console.WriteLine(Petro);
            Console.WriteLine(Inna);
            Console.WriteLine(Anna);
        }

        static void Main(string[] args)
        {
            TestStudent();
        }

        static void TestClaSS(string[] args)
        {
            //класи (ссилочні типи даних)
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Hello World!");

            //Student Ivan=null;
            //Student Ivan = new Student();
            //Ivan.LastName = "Ivanenko";
            //Ivan.FirstName = "Ivan";
            //Console.WriteLine($"->>|{Ivan}|");
            //Ivan.Print();
            // Student.s = 200;
            //Console.WriteLine($"->>|{Student.s}|");
            //Console.WriteLine($"->>|{Student.c}|");
            //Console.WriteLine($"->>|{Ivan.r}|");
            // Ivan.mas[1] = 5;
            //Ivan.mas = new int[] { 1, 5, 69, 69, 9 }; // не працює
            //Console.WriteLine($"->>|{String.Join(" ", Ivan.mas)}|"); // вивід масиву поля класу
            int pp = 999;
            // Ivan.Test(pp);
            Console.WriteLine($"pp->|{pp}|");
            //Ivan.Test(pp, "Hi");
            // Ivan.Test(Ivan);
            //Ivan.Print();
            // Student.TestStatic(10, 52);
            TestStaticProgram(15, 98);
            Sum(10, 20, 30);
            Sum(10, 20);
            Sum();
            Sum(c: 10, a: 20, b: 30);
            Sum(b: 20, a: 30);

            int aa = 20;
            Change(aa);
            Console.WriteLine($"|{aa}|");

            //int oo = 20;
            int oo;
            ChangeOut(out oo); //
            Console.WriteLine($"|{oo}|");

            int rr = 20;
            //int rr; // error
            ChangeRef(ref rr);
            Console.WriteLine($"|{rr}|");
            int a = 1;
            int b = 2;

            Console.WriteLine($"a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            Console.WriteLine($"|{Suma("test1 = ", 1, 2, 3, 4, 5)}|");
            Console.WriteLine($"|{Suma("test2 = ", 1)}|");
            // Console.WriteLine($"|{Suma(1,6)}|"); // error
            Console.WriteLine($"|{Suma()}|");
            Console.WriteLine($"|{Suma("test4 = ", new int[] { 1, 2, 3, 4, 5 })} |");


        }

        public static void TestStaticProgram(int a, int b)
        {
            Console.WriteLine($"|{a}+{b}={a + b}|");
            // Test(10); // не працює
        }

        public static void Sum(int a = 1, int b = 2, int c = 3)
        {
            Console.WriteLine($"|{a}+{b}+{c}={a + b + c}|");
            // Test(10); // не працює
        }

        public static void Change(int a)
        {
            a = 50;
        }

        public static void ChangeOut(out int a) // по ссилці обовязково змінній присвоїти значення
        {
            a = 100;
            Console.WriteLine($"|{a}|");
        }

        public static void ChangeRef(ref int a) // по ссилці (не вимагає ініціалізації)
        {
            //a = 150;
            Console.WriteLine($"|{a}|");
        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static int Suma(string str = "test", params int[] list)
        {
            Console.Write($"|{str}|");
            //int s = 0;
            //foreach (var item in list)
            //    s += item;
            return list.Sum();
        }
    }


    //internal class Student
    //public class Student
    //{
    //    // статичні, константні поля
    //    public static int s = 100; // статичне поле (спільна для всіх обєктів нашого класу)
    //    public const int c = 300; // не можемо змінювати (не явно статичні)
    //    public readonly int r = 400; // може ініціалізуватись прямо в класі або в конструкторі, наадлі поле не змінюється
    //    public readonly int[] mas = { 1, 2, 3 };

    //    private int Id = 123321;
    //    // protected int Id;
    //    // internal int Id; // internal - будемо мати доступ лише в межах цієї збірки
    //    // protected internal int Id; // internal - будемо мати доступ лише в межах цієї збірки з наслідуванням
    //    public string FirstName;
    //    public string LastName;
    //    private double salary;
    //    private DateTime Birthday;

    //    public void Print()
    //    {
    //        Console.WriteLine($"|{Id}|{LastName}|{FirstName}|{Birthday.ToShortDateString()}|{salary}|");
    //    }

    //    public void Test(int k)
    //    {
    //        k = 666;
    //        Console.WriteLine($"k = |{k}|");
    //    }

    //    public void Test(int k, string str)
    //    {
    //        Console.WriteLine($"k = |{k}| str = |{str}|");
    //        TestStatic(10, 20);
    //    }

    //    public void Test(Student s)
    //    {
    //        s.FirstName = "Petro";
    //        s = new Student();
    //    }

    //    public static void TestStatic(int a, int b)
    //    {
    //        Console.WriteLine($"|{a}+{b}={a + b}|");
    //        // Test(10); // не працює
    //    }
    //}
}