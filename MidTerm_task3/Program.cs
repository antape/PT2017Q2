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
            int tmp = 0;
            Console.WriteLine("Enter - start, S - susspend, R - resume, Esc - exit");
            while (true) {


                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.Enter)
                    t.Start();
                if (pressedKey.Key == ConsoleKey.S)
                {
                    t.Suspend();
                    tmp = 1;
                }
                else if ((pressedKey.Key == ConsoleKey.R) && tmp == 1)
                    t.Resume();
                    
                
            if (pressedKey.Key == ConsoleKey.Escape)
                {
                    t.Abort();
                    Environment.Exit(0);
                }

                     }
            

            
            
            

        }

        static void func()
        {
            int i = 0;
            
            while (i < 1000)
            {


                Console.SetCursorPosition(0, 1);
                Console.CursorVisible = false;
                Console.WriteLine("Sec " + i);
                
                i++;
                Thread.Sleep(1000);
            }
        }
    }
}
