using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDevelopment
{
    class TPLExample
    {
        public TPLExample(bool start)
        {
            if (!start)
            {
                return;
            }

            PartOne();
            PartTwo();
            PartThree();
            
        }

        private void PartOne()
        {
            Console.WriteLine(this.GetType().Name);

            Task taskOne = new Task(() => Console.WriteLine("task one - Hello!"));
            taskOne.Start();

            Task taskTwo = Task.Factory.StartNew(() => Console.WriteLine("task two - Hello!"));

            Task taskThree = Task.Run(() => Console.WriteLine("task three - Hello!"));

        }

        private void PartTwo()
        {
            Task [] taskList = new Task[3]
            {
                new Task(() => Console.WriteLine("first task")), 
                new Task(() => Console.WriteLine("second task")), 
                new Task(() => Console.WriteLine("third task"))
            };



            foreach (var task in taskList)
            {
                task.Start();
            }
            
            //Let's wait for all tasks
            Task.WaitAll(taskList);

            Console.WriteLine("The end of main method");
        }

        private void PartThree()
        {
            Task <Money> task = new Task<Money>(() =>
            {
                return new Money(){Value = 1000000};
            });

            Console.WriteLine($"Give me back my {task.Result.Value}$");

            task.Start();
        }

        class Money
        {
            public decimal Value { get; set; }
        }
    }
}
