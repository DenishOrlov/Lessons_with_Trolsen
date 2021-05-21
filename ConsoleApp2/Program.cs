using System;

namespace ConsoleApp2
{
    class Foo

    {

        public static string Say() { return "Foo"; }

    }

    class Bar : Foo

    {

        public static string Say() { return "Bar"; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try

            {

                throw new ArgumentException("D");

                Console.WriteLine("N");

            }

            catch (ArgumentNullException e)

            {

                Console.WriteLine("P");

            }

        }
    }
}
