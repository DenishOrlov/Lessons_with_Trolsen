using System;

namespace _4._9._3_Generic_parametrs
{
    /*
     * Указание параметров типа для обобщённых интерфейсов
     */

   
    public interface IComparable<T>             // Обьявляем обобщённый интерфейс 
    {
        int CompareTo(T obj);                   // Обьявляем метод. Тип параметра - T  
    }

    public class Car : IComparable<Car>
    {
        int IComparable<Car>.CompareTo(Car car) // Делаем явную реализацию интерфейса
        {
            return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
