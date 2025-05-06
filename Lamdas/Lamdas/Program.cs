using System;

namespace Lamdas
{
    class Program
    {
        public static void Main(string[] _)
        {
            static string Name(String name) => name;


            Console.WriteLine(Name("Ryan"));
            Console.ReadLine();

        }
    }
}