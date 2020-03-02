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
            Thread thread = new Thread(new ThreadStart(Count));

            thread.Start();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Main thread");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }

            Console.ReadLine();

        }

        public static void Count()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Second thread");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }
    }
}
