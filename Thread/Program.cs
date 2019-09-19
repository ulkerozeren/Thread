using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
 
            new Thread(Thread1).Start();
        }

        public static void Thread1()
        {
            int tur = 1;
            while (true)
            {
                Console.WriteLine("Threasd-1 "+ tur);
                tur++;
                Thread.Sleep(100);
            }
        }

        public static void Thread2()
        {
            int tur = 1;
            while (true)
            {
                Console.WriteLine("Threasd-2 " + tur);
                tur++;
                Thread.Sleep(200);
            }
        }

        public static void Thread3()
        {
            int tur = 1;
            while (true)
            {
                Console.WriteLine("Threasd-3 " + tur);
                tur++;
                Thread.Sleep(400);
            }
        }
    }
}
