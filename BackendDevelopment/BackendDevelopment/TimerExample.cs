using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendDevelopment
{
    class TimerExample
    {
        public TimerExample(bool start)
        {
            if (!start)
            {
                return;
            }

            Console.WriteLine(this.GetType().Name);

            int num = 0;
            TimerCallback timerCallback = new TimerCallback(Count);
            Timer timer = new Timer(timerCallback, num, 0, 2000);

            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }
    }
}
