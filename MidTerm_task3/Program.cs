using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MidTerm_task3
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            Thread t = new Thread(func);
            t.Name = "Test1";

            while (true) {

                ConsoleKeyInfo pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.Enter)
                t.Start();
            if (pressedKey.Key == ConsoleKey.S)
                t.Suspend();
            if (pressedKey.Key == ConsoleKey.R)
                t.Resume();
            if (pressedKey.Key == ConsoleKey.Escape)
                {
                    t.Abort();
                    Environment.Exit(0);
                }

                     }
            

            
            
            Console.ReadKey();

        }

        static void func()
        {
            int i = 0;
            while (i < 1000)
            {
                
                Console.WriteLine(i);
                i++;
                Thread.Sleep(1000);
            }
        }
    }
}
