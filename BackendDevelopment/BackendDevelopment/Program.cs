using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Count));

            thread.Start();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Main thread");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }

            Console.ReadLine();

        }

        public static void Count(object x)
        {
            for (int i = 0; i < 9; i++)
            {
                var n = (int) x;
                Console.WriteLine("Second thread");
                Console.WriteLine(i * n);
                Thread.Sleep(400);
            }
        }
    }
}
