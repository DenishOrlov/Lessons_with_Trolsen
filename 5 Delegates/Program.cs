using System;

namespace _5_Delegates
{
    /*
     * Делегаты
     *      Делегаты - это обьект, указывающий на другой метод или список методов, которые будут вызываться позднее  
     *      Указывают на static методы или на методы экземпляра
     *      Поддерживает три порции информации : 1. Адрес метода к которому обращается
     *                                           2. Аргументы (если есть) вызываемого метода
     *                                           3. Возвращаемое значение (если есть) метода
     */

    public delegate void Message();              // Создаём делегат без параметров

    public delegate int Operation(int x, int y); // Создаём делегат с параметрами
    class Program
    {
        static void Main(string[] args)
        {
            Message message;                     // Обьявляем экземпляр делегата
            if (DateTime.Now.Hour < 12)
            {
                message = GoodMorning;           // Присваиваем экземпляру делегата метод GoodMorning  
            }
            else
            {
                message = GoodEvening;           // Присваиваем экземпляру делегата метод GoodEvening
            }

            message();                           // Вызываем метод хранящийся в делегате
            Console.ReadKey();
        }
        private static void GoodMorning()        // Метод выводящий текст
        {
            Console.WriteLine("Good morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good evening");
        }

    }
}
