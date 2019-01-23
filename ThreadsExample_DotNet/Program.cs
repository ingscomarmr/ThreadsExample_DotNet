using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsExample_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inician los Threads");

            Thread task1 = new Thread(new ThreadStart(PrintTime));
            task1.Start();

            ThreadStart tStart = new ThreadStart(PrintTime2);
            Thread task2 = new Thread(tStart);
            task2.Start();

            Console.WriteLine("Finaliza programa");
            Console.ReadKey();
        }

        public static void PrintTime() {
            for (int i = 1; i <= 10; i++) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("P1:{0}",DateTime.Now.ToString("hh:mm:ss"));
                Thread.Sleep(1000);
            }
        }

        public static void PrintTime2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("P2:{0}", DateTime.Now.ToString("hh:mm:ss"));
                Thread.Sleep(2000);
            }
        }
    }
}
