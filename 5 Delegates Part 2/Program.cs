using System;

namespace _5_Delegates_Part_2
{
    class Calculations
    {
        public static int Sum(int firstValue, int secondValue)   // Создаём метод, который соответствует делегату
        {
            return firstValue + secondValue;                     // Возвращаем значение
        }
        public static int Multiply(int x, int y) => x * y;       // Метод с использованием лямбда-выражения
        public static int Substarct(int x, int y) => x - y;

        public int Divide(int x, int y) => x / y;
      
    }

    public delegate int Operation(int x, int y);                  // Создаём делегат с параметрами

    class Program
    {
        static void ShowDelegateInfo(Delegate itemDelegate)       // Создаём метод, в качестве параметра указываем переменную 
        {
            
            foreach(var item in itemDelegate.GetInvocationList()) // Перебераем элементы массива (методы), которые получили с помощью GetInvocationList() из делегата
                Console.WriteLine($"Method: {item.Method}\tType: {item.Target}");
        }
        static void Main(string[] args)
        {
            
            Operation operation1;                                 // Создаём переменную делегата
            operation1 = Calculations.Sum;                        // Записываем в переменную статический метод класса Calculations (без экземпляра, потому что статический)
            operation1 += Calculations.Multiply;
            operation1 += Calculations.Substarct;

            Calculations calculations1 = new Calculations();      // Создаём обьект класса

            operation1 += calculations1.Divide;                   // Не статический метод указываем через экземпляр класса
            ShowDelegateInfo(operation1);
        }
    }
}
