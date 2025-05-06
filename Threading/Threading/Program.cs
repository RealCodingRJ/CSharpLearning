using System;

namespace Threading
{
    class Program
    {
        public static void printName()
        {
            Console.WriteLine($"Hello Ryan");
            Console.ReadLine();
        }

        static void Main(string[] _)
        {
          
            
            Thread th = new Thread(printName);
            th.Start();

        }
    }
}