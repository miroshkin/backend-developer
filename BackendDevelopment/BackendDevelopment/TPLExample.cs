using System;
using System.Collections.Generic;
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

            Console.WriteLine(this.GetType().Name);

            Task taskOne = new Task(() => Console.WriteLine("task one - Hello!"));
            taskOne.Start();

            Task taskTwo = Task.Factory.StartNew(() => Console.WriteLine("task two - Hello!"));

            Task taskThree = Task.Run(() => Console.WriteLine("task three - Hello!"));
            
            Console.ReadLine();
        }
    }
}
