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
            var example1 = new AutoResetEventExample(false);
            var example2 = new MonitorExample(false);
            var example3 = new MutexExample(false);
            var example4 = new SemaphoreExample(true);
        }

    }

   
}
