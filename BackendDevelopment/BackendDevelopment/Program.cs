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
            Thread thread = Thread.CurrentThread;
            

            Console.WriteLine($"Thread name : {thread.Name}");
            thread.Name = "TestThread";

            Console.WriteLine($"Thread name : {thread.Name}");
            Console.WriteLine($"Thread is alive : {thread.IsAlive}");
            Console.WriteLine($"Priority : {thread.Priority}");
            Console.WriteLine($"Thread state : {thread.ThreadState}");
            Console.WriteLine($"App domain : {Thread.GetDomain().FriendlyName}");
            Console.ReadLine();

        }
    }
}
