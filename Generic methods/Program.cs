using System;

namespace Generic_methods
{
    /*
     * Зачем нужен обобщённый метод - выполнять одно действие для разных типов данных. 
     * То есть если у нас есть логика, которую нужно применять к разным типам данных - делаем метод с типом данных "Т"
     * 
     */

    class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private Byte age;
        private Byte Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Неверно введён возраст, слишком малый");         // Оставит значение Инеу по дэфолту
                    
                if (value > 150)
                    Console.WriteLine("Неверно введён возраст, слишком старый");        // Оставит значение Инеу по дэфолту
                else
                    age = value;                                                        // Запишит значение
            }
        }
        public void SetPersonValues(string firstName, string lastName, Byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public void Print(string addedText = "")
        {
            Console.WriteLine($"{addedText}: {FirstName} {LastName} {Age}");
        }
    }
    class Program
    {
        static void Swap(ref int firstValue, ref int secondValue)
        {
            int temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }
        static void SwapPerson(ref Person firstPerson, ref Person secondPerson)
        {
            Person temp = firstPerson;
            firstPerson = secondPerson;
            secondPerson = temp;
        }

        static void SwapGeneric<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 6;
            Console.WriteLine($"a:{a} b:{b}");

            Swap(ref a,ref b);
            Console.WriteLine($"a:{a} b:{b}");



            Person person1 = new Person();
            person1.SetPersonValues("Дав", "Лат", 20);

            Person person2 = new Person();
            person2.SetPersonValues("Рук", "Айлд", 12);

            person1.Print("person1");
            person2.Print("person2");

            SwapPerson(ref person1, ref person2);

            Console.WriteLine();

            person1.Print("person1");
            person2.Print("person2");

            Console.WriteLine();

            SwapGeneric(ref a, ref b);

            SwapGeneric(ref person1, ref person2);

            person1.Print("person1");
            person2.Print("person2");

            Console.WriteLine();



        }
    }
}
