using System;

namespace _5_Delegates
{
    /*
     * Делегаты
     *      Делегаты - это обьект, указывающий на другой метод или список методов, которые будут вызываться позднее  
     *      Указывают на static методы или на методы экземпляра
     *      Используют, когда за раз нужно вызвать несколько методов
     *      Поддерживает три порции информации : 1. Адрес метода к которому обращается
     *                                           2. Аргументы (если есть) вызываемого метода
     *                                           3. Возвращаемое значение (если есть) метода
     */

    public delegate void Message();                            // Создаём делегат без параметров

    public delegate int Operation(int x, int y);               // Создаём делегат с параметрами

    class Calculations
    {
        public static int Sum(int firstValue, int secondValue) // Создаём метод, который соответствует делегату
        {
            return firstValue + secondValue;                   // Возвращаем значение
        }
        public static int Multiply(int x, int y) => x * y;     // Метод с использованием лямбда-выражения
        public static int Substarct(int x, int y) => x - y; 
    }

    class Program
    {
        private static void GoodMorning()                      // Метод без возращаемого значения, выводящий текст
        {
            Console.WriteLine("Good morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good evening");
        }


        static void Main(string[] args)
        {
            Message message;                                   // Определяем обьект типа делегата
            if (DateTime.Now.Hour < 12)
            {
                message = GoodMorning;                         // Присваиваем экземпляру делегата метод GoodMorning  
            }
            else
            {
                message = GoodEvening;                         // Присваиваем экземпляру делегата метод GoodEvening
            }
            message();                                         // Вызываем метод хранящийся в делегате



            Operation oper1 = new Operation(Calculations.Sum); // Создаём обьект делегата и в конструкторе передаем 

            int result = oper1(122, 68);                       // Вызываем метод с помощью делегата и записываем значение
            Console.WriteLine(result);                         // 

            oper1 += Calculations.Multiply;                    //
            oper1 += Calculations.Substarct;                   //

            Console.WriteLine(oper1.GetInvocationList().Length);// Метод возвращает массив обьектов в экземпляре делегата

            Console.WriteLine(oper1.Invoke(12,30));             // Идентичная запись
            Console.WriteLine(oper1(12,30));                    // Идентичная запись



            Console.ReadKey();
        }
    }
}
