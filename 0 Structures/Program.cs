using System;

namespace _0_Structures
{
    /*
     *  Структуры
     *          Для создания своего типа данных
     *          Это значимый тип, хранится в стеке. По этому копируя один экземпляр структуры в другой - копируются значения полей, а не ссылки на экземпляр
     *          Можно работать с обьектом структуры без конструктора ( при этом создаётся сам экземпляр, но без внутренней структуры (полей, свойств), по этому их надо инициализировать вручную)
     *          
     *          
     */
    struct User
    {
        public string name;
        public int age;

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}\t Age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() {age = 22, name = "Fred" }; // Используем конструктор и сразу заполняем структуру значениями
            user1.ShowInfo();

            User user2 = new User();                            // Используем конструктор, все поля заполнятся дэфолтом
            user2.ShowInfo();

            User user3;                                         // Не используем конструктор, по этому поля не создаются. Инициализируем поля вручную
            user3.name = "Bill";
            user3.age = 23;
            user3.ShowInfo();

            Console.WriteLine("Hello World!");
        }
    }
}
