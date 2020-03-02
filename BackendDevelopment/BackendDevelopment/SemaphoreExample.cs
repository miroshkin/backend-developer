﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendDevelopment
{
    class SemaphoreExample
    {
        public SemaphoreExample(bool start)
        {
            Console.WriteLine(this.GetType().Name);

            if (!start)
            {
                return;
            }

            for (int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }

            Console.ReadLine();
        }

        class Reader
        {
            // создаем семафор
            static Semaphore sem = new Semaphore(3, 3);
            Thread myThread;
            int count = 3;// счетчик чтения

            public Reader(int i)
            {
                myThread = new Thread(Read);
                myThread.Name = $"Читатель {i.ToString()}";
                myThread.Start();
            }

            public void Read()
            {
                while (count > 0)
                {
                    sem.WaitOne();

                    Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

                    Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                    Thread.Sleep(1000);

                    Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

                    sem.Release();

                    count--;
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
