using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClassWeek10_3
{
    
    delegate void PrintDelegate();
    class HelloClass
    {
        public void printHello()
        {
            Console.WriteLine("Hell");
        }
    }
    class Program
    {
        private static Timer aTimer;
        static void Main(string[] args)
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 2000;
            HelloClass h = new HelloClass();
            PrintDelegate d;
            d = h.printHello;
            aTimer.Elapsed += d.Invoke();

                //d.Invoke();
            
            Console.ReadKey();
        }
    }
}
