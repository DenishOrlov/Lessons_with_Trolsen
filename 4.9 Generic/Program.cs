using System;
using System.Collections.Generic;

namespace _4._9_Generic
{
    /*
     * Обобщённые коллекции
     *      
     *      Суть коллекции обобщения - безопасность к типам данных
     * 
     *      При работе с обобщённой коллекцией не происходит упаковки - что быстрее
     *      
     *      Обобщением могут быть: классы, структуры, интерфейсы, делегаты; но не enum!
     */
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public Person()
        {

        }
        public Person(string firstName, string lastName, int age) // Определяем конструктор
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public void Print()
        {
            Console.WriteLine($"{FirstName}\t{LastName}\tAge: {Age}");
        }
        
    } 
    class Program
    {
        static void UseGenericList()
        {
            List<Person> morePeople = new List<Person>();          // Обьявляем обьект типа List, который может хранить тип данных только Person
            morePeople.Add(new Person("Frank", "Black", 50));      // Добавляем в обьект morePeople с помощью методов List экземпляр обьекта Person 
            morePeople[0].Print();                                 // Обращаемся к методу экземпляра класса

            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(4);
            int sum = moreInts[0] + moreInts[1];
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            UseGenericList();
            Console.WriteLine("Hello World!");
        }
    }
}
