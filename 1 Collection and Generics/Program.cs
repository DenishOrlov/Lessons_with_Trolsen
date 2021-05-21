using System;
using System.Collections;
using Collectins_and_generic;

namespace MyLessons
{
    /*
     * Коллекции и обобщеия
     * 
     * Необобщённая коллекция
     * 
     *      При необобщённой коллекции, происходит упаковка данных в тип Object
     * 
     *        Класс                               Описание                                                                                    Основные интерфейсы
     *        
     *      ArrayList  - даёт массив(коллекцию) с динамически изменяемым размером, хранит обьекты последовательно                IList, ICollection, IEnumerable, IClonable 
     * 
     *      BitArray  -  даёт массив бинарных значений, елементы - булевые: true(1)/false(0)                                     ICollection, IEnumerable, IClonable 
     * 
     *      Hashtable  - даёт массив(коллекцию) пар "ключ, значение", организованных на основе хэшкода                           IDirectionaly, ICollection, IEnumerable, IClonable 
     * 
     *      Queue      - даёт стандартную очередь: первый вошёл - первый вышел                                                   ICollection, IEnumerable, IClonable 
     * 
     *      SortedList - даёт массив(коллекцию) пар "ключ, значение" отсортированных по ключу, с доступом по ключу и индексу     IDirectionaly, ICollection, IEnumerable, IClonable 
     * 
     *      Stack      - даёт стек (last in first oute LIFO), поддерживающий функционал заталкивания, выталкивания, считывания   ICollection, IEnumerable, IClonable
     *      -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
     *      
     *       Интерфейс
     *       
     *      IСollection - Определяет общие характеристики (например: размер, перечисление, безопасность к потокам) для всех необобщённых типов коллекций
     *      
     *      IClonable   - Позволяет возвращать копию себя
     *      
     *      IDictionary - Позволяет обьекту необобщённой коллекции хранится в виде "ключ - значение"
     *      
     *      IEnumerable - Возвращает обьект реализующий интерфейс IEnumerator
     *      
     *      IList       - Обеспечивает поведение: добавление, удаление, индексирование элементов в последовательном списке
     */

    public static class MyListArray                        // Статик класс. Не умеет реализацию интерфейсов и наследования
    {


    }
    class Program
    {
        static void ShowArray(ArrayList listArr)
        {
            foreach (var item in listArr)
            {
                Console.WriteLine(item +"\t");
            }
        }
        static void Main(string[] args)
        {
            ArrayList containerArray = new ArrayList();
            containerArray.Add("asd_0");                    // Добавили элемент в список 
            containerArray.Add("asd_1");                    // Добавили в список 
            containerArray.Add("asd_2");                    // Добавили в список 

            containerArray.AddRange(new int [] { 1,2,3});   // Добавляем список элементов

            ShowArray(containerArray);

            Console.WriteLine("Введите элемент");
            containerArray.Add(Console.ReadLine());
            ShowArray(containerArray);

            Math.Round(1.23);

            // Упаковка / распаковка
            int intVar = 10;
            Object boxedInt = intVar;
            int unboxedInt = (int)boxedInt;

            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            
            person3.Print();
        }
    }
}
