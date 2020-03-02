using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendDevelopment
{
    class AutoResetEventExample
    {
        static AutoResetEvent waitHandler = new AutoResetEvent(true);
        static int x = 0;

        public AutoResetEventExample (bool start)
        {
            Console.WriteLine("AutoResetEventExample");
            if (!start)
            {
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Thread {i.ToString()}";
                myThread.Start();
            }

            Console.ReadLine();
        }
        public static void Count()
        {
            waitHandler.WaitOne();
            x = 1;
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }
            waitHandler.Set();
        }
    }
}
