using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace ClassWeek6
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            Thread t = new Thread(func);
            t.Name = "Test1  ";
            t.Start();
            //Thread.Sleep(1000);

            // t.Join();
            while (i < 50)
            {
                i++;
                Console.WriteLine(Thread.CurrentThread.Name + i);

                //Thread.Sleep(100);
            }
            t.Abort();
            Console.ReadKey();

        }

        static void func()
        {
           // int i = 0;
            while (i < 50)
            {
                i++;
                Console.WriteLine(Thread.CurrentThread.Name + i);

               // Thread.Sleep(100);
            }
        }
    }
}
