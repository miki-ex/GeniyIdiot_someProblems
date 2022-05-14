using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotTestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Вариант 1: так не работает, вылетает исключение, хотя в конструкторе TestingSystem происходит инициализация полей, имеющих тип Admin и User, но
            // по факту поля admin и user будут иметь значение null 
            //  TestingSystem testSystem = new TestingSystem();
            //  testSystem.admin.ShowMessage();
            //  testSystem.user.ShowMessage();


            // Вариант 2: так тоже не работает, если передать в конструктор переменной класса TestingSystem две инициализированные переменные
            // с типами классов Admin и User: поля admin и user все равно будут иметь значение null
            //  Admin admin = new Admin();
            //  User user = new User();
            //  TestingSystem testSystem = new TestingSystem(admin, user);
            //  testSystem.admin.ShowMessage();
            //  testSystem.user.ShowMessage();

            // Вариант 3: вот так работает, но мне не понятно, почему нужно отдельно инициализировать поля admin и user, чтобы появилась возможность
            // обратиться к методам классов Admin и User
                TestingSystem testSystem = new TestingSystem();
                testSystem.admin = new Admin();
                testSystem.user = new User();
                testSystem.admin.ShowMessage();
                testSystem.user.ShowMessage();
                Console.ReadLine();
        }
    }

    public class TestingSystem
    {
        public Admin admin;
        public User user;

        // Конструктор для варианта 1 
     /*   public TestingSystem()
        {
            Admin admin = new Admin();
            User user = new User();
            Console.WriteLine("Сработал конструктор класса TestingSystem");
        }
     */
        // Конструктор для вариант 2
        //public TestingSystem(Admin a, User u)
        //{
        //     Admin admin = a;
        //     User user = u;
        //    Console.WriteLine("Сработал конструктор класса TestingSystem");
        //}

        // Конструктор для варианта 3
        public TestingSystem()
        {
           // Admin admin = new Admin();
           // User user = new User();
            Console.WriteLine("Сработал конструктор класса TestingSystem");
        }
    }

    public class Admin
    {
        public int numberOfQuestions;
        public List<string> Questions;
        public List<int> RightAnswers;

        public Admin()
        {
            Questions = new List<string>();
            numberOfQuestions = 0;
            RightAnswers = new List<int>();
            Console.WriteLine("Сработал конструктор класса Admin");
        }

        public void ShowMessage()
        {
            Console.WriteLine("Вызов метода из класса Admin");
        }
    }

    public class User
    {
        public List<int> userAnswers;
        public int numberOfRightAnswers;

        public User()
        {
            userAnswers = new List<int>();
            Console.WriteLine("Сработал конструктор класса User");
        }

        public void ShowMessage()
        {
            Console.WriteLine("Вызов метода из класса User");
        }
    }
}
